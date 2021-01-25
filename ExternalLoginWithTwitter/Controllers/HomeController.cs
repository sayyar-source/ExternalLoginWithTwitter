using ExternalLoginWithTwitter.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExternalLoginWithTwitter.Controllers
{
    public class HomeController : Controller
    {
      
  

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
         return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("TwitterResponse") }, "Twitter");
        }
        public async Task<IActionResult> TwitterResponse()
        {
            var clim = HttpContext.User;
            string nameIdentifier = clim.FindFirst(ClaimTypes.NameIdentifier).Value;
            string name = clim.Identity.Name;
            return RedirectToAction("index");
        }
     // [Authorize]
        public async Task<IActionResult> Logout()

        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
              
            }
            return RedirectToAction("index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

   
    }
}
