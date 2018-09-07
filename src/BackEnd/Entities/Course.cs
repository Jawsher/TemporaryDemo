using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Entities
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseNumber { get; set; }
        public double Credits { get; set; }
    }
}
