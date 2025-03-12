using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class Course
    {
        public int Id { get; set; }
        public decimal Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(Topic))]
        public int? Top_id { get; set; }

        public Topic Topic { get; set; }
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();

        public ICollection<Course_Inst> InstructorCourses { get; set; } = new HashSet<Course_Inst>();




    }
}
