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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=<mssqladresi>");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtg1 = new SqlCommand("SELECT PerSehir, Count(PerSehir) FROM Tbl_Personel GROUP BY PerSehir", baglanti);
            SqlDataReader dr1 = kmtg1.ExecuteReader();
            while (dr1.Read())
            {
                chart2.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            dr1.Close();
            SqlCommand kmtg2 = new SqlCommand("SELECT PerMeslek, AVG(PerMaas) FROM Tbl_Personel GROUP BY PerMeslek ORDER BY 2 DESC", baglanti);
            SqlDataReader dr2 = kmtg2.ExecuteReader();
            while (dr2.Read()) { chart1.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]); }

            baglanti.Close();
        }
    }
}
