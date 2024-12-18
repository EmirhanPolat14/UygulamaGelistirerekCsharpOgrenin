using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.LotoUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();

            int s1, s2, s3, s4;
            s1 = rast.Next(1,5);
            s2 = rast.Next(1, 5);
            s3 = rast.Next(1, 5);
            s4 = rast.Next(1, 5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            TextBox[] boxs = { textBox1, textBox2, textBox3, textBox4 };

            foreach(TextBox i in boxs)
            {
                if (i.Text == label1.Text)
                {
                    i.BackColor = Color.Green;
                }
                else { i.BackColor = Color.Red; }
            }
        }
    }
}
