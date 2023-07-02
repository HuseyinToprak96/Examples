using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Identity.Models;

namespace Web.Identity.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            var user= _userManager.FindByEmailAsync(username);
            return Redirect("/Home/Index");
        }
    }
}
