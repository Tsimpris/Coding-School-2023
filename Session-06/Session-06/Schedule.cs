using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule() { }
        public Schedule(Guid id)
        {
            ID = id;
        }
        public Schedule(Guid id, Guid courseId)
        {
            ID = id;
            CourseID = courseId;
        }
        public Schedule(Guid id, Guid courseId, Guid professorID)
        {
            ID = id;
            CourseID = courseId;
            ProfessorID = professorID;
        }
        public Schedule(Guid id, Guid courseId, Guid professorID, DateTime calendar)
        {
            ID = id;
            CourseID = courseId;
            ProfessorID = professorID;
            Calendar = calendar;
        }

    }
}
