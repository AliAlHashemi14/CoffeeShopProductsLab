using CoffeeShopProducts.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProducts.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeShopDBContext context = new CoffeeShopDBContext();

        public IActionResult Index()
        {
            List<Product> result = context.Products.ToList();
            return View(result);
        }

        public IActionResult Detail(int postId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == postId);
            return View(p);
        }
    }
}
