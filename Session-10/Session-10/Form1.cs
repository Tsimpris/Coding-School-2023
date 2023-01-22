namespace Session_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<University> univeristy= new List<University>();
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

            univeristy.Add(university1);
            univeristy.Add(university2);

            dataGridView1.DataSource = univeristy;
        }
    }
}