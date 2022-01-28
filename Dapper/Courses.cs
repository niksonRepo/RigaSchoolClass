using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperProject
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("FK_Courses_Students")]
        public int StudentId { get; set; }
    }
}
