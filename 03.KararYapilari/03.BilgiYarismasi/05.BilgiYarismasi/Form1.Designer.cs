namespace _05.BilgiYarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            sikA = new Button();
            SikB = new Button();
            sikC = new Button();
            sikD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoruNo = new Label();
            LblDogru = new Label();
            LblYanlis = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(489, 171);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // sikA
            // 
            sikA.Location = new Point(0, 177);
            sikA.Name = "sikA";
            sikA.Size = new Size(244, 36);
            sikA.TabIndex = 1;
            sikA.Text = "A";
            sikA.UseVisualStyleBackColor = true;
            sikA.Visible = false;
            sikA.Click += sikA_Click;
            // 
            // SikB
            // 
            SikB.Location = new Point(245, 177);
            SikB.Name = "SikB";
            SikB.Size = new Size(244, 36);
            SikB.TabIndex = 1;
            SikB.Text = "B";
            SikB.UseVisualStyleBackColor = true;
            SikB.Visible = false;
            SikB.Click += SikB_Click;
            // 
            // sikC
            // 
            sikC.Location = new Point(0, 219);
            sikC.Name = "sikC";
            sikC.Size = new Size(244, 36);
            sikC.TabIndex = 1;
            sikC.Text = "C";
            sikC.UseVisualStyleBackColor = true;
            sikC.Visible = false;
            sikC.Click += sikC_Click;
            // 
            // sikD
            // 
            sikD.Location = new Point(245, 219);
            sikD.Name = "sikD";
            sikD.Size = new Size(244, 36);
            sikD.TabIndex = 1;
            sikD.Text = "D";
            sikD.UseVisualStyleBackColor = true;
            sikD.Visible = false;
            sikD.Click += sikD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 22);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 2;
            label1.Text = "Soru No:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 50);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 2;
            label2.Text = "Doğru:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 78);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 2;
            label3.Text = "Yanlış:";
            label3.Visible = false;
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Location = new Point(643, 22);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(24, 28);
            lblSoruNo.TabIndex = 2;
            lblSoruNo.Text = "0";
            lblSoruNo.Visible = false;
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(643, 50);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(24, 28);
            LblDogru.TabIndex = 2;
            LblDogru.Text = "0";
            LblDogru.Visible = false;
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(643, 78);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(24, 28);
            LblYanlis.TabIndex = 2;
            LblYanlis.Text = "0";
            LblYanlis.Visible = false;
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(547, 124);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(174, 36);
            btnSonraki.TabIndex = 1;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Visible = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(642, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(699, 22);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(700, 50);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 5;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(182, 78);
            button1.Name = "button1";
            button1.Size = new Size(398, 82);
            button1.TabIndex = 6;
            button1.Text = "Oyunu Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 279);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(lblSoruNo);
            Controls.Add(label1);
            Controls.Add(SikB);
            Controls.Add(btnSonraki);
            Controls.Add(sikD);
            Controls.Add(sikC);
            Controls.Add(sikA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button sikA;
        private Button SikB;
        private Button sikC;
        private Button sikD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruNo;
        private Label LblDogru;
        private Label LblYanlis;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}