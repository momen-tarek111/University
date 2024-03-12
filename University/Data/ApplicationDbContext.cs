using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Metadata;
using University.Models;
namespace University.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Programm" },
                new Department { Id = 2, Name = "marketing" });
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "C++" },
                new Course { Id = 2, Name = "C#" },
                new Course { Id = 3, Name = "C" },
                new Course { Id = 4, Name = ".NET" },
                new Course { Id = 5, Name = "Nodjs" }
                );
            modelBuilder.Entity<Professor>().HasData(
              new Professor { Id = 1,DepartmentID=1, Name = "momen", },
              new Professor { Id = 2,DepartmentID=1, Name = "mina" },
              new Professor { Id = 3, DepartmentID = 2, Name = "amira" }
              );
        }
    }
}
