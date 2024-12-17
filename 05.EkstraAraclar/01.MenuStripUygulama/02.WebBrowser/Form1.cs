using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.WebBrowser
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser;

        public Form1()
        {
            InitializeComponent();

            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            browser = new ChromiumWebBrowser()
            {
                Width = webBrowser1.Width,        // WebBrowser kontrolünün genişliği
                Height = webBrowser1.Height,     // WebBrowser kontrolünün yüksekliği
                Location = webBrowser1.Location, // WebBrowser kontrolünün konumu
                Anchor = webBrowser1.Anchor,     // Bağlama kurallarını kopyala
                Dock = webBrowser1.Dock
            };

            this.Controls.Remove(webBrowser1);
            this.Controls.Add(browser);
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Emirhan Polat tarafından yapılmıştır.", "Hakkımızda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.youtube.com/watch?v=hEJnMQG9ev8&ab_channel=WarnerBros.Pictures");
            label1.Visible = true;
            label1.Text = madMaxToolStripMenuItem.Text;
        }

        private void psILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.youtube.com/watch?v=CZzW6_hR068&ab_channel=Movieclips");
            label1.Visible = true;
            label1.Text = psILoveYouToolStripMenuItem.Text;
            
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.youtube.com/watch?v=9ItBvH5J6ss&ab_channel=20thCenturyStudios");
            label1.Visible = true;
            label1.Text = aynıYıldızınAltındaToolStripMenuItem.Text;
            
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.youtube.com/watch?v=k10ETZ41q5o&ab_channel=WarnerBros.Pictures");
            label1.Visible = true;
            label1.Text = korkuSeansıToolStripMenuItem.Text;
            
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.youtube.com/watch?v=7BWWWQzTpNU&ab_channel=SonyPicturesEntertainment");
            label1.Visible = true;
            label1.Text = uzayYolcularıToolStripMenuItem.Text;
            
        }
    }
}
