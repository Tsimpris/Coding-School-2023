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

        public Professor(Guid id) : base(id) { }
        public Professor(Guid id, string name) : base(id, name) { }
        public Professor(Guid id, string name, int age) : base(id, name, age) { }
        public Professor(Guid id, string name, int age, string rank) : base(id, name, age)
        {
            Rank = rank;
           
        }

        public Professor(Guid id, string name, int age, string rank, Course[] courses) : base(id, name, age)
        {
            Rank = rank;
            Courses = courses;

        }

        public void Teach(Course course, DateTime datime) { }
        public void SetGrade (Guid studentID, Guid courseID, Grade grade) { }
        public void GetName() { }
    }
}
