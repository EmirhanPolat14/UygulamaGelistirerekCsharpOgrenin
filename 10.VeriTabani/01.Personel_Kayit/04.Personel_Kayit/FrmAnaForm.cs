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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=<mssqladresi>");
        public void temizle()
        {
            txtId.Text = string.Empty;
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            mtextMaas.Text = string.Empty;
            rdbtnBekar.Checked = false;
            rdbtnEvli.Checked = false;
            cbSehir.Text = string.Empty;
            txtId.Focus();

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
            string[] sehirler = { "İstanbul", "Ankara", "Aydın","Yalova","Bursa","Adana", "İzmir", "Erzurum", "Çanakkale" };
            cbSehir.Items.AddRange(sehirler);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel([PerAd], [PerSoyad], " +
                                              "[PerSehir],[PerMaas], [PerDurum], [PerMeslek])" +
                                              "VALUES(@p1, @p2, @p3,@p4,@p5,@p6)", baglanti);
            //SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel([PerAd], [PerSoyad]) VALUES(@p1, @p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mtextMaas.Text);
            komut.Parameters.AddWithValue("@p6", mtxtMeslek.Text);
            //1.YÖNTEM:
            //if (rdbtnBekar.Checked){
            //    komut.Parameters.AddWithValue("@p5", false);
            //}else if(rdbtnEvli.Checked){ komut.Parameters.AddWithValue("@p5", true);}
            //2.YÖNTEM:
            komut.Parameters.AddWithValue("@p5", label8.Text);



            //Ekleme silme ve güncelleme sorgularında ExecuteNonQuery kullanılır.
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Eklendi!");

           
        }

        private void rdbtnEvli_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void rdbtnBekar_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void btnTemiz_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtextMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mtxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            string durum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if ( durum == "True")
            {
                rdbtnEvli.Checked = true;
            }else if (durum == "False") { rdbtnBekar.Checked = true; }

            //);
            //komut.Parameters.AddWithValue("@p4", .Text);
            //komut.Parameters.AddWithValue("@p6", mtxtMeslek.Text

                //Console.WriteLine(secilen);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM Tbl_Personel WHERE Perid=@p1",baglanti);
            delete.Parameters.AddWithValue("@p1", txtId.Text);
            delete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel başarıyla silindi");
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand update = new SqlCommand("UPDATE Tbl_Personel " +
                                                "SET PerAd=@p1," +
                                                "PerSoyad = @p2," +
                                                "PerSehir = @p3," +
                                                "PerMaas = @p4," +
                                                "PerDurum = @p5," +
                                                "PerMeslek = @p6" +
                                                " WHERE Perid = @p7"
                                                , baglanti);
            update.Parameters.AddWithValue("@p1", txtAd.Text);
            update.Parameters.AddWithValue("@p2", txtSoyad.Text);
            update.Parameters.AddWithValue("@p3", cbSehir.Text);
            update.Parameters.AddWithValue("@p4", mtextMaas.Text);
            update.Parameters.AddWithValue("@p5", label8.Text);
            update.Parameters.AddWithValue("@p6", mtxtMeslek.Text);
            update.Parameters.AddWithValue("@p7", txtId.Text);
            update.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Personel bilgisi güncellendi!");
        }

        private void btnIstat_Click(object sender, EventArgs e)
        {
            FrmIstaistik frstat = new FrmIstaistik();
            frstat.Show();
        }

        private void btngraf_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }
    }
}
