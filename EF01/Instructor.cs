using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Adress { get; set; }
        public decimal HourRate { get; set; }

        [InverseProperty(nameof(Department.ManagerId))]
        public Department ManageDept { get; set; }

        [ForeignKey(nameof(WorkForDepartment))]
        public int? Dept_id { get; set; }
        public Department WorkForDepartment { get; set; }


        public ICollection<Course_Inst> instructorCourses { get; set; } = new HashSet<Course_Inst>();


    }
}
