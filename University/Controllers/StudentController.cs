using Microsoft.AspNetCore.Mvc;
using University.Data;
using University.Models;

namespace University.Controllers
{
    public class StudentController(ApplicationDbContext _db) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateStudent(int id)
        {
            Student student = _db.Students.FirstOrDefault(x =>x.Id == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            Student s = _db.Students.FirstOrDefault(x => x.Id == student.Id);
            s.FirstName= student.FirstName;
            s.LastName= student.LastName;
            s.Email= student.Email;
            s.Major= student.Major;
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            Student student= _db.Students.FirstOrDefault(y => y.Id == id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AssignCourse(int id )
        {
            Student student = _db.Students.FirstOrDefault(p => p.Id == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult AssignCourse(int id,Student student)
        {
            Course course = _db.Courses.FirstOrDefault(x => x.Id == id);
            student = _db.Students.FirstOrDefault(p => p.Id == student.Id);
            student.Courses.Add(course);
            return RedirectToAction("");
        }
        public IActionResult ViewAllStudent()
        {
            return View(_db.Students.ToList());
        }
        public IActionResult EnrolledCourseForStudent(int id) { 
            Student s= _db.Students.FirstOrDefault(x => x.Id == id);
            return View(s);
        }
    }
}
