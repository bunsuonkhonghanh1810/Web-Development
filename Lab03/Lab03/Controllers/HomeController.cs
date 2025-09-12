using System.Diagnostics;
using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var newestProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "https://kangaroo.vn/wp-content/uploads/noi-com-dien-kg-822.jpg" },
                new Product { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "https://kangaroo.vn/wp-content/uploads/noi-com-dien-kg-822.jpg" },
                new Product { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "https://kangaroo.vn/wp-content/uploads/noi-com-dien-kg-822.jpg" }
            };

            return View(newestProducts);
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
