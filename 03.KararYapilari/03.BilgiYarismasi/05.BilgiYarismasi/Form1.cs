namespace _05.BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            sikA.Enabled = true;
            SikB.Enabled = true;
            sikC.Enabled = true;
            sikD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi �ehir Ege b�lgesinde bulunmaz";
                sikA.Text = "�zmir";
                SikB.Text = "Bal�kesir";
                sikC.Text = "Ayd�n";
                sikD.Text = "Manisa";
                label4.Text = "Bal�kesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Ku�lar hangi yazar�m�za aittir";
                sikA.Text = "Sait Faik";
                SikB.Text = "Cemal S�reyya";
                sikC.Text = "Attila �lhan";
                sikD.Text = "Re�at Nuri";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Oyunu Bitir";
            }
            if (soruNo > 3)
            {
                soruNo--;
                lblSoruNo.Text = soruNo.ToString();
                richTextBox1.Text = "Quiz sona ermi�tir.";
                sikA.Enabled = false;
                SikB.Enabled = false;
                sikC.Enabled = false;
                sikD.Enabled = false;
                MessageBox.Show("Do�ru Say�s�: " + dogru + "\nYanl�� Say�s�: " + yanlis);
            }

        }

        private void sikA_Click(object sender, EventArgs e)
        {
            sikA.Enabled = false;
            SikB.Enabled = false;
            sikC.Enabled = false;
            sikD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = sikA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void SikB_Click(object sender, EventArgs e)
        {
            sikA.Enabled = false;
            SikB.Enabled = false;
            sikC.Enabled = false;
            sikD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = SikB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void sikC_Click(object sender, EventArgs e)
        {
            sikA.Enabled = false;
            SikB.Enabled = false;
            sikC.Enabled = false;
            sikD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = sikC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void sikD_Click(object sender, EventArgs e)
        {
            sikA.Enabled = false;
            SikB.Enabled = false;
            sikC.Enabled = false;
            sikD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = sikD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soruNo++;
            richTextBox1.Visible = true;
            label1.Visible = true;
            lblSoruNo.Visible = true;
            label2.Visible = true;
            LblDogru.Visible = true;
            label3.Visible = true;
            LblYanlis.Visible = true;
            btnSonraki.Visible = true;
            sikA.Visible = true;
            SikB.Visible = true;
            sikC.Visible = true;
            sikD.Visible = true;
            button1.Visible = false;
            lblSoruNo.Text = soruNo.ToString();
            btnSonraki.Enabled = false;

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                sikA.Text = "1920";
                SikB.Text = "1921";
                sikC.Text = "1922";
                sikD.Text = "1923";
                label4.Text = "1923";

            }



        }
    }
}