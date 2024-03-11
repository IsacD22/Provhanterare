namespace Provhanterare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vill du se facit?");
            StreamWriter sw = File.CreateText("answers.txt");
            List<FlowLayoutPanel> questions = tableLayoutPanel1.Controls.OfType<FlowLayoutPanel>().ToList();
            for(int i = 0; i < questions.Count; i++)
            {
                string key = i + 1+". ";
                List<RadioButton> buttons = questions[i].Controls.OfType<RadioButton>().ToList();
                for(int j = 0; j < buttons.Count; j++)
                {
                    if (buttons[j].Checked)
                    {
                        key += buttons[j].Text;
                        sw.WriteLine(key);
                    }
                    
                }
            }
            sw.WriteLine("9. " + textBox1.Text);
            sw.WriteLine("10. " + textBox2.Text);
            sw.WriteLine("11. " + textBox3.Text);
            sw.WriteLine("12. " + textBox4.Text);
            sw.WriteLine("13. " + textBox5.Text);
            sw.Close();
            MessageBox.Show("Vill du se facit?");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}