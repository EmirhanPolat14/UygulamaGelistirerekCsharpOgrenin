namespace _04.Personel_Kayit
{
    partial class FrmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.grpboxKayit = new System.Windows.Forms.GroupBox();
            this.mtextMaas = new System.Windows.Forms.MaskedTextBox();
            this.rdbtnBekar = new System.Windows.Forms.RadioButton();
            this.rdbtnEvli = new System.Windows.Forms.RadioButton();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.mtxtMeslek = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpbxIslem = new System.Windows.Forms.GroupBox();
            this.btngraf = new System.Windows.Forms.Button();
            this.btnIstat = new System.Windows.Forms.Button();
            this.btnTemiz = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.gboxKytEkran = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet1 = new _04.Personel_Kayit.PersonelVeriTabaniDataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personelVeriTabaniDataSet = new _04.Personel_Kayit.PersonelVeriTabaniDataSet();
            this.personelVeriTabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter = new _04.Personel_Kayit.PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.grpboxKayit.SuspendLayout();
            this.grpbxIslem.SuspendLayout();
            this.gboxKytEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxKayit
            // 
            this.grpboxKayit.Controls.Add(this.mtextMaas);
            this.grpboxKayit.Controls.Add(this.rdbtnBekar);
            this.grpboxKayit.Controls.Add(this.rdbtnEvli);
            this.grpboxKayit.Controls.Add(this.cbSehir);
            this.grpboxKayit.Controls.Add(this.mtxtMeslek);
            this.grpboxKayit.Controls.Add(this.label6);
            this.grpboxKayit.Controls.Add(this.label7);
            this.grpboxKayit.Controls.Add(this.label5);
            this.grpboxKayit.Controls.Add(this.label4);
            this.grpboxKayit.Controls.Add(this.txtSoyad);
            this.grpboxKayit.Controls.Add(this.label3);
            this.grpboxKayit.Controls.Add(this.txtAd);
            this.grpboxKayit.Controls.Add(this.label2);
            this.grpboxKayit.Controls.Add(this.txtId);
            this.grpboxKayit.Controls.Add(this.label1);
            this.grpboxKayit.Location = new System.Drawing.Point(1, 1);
            this.grpboxKayit.Name = "grpboxKayit";
            this.grpboxKayit.Size = new System.Drawing.Size(447, 391);
            this.grpboxKayit.TabIndex = 0;
            this.grpboxKayit.TabStop = false;
            this.grpboxKayit.Text = "Personel Kayıt";
            // 
            // mtextMaas
            // 
            this.mtextMaas.Location = new System.Drawing.Point(169, 212);
            this.mtextMaas.Mask = "0000";
            this.mtextMaas.Name = "mtextMaas";
            this.mtextMaas.Size = new System.Drawing.Size(184, 36);
            this.mtextMaas.TabIndex = 5;
            this.mtextMaas.ValidatingType = typeof(int);
            // 
            // rdbtnBekar
            // 
            this.rdbtnBekar.AutoSize = true;
            this.rdbtnBekar.Location = new System.Drawing.Point(265, 251);
            this.rdbtnBekar.Name = "rdbtnBekar";
            this.rdbtnBekar.Size = new System.Drawing.Size(88, 32);
            this.rdbtnBekar.TabIndex = 7;
            this.rdbtnBekar.TabStop = true;
            this.rdbtnBekar.Text = "Bekar";
            this.rdbtnBekar.UseVisualStyleBackColor = true;
            this.rdbtnBekar.CheckedChanged += new System.EventHandler(this.rdbtnBekar_CheckedChanged);
            // 
            // rdbtnEvli
            // 
            this.rdbtnEvli.AutoSize = true;
            this.rdbtnEvli.Location = new System.Drawing.Point(169, 251);
            this.rdbtnEvli.Name = "rdbtnEvli";
            this.rdbtnEvli.Size = new System.Drawing.Size(67, 32);
            this.rdbtnEvli.TabIndex = 6;
            this.rdbtnEvli.TabStop = true;
            this.rdbtnEvli.Text = "Evli";
            this.rdbtnEvli.UseVisualStyleBackColor = true;
            this.rdbtnEvli.CheckedChanged += new System.EventHandler(this.rdbtnEvli_CheckedChanged);
            // 
            // cbSehir
            // 
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(169, 165);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(184, 36);
            this.cbSehir.TabIndex = 4;
            // 
            // mtxtMeslek
            // 
            this.mtxtMeslek.Location = new System.Drawing.Point(169, 298);
            this.mtxtMeslek.Name = "mtxtMeslek";
            this.mtxtMeslek.Size = new System.Drawing.Size(184, 36);
            this.mtxtMeslek.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şehir:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(169, 123);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(184, 36);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(169, 83);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(184, 36);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(169, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(184, 36);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // grpbxIslem
            // 
            this.grpbxIslem.Controls.Add(this.btngraf);
            this.grpbxIslem.Controls.Add(this.btnIstat);
            this.grpbxIslem.Controls.Add(this.btnTemiz);
            this.grpbxIslem.Controls.Add(this.btnguncel);
            this.grpbxIslem.Controls.Add(this.btnSil);
            this.grpbxIslem.Controls.Add(this.btnKaydet);
            this.grpbxIslem.Controls.Add(this.btnlistele);
            this.grpbxIslem.Location = new System.Drawing.Point(454, 1);
            this.grpbxIslem.Name = "grpbxIslem";
            this.grpbxIslem.Size = new System.Drawing.Size(349, 391);
            this.grpbxIslem.TabIndex = 1;
            this.grpbxIslem.TabStop = false;
            this.grpbxIslem.Text = "İşlemler";
            // 
            // btngraf
            // 
            this.btngraf.Location = new System.Drawing.Point(55, 292);
            this.btngraf.Name = "btngraf";
            this.btngraf.Size = new System.Drawing.Size(249, 36);
            this.btngraf.TabIndex = 2;
            this.btngraf.Text = "Grafikler";
            this.btngraf.UseVisualStyleBackColor = true;
            this.btngraf.Click += new System.EventHandler(this.btngraf_Click);
            // 
            // btnIstat
            // 
            this.btnIstat.Location = new System.Drawing.Point(55, 250);
            this.btnIstat.Name = "btnIstat";
            this.btnIstat.Size = new System.Drawing.Size(249, 36);
            this.btnIstat.TabIndex = 2;
            this.btnIstat.Text = "İstatistik";
            this.btnIstat.UseVisualStyleBackColor = true;
            this.btnIstat.Click += new System.EventHandler(this.btnIstat_Click);
            // 
            // btnTemiz
            // 
            this.btnTemiz.Location = new System.Drawing.Point(55, 208);
            this.btnTemiz.Name = "btnTemiz";
            this.btnTemiz.Size = new System.Drawing.Size(249, 36);
            this.btnTemiz.TabIndex = 2;
            this.btnTemiz.Text = "Temizle";
            this.btnTemiz.UseVisualStyleBackColor = true;
            this.btnTemiz.Click += new System.EventHandler(this.btnTemiz_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.Location = new System.Drawing.Point(55, 166);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(249, 36);
            this.btnguncel.TabIndex = 2;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(55, 124);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(249, 36);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(55, 82);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(249, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(55, 40);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(249, 36);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // gboxKytEkran
            // 
            this.gboxKytEkran.Controls.Add(this.dataGridView1);
            this.gboxKytEkran.Location = new System.Drawing.Point(1, 398);
            this.gboxKytEkran.Name = "gboxKytEkran";
            this.gboxKytEkran.Size = new System.Drawing.Size(998, 241);
            this.gboxKytEkran.TabIndex = 2;
            this.gboxKytEkran.TabStop = false;
            this.gboxKytEkran.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet1;
            // 
            // personelVeriTabaniDataSet1
            // 
            this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelVeriTabaniDataSetBindingSource
            // 
            this.personelVeriTabaniDataSetBindingSource.DataSource = this.personelVeriTabaniDataSet;
            this.personelVeriTabaniDataSetBindingSource.Position = 0;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(853, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1005, 651);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboxKytEkran);
            this.Controls.Add(this.grpbxIslem);
            this.Controls.Add(this.grpboxKayit);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxKayit.ResumeLayout(false);
            this.grpboxKayit.PerformLayout();
            this.grpbxIslem.ResumeLayout(false);
            this.gboxKytEkran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxKayit;
        private System.Windows.Forms.RadioButton rdbtnBekar;
        private System.Windows.Forms.RadioButton rdbtnEvli;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.MaskedTextBox mtxtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpbxIslem;
        private System.Windows.Forms.Button btngraf;
        private System.Windows.Forms.Button btnIstat;
        private System.Windows.Forms.Button btnTemiz;
        private System.Windows.Forms.Button btnguncel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox gboxKytEkran;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtextMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource personelVeriTabaniDataSetBindingSource;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

