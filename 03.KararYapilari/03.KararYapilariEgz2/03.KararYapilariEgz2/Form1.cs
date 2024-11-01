namespace _03.KararYapilariEgz2
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

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = 8;
            int adet;
            double tutar;

            adet = Convert.ToInt16(textBox1.Text);
            tutar = adet * fiyat;
            
            if (adet >= 0 && adet < 21)
            {
                tutar = tutar * 0.8;
            }
            else if (adet >= 21 && adet < 41)
            {
                tutar = tutar * 0.6;
            }
            else if (adet > 40)
            {
                tutar = tutar * 0.5;
            }
            else
            {
                MessageBox.Show("Yanlış giriş yapıldı!");
            }
            label4.Text = tutar + " TL";

        }
    }
}

// 0-20 ==> %20
// 21-40 ==> %40
// 41++ ==> %50
// Tüm kitaplar 8 TL