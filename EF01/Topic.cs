using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    [Table("Topic")]
    internal class Topic
    {
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
