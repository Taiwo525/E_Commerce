using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Models;
using System.Diagnostics;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
		}

        public IActionResult Index(int count)
        {
            
            var products = new List<Product>();
            var random = new Random();
            var categories = new[] { "Electronics", "Books", "Clothing", "Toys", "Groceries" };
            count = 100;
            for (int i = 1; i <= count; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"This is the description for product {i}.",
                    Category = categories[random.Next(categories.Length)],
                    Price = (decimal)(random.NextDouble() * 999.99 + 0.01),
                    ImageFile = $"image{i}.jpg",
                    CreatedDate = DateTime.UtcNow
                };
                products.Add(product);
            }

           
            return View(products);
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
