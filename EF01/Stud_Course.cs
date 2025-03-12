using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    [Table("Stud_Course")]
    internal class Stud_Course
    {
        [Key]
        public int Stud_id { get; set; }
        
        public int Course_ID { get; set; }
        [Required]
        public decimal Grade { get; set; }
    }
}
