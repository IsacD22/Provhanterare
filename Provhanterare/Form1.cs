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

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Provet �r inl�mnat");
            StreamWriter sw = File.CreateText("answers.txt");
            List<FlowLayoutPanel> questions = tableLayoutPanel3.Controls.OfType<FlowLayoutPanel>().ToList();
            for (int i = 0; i < questions.Count; i++)
            {
                string key = i + 1 + ". ";
                List<RadioButton> buttons = questions[i].Controls.OfType<RadioButton>().ToList();
                for (int j = 0; j < buttons.Count; j++)
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
            sw = File.CreateText("key.txt");
            sw.WriteLine("1. Skapa liv");
            sw.WriteLine("2. Kod i tv� symboler som 1 och 0.");
            sw.WriteLine("3. �vers�tter kod till datorns spr�k.");
            sw.WriteLine("4. Anv�nder kodblock f�r att l�ttare skriva kod.");
            sw.WriteLine("5. L�r en dator att l�ra sig sj�lv.");
            sw.WriteLine("6. 1936");
            sw.WriteLine("7. Nej");
            sw.WriteLine("8. Antalet transistorer dubblas vartannat �r allts� datorkraften dubblas vartannat �r.");
            sw.WriteLine("9. Moores lag kommer troligen att sluta g�lla p.g.a att transistorerna blir s� som att kvantfysiken kan kr�ngla och vi inte \r\n   l�ngre vet vart elektronerna �r. Eftersom transistorerna inte kan bli mindre m�ste man antingen g�ra datorer st�rre eller \r\n   utveckla och programmera s� att programmen m.m blir mer effektiv s� det inte beh�vs lika mycket datakraft.");
            sw.WriteLine("10. G�r s� att koden �r ofentlig och att alla kan ta del av den. Anv�ndarna f�r r�tten att anv�nda, �ndra p� programvaran och \r\n    distrubera den till vem som helst f�r alla �ndam�l.");
            sw.WriteLine("11. F�r att en annan ska l�tt kunna f�lja den koden som man har gjort och f�r att det ska vara l�tt att f�rst�. Om man jobbar som en programmerare\r\n    och till exempel blir sjuk en dag m�ste en annan person ta �ver din kod och d�rf�r �r det viktigt att du inte �ndrar din kodningstil s� att \r\n    personen kan s� l�tt som m�jligt forts�tta med din kod.");
            sw.WriteLine("12. Alla operativsystem fungerar p� olika s�tt och d�rf�r m�ste man programmera olika beroende p� vilket operativsystem applikationen ska k�ras i.");
            sw.WriteLine("13.AI har gjort det l�ttare att programmera d� man l�tt kan f� svar p� det man beh�ver, AI har gett oss fler m�jligheter. Vi kan nu l�ta en \r\n    dator t. ex analysera data och utifr�n det fatta beslut p� en mycket mer avancerad niv� �n innan.");
            sw.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}