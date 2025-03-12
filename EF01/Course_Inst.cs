using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class Course_Inst
    {
        [Key]
        public int inst_ID { get; set; }
       
        public int Course_ID { get; set; }
        [Required]
        public decimal evaluate { get; set; }
    }
}
