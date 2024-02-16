namespace Provhanterare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText("answers.txt");
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text4 = textBox4.Text;
            string text5 = textBox5.Text;
            sw.WriteLine(text1);
            sw.WriteLine(text2);
            sw.WriteLine(text4);
            sw.WriteLine(text5);
            sw.Close();
            
        }

    }
}