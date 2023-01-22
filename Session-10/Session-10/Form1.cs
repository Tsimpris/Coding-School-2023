using Session_10.Libs;
using System.ComponentModel.Design.Serialization;

namespace Session_10
{
    public partial class Form1 : Form
    {
        private University _university;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<University> _universit = new List<University>();
            University university1 = new University()
            {
                Students = "Tsimpris",
                Courses = "Programming",
                Grades = 6,
                //university1.ScheduledCourses = ;
            };

            University university2 = new University()
            {
                Students = "Giannis",
                Courses = "Maths",
                Grades = 7,
                //university1.ScheduledCourses = ;
            };

            _universit.Add(university1);
            _universit.Add(university2);

            dataGridView1.DataSource = _universit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "test.json");
        }
    }
}