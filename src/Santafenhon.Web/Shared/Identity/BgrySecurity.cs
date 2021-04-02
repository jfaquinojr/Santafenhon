using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Piranha;
using Piranha.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Santafenhon.Web.Shared.Identity
{
    public class BgrySecurity : ISecurity
    {
        private readonly SignInManager<IdentityUser> signInManager;

        public BgrySecurity(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public async Task<bool> SignIn(object context, string username, string password)
        {
            var result = await signInManager.PasswordSignInAsync(username, password, false, false);
            return result.Succeeded;
        }

        public async Task SignOut(object context)
        {
            await signInManager.SignOutAsync();
        }
    }
}
