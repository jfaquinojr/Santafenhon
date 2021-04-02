using Santafenhon.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Piranha;

namespace Santafenhon.Web.Shared.Identity
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var serviceScopeFactory = serviceProvider.GetService<IServiceScopeFactory>();
            using var scope = serviceScopeFactory.CreateScope();

            var db = (ApplicationDbContext)scope.ServiceProvider.GetService(typeof(ApplicationDbContext));
            if(db.Users.Count() > 0)
            {
                return; // no need to seed
            }

            string[] roles = new string[] { "SysAdmin", "Superuser", "Webuser" };

            var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
            foreach (string rn in roles)
            {
                if (!db.Roles.Any(r => r.Name == rn))
                {
                    var result = roleManager.CreateAsync(new IdentityRole(rn)).Result;
                }
            }

            var user = new IdentityUser
            {
                Email = "jfaquinojr@gmail.com",
                NormalizedEmail = "JFAQUINOJR@GMAIL.COM",
                UserName = "jfaquinojr@gmail.com",
                NormalizedUserName = "JFAQUINOJR@GMAIL.COM",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };


            if (!db.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<IdentityUser>();
                var hashed = password.HashPassword(user, "asdf1234");
                user.PasswordHash = hashed;

                var userStore = new UserStore<IdentityUser>(db);
                var result = userStore.CreateAsync(user).Result;
            }

            var _userManager = scope.ServiceProvider.GetService<UserManager<IdentityUser>>();
            var result2 = AssignRoles(_userManager, user.Email, roles).Result;



            // Make sure our SysAdmin role has all of the available claims
            var role = db.Roles.FirstOrDefault(r => r.NormalizedName == "SYSADMIN");
            //foreach (var claim in Piranha.Security.Permission.All())
            foreach (var permission in App.Permissions.GetPermissions())
            {
                var roleClaim = db.RoleClaims.FirstOrDefault(c =>
                    c.RoleId == role.Id && c.ClaimType == permission.Name && c.ClaimValue == permission.Name);
                if (roleClaim == null)
                {
                    db.RoleClaims.Add(new IdentityRoleClaim<string>
                    {
                        RoleId = role.Id,
                        ClaimType = permission.Name,
                        ClaimValue = permission.Name
                    });
                }
            }

            db.SaveChangesAsync();
        }

        public static async Task<IdentityResult> AssignRoles(UserManager<IdentityUser> userManager, string email, string[] roles)
        {
            //var _userManager = services.GetService<UserManager<IdentityUser<string>>>();
            var user = await userManager.FindByEmailAsync(email);
            var result = await userManager.AddToRolesAsync(user, roles);

            return result;
        }
    }
}
