using Microsoft.AspNetCore.Mvc;
using WebTask.Models;

namespace WebTask.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(_Students);
        }

        private static readonly List<Student> _Students = new()
        {
            new() { Id = 1, LastName = "Иванов", Name = "Иван", Patr = "Иванович", Age = 21, Rating = 86, GroupId = 3},
            new() { Id = 2, LastName = "Петров", Name = "Петр", Patr = "Петрович", Age = 22, Rating = 69, GroupId = 1},
            new() { Id = 3, LastName = "Максимов", Name = "Максим", Patr = "Максимович", Age = 23, Rating = 51, GroupId = 2},
        };

        public IActionResult Details(int id)
        {
            var stud = _Students.FirstOrDefault(s => s.Id == id);
            if (stud == null)
                return NotFound();
            return View(stud);
        }

        public IActionResult Edit(int id)
        {
            var stud = _Students.FirstOrDefault(s => s.Id == id);
            if (stud == null)
                return NotFound();
            return View(stud);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var stud = _Students.FirstOrDefault(s => s.Id == student.Id);
            if (stud == null)
                return NotFound();
            stud.LastName = student.LastName;
            stud.Name = student.Name;
            stud.Patr = student.Patr;
            stud.Rating = student.Rating;
            stud.Age = student.Age;

            return RedirectToAction("Index");
        }

    }

}
