namespace _07.TimerDijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "08";
            label2.Text = "55";
            label3.Text = "00";
        }
        int saat = 8, dakika = 53, saniye = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (timer3.Enabled == true)
            {
                saniye++;
                label3.Text = saniye.ToString();
                if (Convert.ToInt16(label3.Text) < 10)
                {
                    label3.Text = "0" + saniye.ToString();
                }
                if (saniye == 60)
                {
                    saniye = 0;
                    timer2.Enabled = true;
                    dakika++;
                    label2.Text = dakika.ToString();
                    if (Convert.ToInt16(label2.Text) < 10)
                    {
                        label2.Text = "0" + dakika.ToString();
                    }
                    if (dakika == 60)
                    {
                        dakika = 0;
                        timer1.Enabled = true;
                        saat++;
                        label1.Text = saat.ToString();
                        if (Convert.ToInt16(label1.Text) < 10)
                        {
                            label1.Text = "0" + saat.ToString();
                        }
                    }

                }
            }
        }
    }
}