using System.Collections;
using System.Collections.Generic;

namespace Manytomany.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> Courses { get; set; }
    }
}
