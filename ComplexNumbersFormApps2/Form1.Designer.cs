namespace ComplexNumbersFormApps2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textReal1 = new System.Windows.Forms.TextBox();
            this.textImag1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textImag2 = new System.Windows.Forms.TextBox();
            this.textReal2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toplama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textReal1
            // 
            this.textReal1.Location = new System.Drawing.Point(117, 75);
            this.textReal1.Name = "textReal1";
            this.textReal1.Size = new System.Drawing.Size(32, 27);
            this.textReal1.TabIndex = 1;
            // 
            // textImag1
            // 
            this.textImag1.Location = new System.Drawing.Point(176, 75);
            this.textImag1.Name = "textImag1";
            this.textImag1.Size = new System.Drawing.Size(32, 27);
            this.textImag1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "+";
            // 
            // textImag2
            // 
            this.textImag2.Location = new System.Drawing.Point(176, 108);
            this.textImag2.Name = "textImag2";
            this.textImag2.Size = new System.Drawing.Size(32, 27);
            this.textImag2.TabIndex = 8;
            // 
            // textReal2
            // 
            this.textReal2.Location = new System.Drawing.Point(117, 108);
            this.textReal2.Name = "textReal2";
            this.textReal2.Size = new System.Drawing.Size(32, 27);
            this.textReal2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Çıkarma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Birinci Sayı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "İkinci Sayi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 374);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textImag2);
            this.Controls.Add(this.textReal2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textImag1);
            this.Controls.Add(this.textReal1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textReal1;
        private System.Windows.Forms.TextBox textImag1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textImag2;
        private System.Windows.Forms.TextBox textReal2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

