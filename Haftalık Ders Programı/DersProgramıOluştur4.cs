using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haftalık_Ders_Programı
{
    public partial class DersProgramıOluştur4 : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=haftalık_ders_programı;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DersProgramıOluştur4()
        {
            InitializeComponent();
        }

        int saatAramapzt()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM pzt WHERE Saat='" + cbxsaat.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }

        int saatAramasalı()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM salı WHERE Saat='" + cbxsaat.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int saatAramacar()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM carsamba WHERE Saat='" + cbxsaat.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int saatAramaper()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM persembe WHERE Saat='" + cbxsaat.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int saatAramacuma()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM cuma WHERE Saat='" + cbxsaat.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int derslikAramapzt()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM pzt WHERE Derslik='" + cbxderslik.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int derslikAramasalı()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM salı WHERE Derslik='" + cbxderslik.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int derslikAramacarsamba()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM carsamba WHERE Derslik='" + cbxderslik.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int derslikAramapersembe()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM persembe WHERE Derslik='" + cbxderslik.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int derslikAramacuma()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM cuma WHERE Derslik='" + cbxderslik.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int gunAramapzt()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM pzt WHERE Gün='" + cbxgun.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int gunAramasalı()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM salı WHERE Gün='" + cbxgun.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int gunAramacar()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM car WHERE Gün='" + cbxgun.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int gunAramaper()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM persembe WHERE Gün='" + cbxgun.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int gunAramacuma()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT *  FROM cuma WHERE Gün='" + cbxgun.Text + "'", conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int dersaramapzt()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM pzt WHERE Ders=@ders_adı AND ders_türü=@derstürü", conn);
            cmd2.Parameters.AddWithValue("@ders_adı", cbxders.Text);
            cmd2.Parameters.AddWithValue("@derstürü", cbxdersturu.Text);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int dersaramasalı()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM salı WHERE Ders=@ders_adı AND ders_türü=@derstürü", conn);
            cmd2.Parameters.AddWithValue("@ders_adı", cbxders.Text);
            cmd2.Parameters.AddWithValue("@derstürü", cbxdersturu.Text);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int dersaramacarsamba()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM carsamba WHERE Ders=@ders_adı AND ders_türü=@derstürü", conn);
            cmd2.Parameters.AddWithValue("@ders_adı", cbxders.Text);
            cmd2.Parameters.AddWithValue("@derstürü", cbxdersturu.Text);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int dersaramapersembe()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM persembe WHERE Ders=@ders_adı AND ders_türü=@derstürü", conn);
            cmd2.Parameters.AddWithValue("@ders_adı", cbxders.Text);
            cmd2.Parameters.AddWithValue("@derstürü", cbxdersturu.Text);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int dersaramacuma()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM cuma WHERE Ders=@ders_adı AND ders_türü=@derstürü", conn);
            cmd2.Parameters.AddWithValue("@ders_adı", cbxders.Text);
            cmd2.Parameters.AddWithValue("@derstürü", cbxdersturu.Text);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        int ElemanArama()
        {
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM ogretimuyeleri WHERE Ad=@adı AND Soyad=@soyad", conn);
            string[] adsoyadayır = cbxeleman.Text.Split(' ');
            int uzunluk = adsoyadayır.Length;
            if (uzunluk == 2)
            {
                cmd2.Parameters.AddWithValue("@adı", adsoyadayır[0]);
                cmd2.Parameters.AddWithValue("@soyad", adsoyadayır[1]);
            }
            else if (uzunluk == 3)
            {
                cmd2.Parameters.AddWithValue("@adı", adsoyadayır[0] + " " + adsoyadayır[1]);
                cmd2.Parameters.AddWithValue("@soyad", adsoyadayır[2]);
            }
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        void derscek()
        {

            MySqlCommand komut = new MySqlCommand("SELECT * FROM dersler WHERE yarıyıl = @Yarıyıl", conn);
            komut.Parameters.AddWithValue("@Yarıyıl", cbxsınıf.Text);
            MySqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            cbxders.Items.Clear(); // Daha önceki dersleri temizle

            while (dr.Read())
            {
                cbxders.Items.Add(dr["ders_adı"]);
            }
            conn.Close();
        }
        void dersTurCek()
        {
            MySqlCommand komut = new MySqlCommand("SELECT ders_adı FROM dersler WHERE ders_türü = @derstürü", conn);
            komut.Parameters.AddWithValue("@derstürü", cbxdersturu.Text);
            MySqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            cbxders.Items.Clear(); // Daha önceki dersleri temizle

            while (dr.Read())
            {
                cbxders.Items.Add(dr["ders_adı"]);
            }
            conn.Close();
        }
        string[] saatler ={ "17:30-18:20", "18:25-19:15",
                "19:20-20:10","20:15-21:05","21:10-22:00","22:05-22:55","23:00-23:50",
                "23:55-24:45","24:50-01:40"};
        string[] birinciogretim = { "08:30-09:15", "09:30-10:15",
                "10:30-11:15","11:30-12:15","12:30-13:15","13:30-14:15","14:30-15:15",
                "15:30-16:15","16:30-17:15"};

        void derslikTuruCek()
        {

            MySqlCommand komut = new MySqlCommand("SELECT derslik_kodu FROM derslikler WHERE derslik_türü = @derstürü", conn);
            komut.Parameters.AddWithValue("@derstürü", cbxdersturu.Text.ToUpper());
            MySqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            cbxderslik.Items.Clear(); // Daha önceki dersleri temizle

            while (dr.Read())
            {
                cbxderslik.Items.Add(dr["derslik_kodu"]);
            }
            conn.Close();
        }
        void elemanscek()
        {
            MySqlCommand komut = new MySqlCommand("SELECT * FROM ogretimuyeleri", conn);
            MySqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxeleman.Items.Add(dr["Ad"] + " " + dr["Soyad"]);
            }
            conn.Close();
        }
        public void comboboxvericek()
        {
            cbxgun.Items.Add("PAZARTESİ");
            cbxgun.Items.Add("SALI");
            cbxgun.Items.Add("ÇARŞAMBA");
            cbxgun.Items.Add("PERŞEMBE");
            cbxgun.Items.Add("CUMA");
            cbxsınıf.Items.Add("7. Yarıyıl");
            cbxsınıf.Items.Add("8. Yarıyıl");
            cbxogrenimturu.Items.Add("1.Öğretim");
            cbxogrenimturu.Items.Add("2.Öğretim");
            cbxdersturu.Items.Add("uygulamalı");
            cbxdersturu.Items.Add("teorik");

        }
        void VeriYenilepzt()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM pzt ORDER BY Saat ASC", conn);
            adapter.Fill(dt);
            conn.Close();
        }
        void VeriYenilesalı()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM salı ORDER BY Saat ASC", conn);
            adapter.Fill(dt);
            conn.Close();
        }
        void VeriYenilecarsamba()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM carsamba ORDER BY Saat ASC", conn);
            adapter.Fill(dt);
            conn.Close();
        }
        void VeriYenilepersembe()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM persembe ORDER BY Saat ASC", conn);
            adapter.Fill(dt);
            conn.Close();
        }
        void VeriYenilecuma()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM cuma ORDER BY Saat ASC", conn);
            adapter.Fill(dt);
            conn.Close();
        }
        void tablodoldurPazartesi()
        {
            VeriYenilepzt();

            // Verileri DataGridView'e yerleştir
            foreach (DataRow row in dt.Rows)
            {
                string gun = row["Gün"].ToString();

                string veri = row["Saat"].ToString() + " \n " +
                              row["OgretimElemani"].ToString() + " \n " +
                              row["Ders"].ToString() + " \n " +
                              row["Derslik"].ToString();


                int rowIndex = DGVPAZARTESI.Rows.Add();
                if (gun == "PAZARTESİ")
                {
                    DGVPAZARTESI.Rows[rowIndex].Cells["Pazartesi"].Value = veri;
                }
            }
        }
        void tablodoldurSalı()
        {
            VeriYenilesalı();

            // Verileri DataGridView'e yerleştir
            foreach (DataRow row in dt.Rows)
            {
                string gun = row["Gün"].ToString();

                string veri = row["Saat"].ToString() + " \n " +
                              row["OgretimElemani"].ToString() + " \n " +
                              row["Ders"].ToString() + " \n " +
                              row["Derslik"].ToString();


                int rowIndex = DGVSALI.Rows.Add();
                if (gun == "SALI")
                {
                    DGVSALI.Rows[rowIndex].Cells["Salı"].Value = veri;
                }
            }
        }
        void tablodoldurCarsamba()
        {
            VeriYenilecarsamba();

            // Verileri DataGridView'e yerleştir
            foreach (DataRow row in dt.Rows)
            {
                string gun = row["Gün"].ToString();

                string veri = row["Saat"].ToString() + " \n " +
                              row["OgretimElemani"].ToString() + " \n " +
                              row["Ders"].ToString() + " \n " +
                              row["Derslik"].ToString();


                int rowIndex = DGVCARSAMBA.Rows.Add();
                if (gun == "ÇARŞAMBA")
                {
                    DGVCARSAMBA.Rows[rowIndex].Cells["Çarşamba"].Value = veri;
                }
            }
        }

        void tablodoldurPersembe()
        {
            VeriYenilepersembe();

            // Verileri DataGridView'e yerleştir
            foreach (DataRow row in dt.Rows)
            {
                string gun = row["Gün"].ToString();

                string veri = row["Saat"].ToString() + " \n " +
                              row["OgretimElemani"].ToString() + " \n " +
                              row["Ders"].ToString() + " \n " +
                              row["Derslik"].ToString();


                int rowIndex = DGVPERSEMBE.Rows.Add();
                if (gun == "PERŞEMBE")
                {
                    DGVPERSEMBE.Rows[rowIndex].Cells["Perşembe"].Value = veri;
                }
            }
        }
        void tablodoldurCuma()
        {
            VeriYenilecuma();

            // Verileri DataGridView'e yerleştir
            foreach (DataRow row in dt.Rows)
            {
                string gun = row["Gün"].ToString();

                string veri = row["Saat"].ToString() + " \n " +
                              row["OgretimElemani"].ToString() + " \n " +
                              row["Ders"].ToString() + " \n " +
                              row["Derslik"].ToString();


                int rowIndex = DGVCUMA.Rows.Add();
                if (gun == "CUMA")
                {
                    DGVCUMA.Rows[rowIndex].Cells["Cuma"].Value = veri;
                }
            }
        }
        int dersSaatiCek()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ders_saati FROM dersler WHERE ders_türü=@ders_türü AND ders_adı=@ders_adı", conn);
            cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
            cmd.Parameters.AddWithValue("@ders_adı", cbxders.Text);
            int dersSaati = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dersSaati;
        }



        private void Dgwsonuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   


 


        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void DersProgramıOluştur4_Load(object sender, EventArgs e)
        {
            comboboxvericek();
            elemanscek();
            tablodoldurPazartesi();
            tablodoldurSalı();
            tablodoldurCarsamba();
            tablodoldurPersembe();
            tablodoldurCuma();
        }

        private void cbxsınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            derscek();
        }

        private void cbxogrenimturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxogrenimturu.Text == "2.Öğretim")
            {
                cbxsaat.Items.Clear();
                cbxsaat.Items.AddRange(saatler);
            }
            else if (cbxogrenimturu.Text == "1.Öğretim")
            {
                cbxsaat.Items.Clear();
                cbxsaat.Items.AddRange(birinciogretim);
            }
        }

        private void cbxdersturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            derslikTuruCek();
            dersTurCek();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
                  int dersSaati, saatIndex;
                if (cbxgun.Text == "PAZARTESİ")
                {
                    string sql = "INSERT INTO pzt(Ders,Derslik,OgretimElemani,Gün,Saat,Sınıf,OgretimTuru,ders_türü)" +
                    "VALUES(@ders,@derslik,@ogretimelemani,@gun,@saat,@sınıf,@ogretimturu,@ders_türü)";
                    if (cbxogrenimturu.Text == "2.Öğretim")
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(saatler, cbxsaat.Text);

                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramapzt() == 1)
                            {
                                if (derslikAramapzt() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramapzt() == 0) && (dersaramapzt() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramapzt() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = saatler[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = saatler[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");



                    }
                    else
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(birinciogretim, cbxsaat.Text);
                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramapzt() == 1)
                            {
                                if (derslikAramapzt() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramapzt() == 0) && (dersaramapzt() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramapzt() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = birinciogretim[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = birinciogretim[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");
                    }
                }
                else if (cbxgun.Text == "SALI")
                {
                    string sql = "INSERT INTO salı(Ders,Derslik,OgretimElemani,Gün,Saat,Sınıf,OgretimTuru,ders_türü)" +
                   "VALUES(@ders,@derslik,@ogretimelemani,@gun,@saat,@sınıf,@ogretimturu,@ders_türü)";
                    if (cbxogrenimturu.Text == "2.Öğretim")
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(saatler, cbxsaat.Text);

                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramasalı() == 1)
                            {
                                if (derslikAramasalı() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramasalı() == 0) && (dersaramasalı() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramasalı() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = saatler[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = saatler[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");



                    }
                    else
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(birinciogretim, cbxsaat.Text);
                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramasalı() == 1)
                            {
                                if (derslikAramasalı() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramasalı() == 0) && (dersaramasalı() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramasalı() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = birinciogretim[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = birinciogretim[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");
                    }
                }
                else if (cbxgun.Text == "ÇARŞAMBA")
                {
                    string sql = "INSERT INTO carsamba(Ders,Derslik,OgretimElemani,Gün,Saat,Sınıf,OgretimTuru,ders_türü)" +
                    "VALUES(@ders,@derslik,@ogretimelemani,@gun,@saat,@sınıf,@ogretimturu,@ders_türü)";
                    if (cbxogrenimturu.Text == "2.Öğretim")
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(saatler, cbxsaat.Text);

                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramacar() == 1)
                            {
                                if (derslikAramacarsamba() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramacarsamba() == 0) && (dersaramacarsamba() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramacarsamba() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = saatler[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = saatler[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");



                    }
                    else
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(birinciogretim, cbxsaat.Text);
                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramacar() == 1)
                            {
                                if (derslikAramacarsamba() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramacarsamba() == 0) && (dersaramacarsamba() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramacarsamba() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = birinciogretim[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = birinciogretim[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");
                    }
                }
                else if (cbxgun.Text == "PERŞEMBE")
                {
                    string sql = "INSERT INTO persembe(Ders,Derslik,OgretimElemani,Gün,Saat,Sınıf,OgretimTuru,ders_türü)" +
                    "VALUES(@ders,@derslik,@ogretimelemani,@gun,@saat,@sınıf,@ogretimturu,@ders_türü)";
                    if (cbxogrenimturu.Text == "2.Öğretim")
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(saatler, cbxsaat.Text);

                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramaper() == 1)
                            {
                                if (derslikAramapersembe() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramapersembe() == 0) && (dersaramapersembe() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramapersembe() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = saatler[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = saatler[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");



                    }
                    else
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(birinciogretim, cbxsaat.Text);
                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramaper() == 1)
                            {
                                if (derslikAramapersembe() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramapersembe() == 0) && (dersaramapersembe() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramapersembe() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = birinciogretim[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = birinciogretim[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");
                    }
                }
                else if (cbxgun.Text == "CUMA")
                {
                    string sql = "INSERT INTO cuma(Ders,Derslik,OgretimElemani,Gün,Saat,Sınıf,OgretimTuru,ders_türü)" +
                    "VALUES(@ders,@derslik,@ogretimelemani,@gun,@saat,@sınıf,@ogretimturu,@ders_türü)";
                    if (cbxogrenimturu.Text == "2.Öğretim")
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(saatler, cbxsaat.Text);

                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramacuma() == 1)
                            {
                                if (derslikAramacuma() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramacuma() == 0) && (dersaramacuma() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramacuma() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = saatler[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = saatler[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");



                    }
                    else
                    {
                        dersSaati = dersSaatiCek();
                        saatIndex = Array.IndexOf(birinciogretim, cbxsaat.Text);
                        if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
                        {
                            if (saatAramacuma() == 1)
                            {
                                if (derslikAramacuma() == 1)
                                {
                                    MessageBox.Show("Belirtilen Saatte Seçilen Derslik Doludur!");
                                }
                                else if ((derslikAramacuma() == 0) && (dersaramacuma() == 1))
                                {
                                    MessageBox.Show("Seçilen Ders Aynı Saatte Farklı Dersliklerde İşlenemez");
                                }
                                else if ((ElemanArama() == 1) && (derslikAramacuma() == 0))
                                {
                                    MessageBox.Show("Seçilen Öğretim Elemanı Aynı Saatte Birden Fazla Ders Veremez");
                                }
                                else
                                {
                                    for (int i = 0; i < dersSaati; i++)
                                    {
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                        cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                        cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                        cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                        cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                        cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                        cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                        cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                        if (saatIndex <= 7)
                                        {
                                            saatIndex++;
                                            cbxsaat.Text = birinciogretim[saatIndex];
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                            break;
                                        }
                                    }
                                    MessageBox.Show("Ders programı kaydedildi");
                                }
                            }

                            else
                            {
                                for (int i = 0; i < dersSaati; i++)
                                {
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@ders", cbxders.Text);
                                    cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
                                    cmd.Parameters.AddWithValue("@ogretimelemani", cbxeleman.Text);
                                    cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
                                    cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
                                    cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
                                    cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);
                                    cmd.Parameters.AddWithValue("@ders_türü", cbxdersturu.Text);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (saatIndex <= 7)
                                    {
                                        saatIndex++;
                                        cbxsaat.Text = birinciogretim[saatIndex];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gün İçindeki Saat Miktarını Aştınız Ve Günün Son Saatine Uygun Şekilde Ayarlandı");
                                        break;
                                    }
                                }
                                MessageBox.Show("Ders programı kaydedildi");
                            }

                        }
                        else
                            MessageBox.Show("Boş alan mevcut!!");
                    }
                }
            }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DGVPAZARTESI.Rows.Clear();
            DGVSALI.Rows.Clear();
            DGVCARSAMBA.Rows.Clear();
            DGVPERSEMBE.Rows.Clear();
            DGVCUMA.Rows.Clear();
            tablodoldurPazartesi();
            tablodoldurSalı();
            tablodoldurCarsamba();
            tablodoldurPersembe();
            tablodoldurCuma();
        }

        private void btn_Derslikler_geri_Click(object sender, EventArgs e)
        {
            SınıfSeç sınıfSeç = new SınıfSeç();
            sınıfSeç.Show();
            this.Close();
        }
        void yazdır()
        {
            // Datagridview verilerini içeren bir DataTable oluşturulur
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            foreach (DataGridViewColumn column in DGVPAZARTESI.Columns)
            {
                Type type = column.ValueType;
                if (type == null)
                {
                    type = typeof(string);
                    dt.Columns.Add(column.HeaderText, type);
                }
                else
                    dt.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in DGVPAZARTESI.Rows)
            {
                DataRow dataRow = dt.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }

                dt.Rows.Add(dataRow);
            }
            //SALI
            foreach (DataGridViewColumn column in DGVSALI.Columns)
            {
                Type type = column.ValueType;
                if (type == null)
                {
                    type = typeof(string);
                    dt2.Columns.Add(column.HeaderText, type);
                }
                else
                    dt2.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in DGVSALI.Rows)
            {
                DataRow dataRow = dt2.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }

                dt2.Rows.Add(dataRow);
            }
            //ÇARŞAMBA
            foreach (DataGridViewColumn column in DGVCARSAMBA.Columns)
            {
                Type type = column.ValueType;
                if (type == null)
                {
                    type = typeof(string);
                    dt3.Columns.Add(column.HeaderText, type);
                }
                else
                    dt3.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in DGVCARSAMBA.Rows)
            {
                DataRow dataRow = dt3.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }

                dt3.Rows.Add(dataRow);
            }

            //PERŞEMBE
            foreach (DataGridViewColumn column in DGVPERSEMBE.Columns)
            {
                Type type = column.ValueType;
                if (type == null)
                {
                    type = typeof(string);
                    dt4.Columns.Add(column.HeaderText, type);
                }
                else
                    dt4.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in DGVPERSEMBE.Rows)
            {
                DataRow dataRow = dt4.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }

                dt4.Rows.Add(dataRow);
            }


            //CUMA
            foreach (DataGridViewColumn column in DGVCUMA.Columns)
            {
                Type type = column.ValueType;
                if (type == null)
                {
                    type = typeof(string);
                    dt5.Columns.Add(column.HeaderText, type);
                }
                else
                    dt5.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in DGVCUMA.Rows)
            {
                DataRow dataRow = dt5.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }

                dt5.Rows.Add(dataRow);
            }


            // DataTable verilerini içeren bir PDF dosyası oluşturulur
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
            saveDialog.Title = "PDF Dosyası Kaydet";
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                Document doc = new iTextSharp.text.Document();
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                doc.Open();

                PdfPTable table = new PdfPTable(dt.Columns.Count);
                PdfPTable table2 = new PdfPTable(dt2.Columns.Count);
                PdfPTable table3 = new PdfPTable(dt2.Columns.Count);
                PdfPTable table4 = new PdfPTable(dt2.Columns.Count);
                PdfPTable table5 = new PdfPTable(dt2.Columns.Count);

                // Tablo sütun başlıkları ayarlanır
                foreach (DataColumn column in dt.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table.AddCell(cell);
                }
                // Tablo verileri ayarlanır
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(row[column].ToString()));
                        table.AddCell(cell);
                    }
                }
                doc.Add(table);

                //SALI
                foreach (DataColumn column in dt2.Columns)
                {
                    PdfPCell cell2 = new PdfPCell(new Phrase(column.ColumnName));
                    cell2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table2.AddCell(cell2);
                }
                foreach (DataRow row in dt2.Rows)
                {
                    foreach (DataColumn column in dt2.Columns)
                    {
                        PdfPCell cell2 = new PdfPCell(new Phrase(row[column].ToString()));
                        table2.AddCell(cell2);
                    }
                }
                doc.Add(table2);


                //ÇARŞAMBA
                foreach (DataColumn column in dt3.Columns)
                {
                    PdfPCell cell3 = new PdfPCell(new Phrase(column.ColumnName));
                    cell3.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table3.AddCell(cell3);
                }

                // Tablo verileri ayarlanır
                foreach (DataRow row in dt3.Rows)
                {
                    foreach (DataColumn column in dt3.Columns)
                    {
                        PdfPCell cell3 = new PdfPCell(new Phrase(row[column].ToString()));
                        table3.AddCell(cell3);
                    }
                }
                doc.Add(table3);



                //PERŞEMBE
                foreach (DataColumn column in dt4.Columns)
                {
                    PdfPCell cell4 = new PdfPCell(new Phrase(column.ColumnName));
                    cell4.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table4.AddCell(cell4);
                }

                // Tablo verileri ayarlanır
                foreach (DataRow row in dt4.Rows)
                {
                    foreach (DataColumn column in dt4.Columns)
                    {
                        PdfPCell cell4 = new PdfPCell(new Phrase(row[column].ToString()));
                        table4.AddCell(cell4);
                    }
                }
                doc.Add(table4);


                //CUMA
                foreach (DataColumn column in dt5.Columns)
                {
                    PdfPCell cell5 = new PdfPCell(new Phrase(column.ColumnName));
                    cell5.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table5.AddCell(cell5);
                }

                // Tablo verileri ayarlanır
                foreach (DataRow row in dt5.Rows)
                {
                    foreach (DataColumn column in dt5.Columns)
                    {
                        PdfPCell cell5 = new PdfPCell(new Phrase(row[column].ToString()));
                        table5.AddCell(cell5);
                    }
                }
                doc.Add(table5);

                doc.Close();
                MessageBox.Show("PDF dosyası kaydedildi.");
            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            yazdır();
        }
        public string Gun { get; set; }
        private void btnsil_Click(object sender, EventArgs e)
        {
            gunsec Gunsec = new gunsec();
            if (Gunsec.ShowDialog() == DialogResult.OK)
            {
                Gun = Gunsec.SelectedGun;

                if (Gun == "PAZARTESİ")
                {
                    if (DGVPAZARTESI.SelectedCells.Count > 0 && DGVPAZARTESI.SelectedCells[0].Value != null)
                    {

                        string selectedCellValue = DGVPAZARTESI.SelectedCells[0].Value.ToString();
                        string[] ayirilanDegerler = selectedCellValue.Split(' ');

                        MySqlCommand cmd = new MySqlCommand("DELETE  FROM pzt WHERE Saat=@saat AND Gün=@gün", conn);
                        cmd.Parameters.Add("@saat", MySqlDbType.VarChar).Value = ayirilanDegerler[0];
                        cmd.Parameters.Add("@gün", MySqlDbType.VarChar).Value = "PAZARTESİ";

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kayıt silindi");

                    }
                    else
                    {
                        MessageBox.Show("Pazartesi Sutununda Seçilen Hücre boş");

                    }
                }


                else if (Gun == "SALI")
                {
                    if (DGVSALI.SelectedCells.Count > 0 && DGVSALI.SelectedCells[0].Value != null)
                    {

                        string selectedCellValue2 = DGVSALI.SelectedCells[0].Value.ToString();
                        string[] ayirilanDegerler2 = selectedCellValue2.Split(' ');
                        MySqlCommand cmd2 = new MySqlCommand("DELETE  FROM salı WHERE Saat=@saat AND Gün=@gün", conn);
                        cmd2.Parameters.Add("@saat", MySqlDbType.VarChar).Value = ayirilanDegerler2[0];
                        cmd2.Parameters.Add("@gün", MySqlDbType.VarChar).Value = "SALI";

                        conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kayıt silindi");
                    }
                    else
                    {
                        MessageBox.Show("Salı Sutununda Seçilen Hücre boş");

                    }
                }
                else if (Gun == "ÇARŞAMBA")
                {

                    if (DGVCARSAMBA.SelectedCells.Count > 0 && DGVCARSAMBA.SelectedCells[0].Value != null)
                    {

                        string selectedCellValue3 = DGVCARSAMBA.SelectedCells[0].Value.ToString();
                        string[] ayirilanDegerler3 = selectedCellValue3.Split(' ');

                        MySqlCommand cmd3 = new MySqlCommand("DELETE  FROM carsamba WHERE Saat=@saat AND Gün=@gün", conn);
                        cmd3.Parameters.Add("@saat", MySqlDbType.VarChar).Value = ayirilanDegerler3[0];
                        cmd3.Parameters.Add("@gün", MySqlDbType.VarChar).Value = "ÇARŞAMBA";

                        conn.Open();
                        cmd3.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kayıt silindi");
                    }
                    else
                    {
                        MessageBox.Show("Çarşamba Sutununda Seçilen Hücre boş");

                    }
                }

                else if (Gun == "PERŞEMBE")
                {
                    if (DGVPERSEMBE.SelectedCells.Count > 0 && DGVPERSEMBE.SelectedCells[0].Value != null)
                    {
                        string selectedCellValue4 = DGVPERSEMBE.SelectedCells[0].Value.ToString();
                        string[] ayirilanDegerler4 = selectedCellValue4.Split(' ');

                        MySqlCommand cmd4 = new MySqlCommand("DELETE FROM persembe WHERE Saat = @saat AND Gün = @gün", conn);
                        cmd4.Parameters.AddWithValue("@saat", ayirilanDegerler4[0]);
                        cmd4.Parameters.AddWithValue("@gün", "PERŞEMBE");

                        conn.Open();
                        cmd4.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kayıt silindi");
                    }
                    else
                    {
                        MessageBox.Show("Perşembe Sutununda Seçilen Hücre boş");
                    }

                }

                else if (Gun == "CUMA")
                {
                    if (DGVCUMA.SelectedCells.Count > 0 && DGVCUMA.SelectedCells[0].Value != null)
                    {

                        string selectedCellValue5 = DGVCUMA.SelectedCells[0].Value.ToString();
                        string[] ayirilanDegerler5 = selectedCellValue5.Split(' ');

                        MySqlCommand cmd5 = new MySqlCommand("DELETE  FROM cuma WHERE Saat=@saat AND Gün=@gün", conn);
                        cmd5.Parameters.Add("@saat", MySqlDbType.VarChar).Value = ayirilanDegerler5[0];
                        cmd5.Parameters.Add("@gün", MySqlDbType.VarChar).Value = "CUMA";

                        conn.Open();
                        cmd5.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kayıt silindi");

                    }
                    else
                    {

                        MessageBox.Show("cuma Sutununda Seçilen Hücre boş");

                    }
                }
            }


        }
    }
 }
