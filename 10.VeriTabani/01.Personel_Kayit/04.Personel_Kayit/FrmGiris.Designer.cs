namespace _04.Personel_Kayit
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(169, 79);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(200, 36);
            this.txtad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(169, 121);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(200, 36);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // btngir
            // 
            this.btngir.Location = new System.Drawing.Point(190, 163);
            this.btngir.Name = "btngir";
            this.btngir.Size = new System.Drawing.Size(154, 38);
            this.btngir.TabIndex = 3;
            this.btngir.Text = "Giriş Yap";
            this.btngir.UseVisualStyleBackColor = true;
            this.btngir.Click += new System.EventHandler(this.btngir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Takip Sistemi Giriş";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(498, 238);
            this.Controls.Add(this.btngir);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngir;
        private System.Windows.Forms.Label label3;
    }
}