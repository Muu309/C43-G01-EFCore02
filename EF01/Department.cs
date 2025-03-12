using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(ManagerId))]
        public int ManagerId { get; set; }
        public Instructor instructor { get; set; }



        public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> students { get; set; } = new HashSet<Student>();

    }
}
