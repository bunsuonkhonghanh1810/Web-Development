using Microsoft.AspNetCore.Mvc;
using Lab06.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab06.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();
        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" },
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = students.Count + 1;
                students.Add(student);
                return RedirectToAction("Index");
            }
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" },
            };
            return View();
        }
    }
}
