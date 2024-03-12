using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
