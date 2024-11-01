namespace _02.Karar_Yapilari_egzersiz
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(375, 232);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 94);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 1;
            label1.Text = "Sınav1:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 130);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 1;
            label2.Text = "Sınav2:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(377, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 166);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 1;
            label3.Text = "Proje:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 202);
            label4.Name = "label4";
            label4.Size = new Size(71, 24);
            label4.TabIndex = 1;
            label4.Text = "Sonuç:";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(377, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 540);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}