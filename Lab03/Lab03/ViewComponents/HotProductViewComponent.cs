using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var hotProducts = new List<Product>
            {
                new Product { Id = 4, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "https://kangaroo.vn/wp-content/uploads/noi-com-dien-kg-822.jpg" },
                new Product { Id = 5, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "https://kangaroo.vn/wp-content/uploads/noi-com-dien-kg-822.jpg" },
                new Product { Id = 6, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "https://kangaroo.vn/wp-content/uploads/noi-com-dien-kg-822.jpg" }
            };
            return View(hotProducts);
        }
    }
}
