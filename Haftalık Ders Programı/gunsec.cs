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
    public partial class gunsec : Form
    {
        public gunsec()
        {
            InitializeComponent();
        }
        DersprogramıOluştur dersprog =new DersprogramıOluştur();
        public string SelectedGun { get; private set; }

        public void gunsec_Load(object sender, EventArgs e)
        {
            cbxgunsec.Items.Add("PAZARTESİ");
            cbxgunsec.Items.Add("SALI");
            cbxgunsec.Items.Add("ÇARŞAMBA");
            cbxgunsec.Items.Add("PERŞEMBE");
            cbxgunsec.Items.Add("CUMA");
           
        }
         void btnsec_Click(object sender, EventArgs e)
        {
            SelectedGun = cbxgunsec.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
