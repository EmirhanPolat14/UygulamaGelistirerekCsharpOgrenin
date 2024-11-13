namespace _09.Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == 1000)
            {
                label1.BackColor = Color.Green;
                timer1.Stop();
                
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value == 100)
            {
                label2.BackColor = Color.Green;
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value == 100)
            {
                label3.BackColor = Color.Green;
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 2;
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Kekiniz hazýr. Afiyet Olsun...");
            }

        }
    }
}