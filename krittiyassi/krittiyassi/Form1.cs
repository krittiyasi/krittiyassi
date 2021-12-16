namespace krittiyassi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBoxC.Text;
            double C = Convert.ToDouble(input);
            double F = C * 9 / 5 + 32;
            textBoxF.Text = F.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double F = Convert.ToDouble(input);
            double C = (F - 32) * 5 / 9;
            textBoxC.Text = C.ToString();
        }
    }
}