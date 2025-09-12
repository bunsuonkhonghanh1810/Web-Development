using Microsoft.AspNetCore.Mvc;

namespace Lab03.Models
{
    public class Product : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
