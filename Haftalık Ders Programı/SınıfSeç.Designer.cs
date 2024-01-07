namespace Haftalık_Ders_Programı
{
    partial class SınıfSeç
    {
        
        private System.ComponentModel.IContainer components = null;

       
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

     
        private void InitializeComponent()
        {
            this.btn1sınıf = new System.Windows.Forms.Button();
            this.btn2sınf = new System.Windows.Forms.Button();
            this.btn3sınıf = new System.Windows.Forms.Button();
            this.btn4sınıf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1sınıf
            // 
            this.btn1sınıf.BackColor = System.Drawing.Color.Green;
            this.btn1sınıf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn1sınıf.ForeColor = System.Drawing.Color.White;
            this.btn1sınıf.Location = new System.Drawing.Point(12, 81);
            this.btn1sınıf.Name = "btn1sınıf";
            this.btn1sınıf.Size = new System.Drawing.Size(98, 88);
            this.btn1sınıf.TabIndex = 0;
            this.btn1sınıf.Text = "1.SINIF";
            this.btn1sınıf.UseVisualStyleBackColor = false;
            this.btn1sınıf.Click += new System.EventHandler(this.btn1sınıf_Click);
            // 
            // btn2sınf
            // 
            this.btn2sınf.BackColor = System.Drawing.Color.Green;
            this.btn2sınf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn2sınf.ForeColor = System.Drawing.Color.White;
            this.btn2sınf.Location = new System.Drawing.Point(116, 81);
            this.btn2sınf.Name = "btn2sınf";
            this.btn2sınf.Size = new System.Drawing.Size(98, 88);
            this.btn2sınf.TabIndex = 1;
            this.btn2sınf.Text = "2.SINIF";
            this.btn2sınf.UseVisualStyleBackColor = false;
            this.btn2sınf.Click += new System.EventHandler(this.btn2sınf_Click);
            // 
            // btn3sınıf
            // 
            this.btn3sınıf.BackColor = System.Drawing.Color.Green;
            this.btn3sınıf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn3sınıf.ForeColor = System.Drawing.Color.White;
            this.btn3sınıf.Location = new System.Drawing.Point(220, 81);
            this.btn3sınıf.Name = "btn3sınıf";
            this.btn3sınıf.Size = new System.Drawing.Size(98, 88);
            this.btn3sınıf.TabIndex = 2;
            this.btn3sınıf.Text = "3.SINIF";
            this.btn3sınıf.UseVisualStyleBackColor = false;
            this.btn3sınıf.Click += new System.EventHandler(this.btn3sınıf_Click);
            // 
            // btn4sınıf
            // 
            this.btn4sınıf.BackColor = System.Drawing.Color.Green;
            this.btn4sınıf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn4sınıf.ForeColor = System.Drawing.Color.White;
            this.btn4sınıf.Location = new System.Drawing.Point(324, 81);
            this.btn4sınıf.Name = "btn4sınıf";
            this.btn4sınıf.Size = new System.Drawing.Size(98, 88);
            this.btn4sınıf.TabIndex = 3;
            this.btn4sınıf.Text = "4.SINIF";
            this.btn4sınıf.UseVisualStyleBackColor = false;
            this.btn4sınıf.Click += new System.EventHandler(this.btn4sınıf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lütfen Sınıf Seçimi Yapınız ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SınıfSeç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn4sınıf);
            this.Controls.Add(this.btn3sınıf);
            this.Controls.Add(this.btn2sınf);
            this.Controls.Add(this.btn1sınıf);
            this.Name = "SınıfSeç";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SınıfSeç";
            this.Load += new System.EventHandler(this.SınıfSeç_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1sınıf;
        private System.Windows.Forms.Button btn2sınf;
        private System.Windows.Forms.Button btn3sınıf;
        private System.Windows.Forms.Button btn4sınıf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}