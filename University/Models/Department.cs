using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
