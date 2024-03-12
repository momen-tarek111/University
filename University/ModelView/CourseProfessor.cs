using University.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace University.ModelView
{
    public class CourseProfessor
    {
        public Course? Courses { get; set; }
        public List<Professor> _professor { get; set; }
        public List<Course> _Courses { get; set; }
        public CourseProfessor(List<Professor> professor)
        {
            _professor = professor;
        }
        public CourseProfessor(List<Professor> professor,List<Course>course)
        {
            _professor = professor;
            _Courses = course;
        }
    }
}
