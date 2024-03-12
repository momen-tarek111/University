using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Models;
using University.ModelView;

namespace University.Controllers
{
    public class CourseController(ApplicationDbContext _db) : Controller
    {
        private static CourseProfessor modelview;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCourse()
        {
            modelview=new CourseProfessor(_db.Professors.ToList());
            return View(modelview);
        }
        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
           _db.Courses.Add(course);
           _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateCourse(int id)
        {
            Course course = _db.Courses.FirstOrDefault(c => c.Id == id);
            return View(course);
        }
        [HttpPost]
        public IActionResult UpdateCourse(Course course)
        {
            Course co=_db.Courses.FirstOrDefault(p=> p.Id == course.Id);
            co.Name = course.Name;
            co.ProfessorId = course.ProfessorId;
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCourse(int id)
        {
            Course course= _db.Courses.FirstOrDefault(p=> p.Id == id);
            _db.Courses.Remove(course);
            return RedirectToAction("Index");
        }
        public IActionResult ViewAllCourse()
        {
            modelview = new CourseProfessor(_db.Professors.ToList(),_db.Courses.ToList());
            return View(modelview);
        }
    }
}
