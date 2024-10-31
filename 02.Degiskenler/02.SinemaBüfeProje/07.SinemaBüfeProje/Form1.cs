namespace _07.SinemaBüfeProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;

            misir = Convert.ToInt16(TxtMısır.Text);
            su = Convert.ToInt16(Txtsu.Text);
            cay = Convert.ToInt16(Txtcay.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            toplam = misir * 4 + cay * 2 + bilet * 8 + su * 1;
            kasatutar = kasatutar + toplam;

            lbltoplam.Text = toplam.ToString() + " TL";
            lblkasa.Text = kasatutar.ToString() + " TL";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = " ";
            Txtcay.Text = " ";
            TxtMısır.Text = " ";
            Txtsu.Text = " ";
            // Focus() --> imleci elemana odaklamaya yarar
            TxtMısır.Focus();
        }
    }
}