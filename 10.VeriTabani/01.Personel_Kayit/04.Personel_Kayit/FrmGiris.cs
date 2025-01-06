using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _04.Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=<mssqladresi>");

        private void btngir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gkmt = new SqlCommand("SELECT * FROM Tbl_Yonetici WHERE kullaniciAd=@p1 AND Sifre=@p2", baglanti);
            gkmt.Parameters.AddWithValue("@p1", txtad.Text);
            gkmt.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr1 = gkmt.ExecuteReader();

            if (dr1.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else { MessageBox.Show("Hatalı kullanıcı adı veya şifre."); }
            baglanti.Close();
        }
    }
}
