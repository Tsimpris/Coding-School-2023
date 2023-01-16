using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class University
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }
        public Schedule[] Schedules { get; set; }

        public University() { }


    }
}
