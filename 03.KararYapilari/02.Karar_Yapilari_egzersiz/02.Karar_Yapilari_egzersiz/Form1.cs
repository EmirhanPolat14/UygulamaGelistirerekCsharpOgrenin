namespace _02.Karar_Yapilari_egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ortalama;
            string durum;

            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            proje = Convert.ToInt16(textBox3.Text);
            ortalama = (s1 + s2 + proje) / 3;

            if (ortalama >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldý";
            }
            textBox4.Text = "Ortalama: " + ortalama.ToString("00.00") + "-" + durum;
        }
    }
}