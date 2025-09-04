using Microsoft.AspNetCore.Mvc.Rendering;

namespace View.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPages { get; set; }
        public string Summary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/chi-pheo_72e3f1370e484cf49b0fc94ee4ce0f80_master.jpg",
                    Price = 500000,
                    Summary = "",
                    TotalPages = 250
                }
            };

            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Nam Cao" },
            new SelectListItem { Value = "2", Text = "Thiền sư Thích Nhất Hạnh" },
            new SelectListItem { Value = "3", Text = "Hoàng Nam Tiến" },
            new SelectListItem { Value = "4", Text = "Tố Hữu" }
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Văn học đương đại" },
            new SelectListItem { Value = "2", Text = "Lịch sử, văn học" },
            new SelectListItem { Value = "3", Text = "Phật học phổ thông" },
            new SelectListItem { Value = "4", Text = "Văn học thiếu nhi" }
        };
    }
}
