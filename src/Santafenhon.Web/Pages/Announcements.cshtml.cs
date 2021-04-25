using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Piranha;
using Piranha.AspNetCore.Models;
using Piranha.AspNetCore.Services;
using Santafenhon.Web.Models.Cms;

namespace Santafenhon.Web.Pages
{
    public class AnnouncementsModel : PageModel
    {
        public AnnouncementsModel(IApi api, IModelLoader modelLoader)
        {

        }


        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
    }
}
