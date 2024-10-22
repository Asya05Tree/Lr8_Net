using Lr8.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lr8.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: /Product
        public IActionResult List()
        {
            var products = _configuration.GetSection("Products").Get<List<Product>>();
            return View(products);
        }

        // GET: /Product/Details/5
        public IActionResult Details(int id)
        {
            var products = _configuration.GetSection("Products").Get<List<Product>>();
            var product = products?.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}