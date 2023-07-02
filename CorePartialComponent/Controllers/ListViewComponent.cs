using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication5.Controllers
{
    [ViewComponent(Name ="ListViewComponent")]
    public class ListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<string> list = new List<string> { "A", "B", "C" };
            return View(list);
        }
    }
}
