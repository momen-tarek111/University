﻿using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }

    }
}
