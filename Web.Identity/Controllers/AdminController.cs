using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web.Identity.Models;

namespace Web.Identity.Controllers
{
    
    public class AdminController : Controller
    {
        private UserManager<AppUser> _userManager { get;}

        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }

    }
}
