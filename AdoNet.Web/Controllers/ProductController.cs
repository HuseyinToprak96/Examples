using AdoNet.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdoNet.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var data=_productRepository.GetAll();
            return View(data);
        }
    }
}
