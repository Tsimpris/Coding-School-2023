namespace Session_09
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "0";
            }
            else { 
            TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}