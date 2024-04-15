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
            MessageBox.Show("Provet är inlämnat");
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
            sw.WriteLine("2. Kod i två symboler som 1 och 0.");
            sw.WriteLine("3. Översätter kod till datorns språk.");
            sw.WriteLine("4. Använder kodblock för att lättare skriva kod.");
            sw.WriteLine("5. Lär en dator att lära sig själv.");
            sw.WriteLine("6. 1936");
            sw.WriteLine("7. Nej");
            sw.WriteLine("8. Antalet transistorer dubblas vartannat år alltså datorkraften dubblas vartannat år.");
            sw.WriteLine("9. Moores lag kommer troligen att sluta gälla p.g.a att transistorerna blir så som att kvantfysiken kan krångla och vi inte \r\n   längre vet vart elektronerna är. Eftersom transistorerna inte kan bli mindre måste man antingen göra datorer större eller \r\n   utveckla och programmera så att programmen m.m blir mer effektiv så det inte behövs lika mycket datakraft.");
            sw.WriteLine("10. Gör så att koden är ofentlig och att alla kan ta del av den. Användarna får rätten att använda, ändra på programvaran och \r\n    distrubera den till vem som helst för alla ändamål.");
            sw.WriteLine("11. För att en annan ska lätt kunna följa den koden som man har gjort och för att det ska vara lätt att förstå. Om man jobbar som en programmerare\r\n    och till exempel blir sjuk en dag måste en annan person ta över din kod och därför är det viktigt att du inte ändrar din kodningstil så att \r\n    personen kan så lätt som möjligt fortsätta med din kod.");
            sw.WriteLine("12. Alla operativsystem fungerar på olika sätt och därför måste man programmera olika beroende på vilket operativsystem applikationen ska köras i.");
            sw.WriteLine("13.AI har gjort det lättare att programmera då man lätt kan få svar på det man behöver, AI har gett oss fler möjligheter. Vi kan nu låta en \r\n    dator t. ex analysera data och utifrån det fatta beslut på en mycket mer avancerad nivå än innan.");
            sw.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}