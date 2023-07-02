using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Identity.Models;

namespace Web.Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager,ILogger<HomeController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public 
async Task<IActionResult> SignUp(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
        AppUser appUser=new AppUser { UserName=user.Username,
        Email=user.Email ,
         PhoneNumber=user.PhoneNumber};        
                 var identityResult= await _userManager.CreateAsync(appUser,user.Password);
            if (identityResult.Succeeded) { 
return RedirectToAction("Login", "Home");
                }
                else
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError("",error.Description);
                    }
                }

            }
            return View(user);

        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
