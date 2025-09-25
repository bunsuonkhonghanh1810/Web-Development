using Lab05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab05.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FullName = "Do Quang", Gender = "Male", Phone = "0123456789", Email = "quang@gmail.com", Salary = 5000, Status = "Active" },
            new Employee { Id = 2, FullName = "Tran Viet", Gender = "Male", Phone = "0987654321", Email = "viet@gmail.com", Salary = 6000, Status = "Inactive" }
        };

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            emp.Id = employees.Max(e => e.Id) + 1;
            employees.Add(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            var existing = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (existing == null) return NotFound();

            existing.FullName = emp.FullName;
            existing.Gender = emp.Gender;
            existing.Phone = emp.Phone;
            existing.Email = emp.Email;
            existing.Salary = emp.Salary;
            existing.Status = emp.Status;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null) employees.Remove(emp);
            return RedirectToAction("Index");
        }
    }
}
