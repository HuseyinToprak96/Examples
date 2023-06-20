using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {

        public readonly ISingletonDateService _singletonDateService;

        public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService = singletonDateService;
        }

        public IActionResult Index([FromServices] ISingletonDateService singletonDateService)
        {
            ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = singletonDateService.GetDateTime.TimeOfDay.ToString();
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
    }
}