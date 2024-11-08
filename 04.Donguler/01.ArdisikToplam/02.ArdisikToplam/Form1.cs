namespace _02.ArdisikToplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam += i;

            //}
            //label1.Text = toplam.ToString();


            for (int i = 0; i <= 10; i += 2)
            {
                toplam += i;
            }
            label2.Text= toplam.ToString();
        }
    }
}