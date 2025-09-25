using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using model_demo.Models;

namespace model_demo.Controllers
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
            var user = new List<User>();
            var user1 = new User();
            user1.name = "Mark Smith";
            user1.address = "Park Street";
            user1.email = "Mark@mvcexample.com";
            var user2 = new User();
            user2.name = "John Parker";
            user2.address = "New Park";
            user2.email = "John@mvcexample.com";
            var user3 = new User();
            user3.name = "Steave Edward ";
            user3.address = "Melbourne Street";
            user3.email = "steave@mvcexample.com";
            user.Add(user1); user.Add(user2);
            user.Add(user3);
            ViewBag.user = user; 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
