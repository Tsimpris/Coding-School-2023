using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Professor : Person
    {
        public string? Rank { get; set; }
        public Course[] Courses { get; set; }

        public Professor()
        {
            Courses = new Course[20];
        }
        public Professor(Guid id, string name, string rank, Course[] courses) : base(id, name)
        {
            Rank = rank;
            Courses = courses;
        }

        public void Teach(Course course, DateTime datime) { }
        public void SetGrade(Grade grade) { }
    }
}
