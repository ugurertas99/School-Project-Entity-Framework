using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeniOrnek1.Ogrenci
{
    public partial class frmYeni : Form
    {
        public frmYeni()
        {
            InitializeComponent();
        }
        Data.OkulEntities ef = new Data.OkulEntities();

        private void txtOgrenciNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtOgrenciNo.BackColor = Color.GreenYellow;
            txtAdSoyad.BackColor = Color.White;
            txtGsm.BackColor = Color.White;
            txtAdres.BackColor = Color.White;

        }

        private void txtAdSoyad_MouseClick(object sender, MouseEventArgs e)
        {
            txtOgrenciNo.BackColor = Color.White;
            txtAdSoyad.BackColor = Color.GreenYellow;
            txtGsm.BackColor = Color.White;
            txtAdres.BackColor = Color.White;

        }

        private void txtGsm_MouseClick(object sender, MouseEventArgs e)
        {
            txtOgrenciNo.BackColor = Color.White;
            txtAdSoyad.BackColor = Color.White;
            txtGsm.BackColor = Color.GreenYellow;
            txtAdres.BackColor = Color.White;

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_MouseClick(object sender, MouseEventArgs e)
        {
            txtOgrenciNo.BackColor = Color.White;
            txtAdSoyad.BackColor = Color.White;
            txtGsm.BackColor = Color.White;
            txtAdres.BackColor = Color.GreenYellow;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Data.Ogrenci yeniOgrenci = new Data.Ogrenci();

            yeniOgrenci.adSoyad = txtAdSoyad.Text;
            yeniOgrenci.Adres = txtAdres.Text;
            yeniOgrenci.ogrNo = txtOgrenciNo.Text;

            ef.Ogrenci.Add(yeniOgrenci);

            if (ef.SaveChanges() > 0)
            {
                lblDurum.Text = @"Kaydedildi";
                temizle();
            }

            



        }
        void temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox textBox)
                {
                    textBox.Clear();

                }


            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }

}



