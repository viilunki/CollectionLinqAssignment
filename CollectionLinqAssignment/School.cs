using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLinqAssignment
{
    public class Student
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }
        public double GPA { get; set; }
        public double Grade { get; set; }
        public List<Subject> Subject { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public double Score { get; set; }
    }

    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
