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
    public partial class FrmIstaistik : Form
    {
        public FrmIstaistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=<mssqadresi>");


        private void FrmIstaistik_Load(object sender, EventArgs e)
        {
            // Toplam personel sayısı
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel", baglanti);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                lblsnc1.Text = dr1[0].ToString();
            }
            dr1.Close();
            //evli personel sayısı
            SqlCommand kmt2 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel WHERE PerDurum=1",baglanti);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                lblsnc2.Text = dr2[0].ToString();
            }
            dr2.Close();
            // bekar personel
            SqlCommand kmt3 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel WHERE PerDurum=0",baglanti);
            SqlDataReader dr3 = kmt3.ExecuteReader();
            while (dr3.Read()) { lblsnc3.Text = dr3[0].ToString(); }
            dr3.Close();
            // sehir sayısı
            SqlCommand kmt4 = new SqlCommand("SELECT COUNT(DISTINCT PerSehir) FROM Tbl_Personel", baglanti);
            SqlDataReader dr4 = kmt4.ExecuteReader();
            while (dr4.Read()) { lblsnc4.Text = dr4[0].ToString(); }
            dr4.Close();
            // Toplam maaş
            SqlCommand kmt5 = new SqlCommand("SELECT SUM(PerMaas) FROM Tbl_Personel", baglanti);
            SqlDataReader dr5 = kmt5.ExecuteReader();
            while (dr5.Read()) { lblsnc5.Text = dr5[0].ToString(); }
            dr5.Close();
            // Ortalama Maaş
            SqlCommand kmt6 = new SqlCommand("SELECT AVG(PerMaas) FROM Tbl_Personel", baglanti);
            SqlDataReader dr6 = kmt6.ExecuteReader();
            while (dr6.Read()) { lblsnc6.Text = dr6[0].ToString(); }
            dr6.Close();
            baglanti.Close();

          
            
        }
    }
}
