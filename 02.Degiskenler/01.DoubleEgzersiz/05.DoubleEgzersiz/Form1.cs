namespace _05.DoubleEgzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje; 
            double ortalama;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ortalama = (s1 + s2 + proje) / 3;

            listBox1.Items.Add("�sim:" + ad + " " +
                "Soyisim:" + soyad+ " " +
                "Not Ortalamas�:" + ortalama);

                
        }
    }
}