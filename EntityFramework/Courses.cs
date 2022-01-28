using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
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
