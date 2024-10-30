namespace _06.UcakBiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + " " + "Tarih: " + dateTimePicker1.Text + " Saat: " +
                maskedTextBox1.Text + " Yolcu Bilgileri ~ Ad Soyad: " + textBox1.Text + " Tc No: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu kaydý yapýldý.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = a;
        }
    }
}