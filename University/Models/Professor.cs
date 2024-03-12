using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public int? DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public string Name { get; set; }
        
    }
}
