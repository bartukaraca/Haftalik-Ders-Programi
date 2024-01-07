namespace Haftalık_Ders_Programı
{
    partial class gunsec
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
            this.lblgun = new System.Windows.Forms.Label();
            this.cbxgunsec = new System.Windows.Forms.ComboBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Location = new System.Drawing.Point(24, 26);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(70, 13);
            this.lblgun.TabIndex = 0;
            this.lblgun.Text = "Gün Seçiniz :";
            // 
            // cbxgunsec
            // 
            this.cbxgunsec.FormattingEnabled = true;
            this.cbxgunsec.Location = new System.Drawing.Point(100, 23);
            this.cbxgunsec.Name = "cbxgunsec";
            this.cbxgunsec.Size = new System.Drawing.Size(121, 21);
            this.cbxgunsec.TabIndex = 1;
            // 
            // btnsec
            // 
            this.btnsec.BackColor = System.Drawing.Color.Chartreuse;
            this.btnsec.Location = new System.Drawing.Point(100, 63);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(75, 23);
            this.btnsec.TabIndex = 2;
            this.btnsec.Text = "SEÇ";
            this.btnsec.UseVisualStyleBackColor = false;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // gunsec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 98);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.cbxgunsec);
            this.Controls.Add(this.lblgun);
            this.Name = "gunsec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gunsec";
            this.Load += new System.EventHandler(this.gunsec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.ComboBox cbxgunsec;
        private System.Windows.Forms.Button btnsec;
    }
}