using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haftalık_Ders_Programı
{
    public partial class SınıfSeç : Form
    {
        public SınıfSeç()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1sınıf_Click(object sender, EventArgs e)
        {
            DersprogramıOluştur dersprogramıOluştur=new DersprogramıOluştur();
            dersprogramıOluştur.Show();
            this.Close();
        }

        private void btn2sınf_Click(object sender, EventArgs e)
        {
            DersprogramıOluştur2 dersprogramıOluştur2 = new DersprogramıOluştur2();
            dersprogramıOluştur2.Show();
            this.Close();
        }

        private void btn3sınıf_Click(object sender, EventArgs e)
        {
            DersprogramıOluştur3 dersprogramıOluştur3 = new DersprogramıOluştur3();
            dersprogramıOluştur3.Show();
            this.Close();
        }

        private void btn4sınıf_Click(object sender, EventArgs e)
        {
            DersProgramıOluştur4 dersprogramıOluştur4 = new DersProgramıOluştur4();
            dersprogramıOluştur4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Close();
        }

        private void SınıfSeç_Load(object sender, EventArgs e)
        {

        }
    }
}
