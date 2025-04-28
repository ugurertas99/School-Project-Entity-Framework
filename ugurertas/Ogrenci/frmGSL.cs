using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeniOrnek1.Data;

namespace YeniOrnek1.Ogrenci
{
    public partial class frmGSL : Form
    {
        public frmGSL()
        {
            InitializeComponent();
        }
        OkulEntities ef = new OkulEntities();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ogrNo;
            ogrNo = txtOgrenciNo.Text.ToString();
            var guncellenecek = ef.Ogrenci.Where (x => x.ogrNo == ogrNo).FirstOrDefault();
            guncellenecek.ogrNo = txtOgrenciNo.Text;
            guncellenecek.Adres = txtAdres.Text;
            guncellenecek.adSoyad = txtAdSoyad.Text;
            guncellenecek.gsm = txtGsm.Text;
           

            ef.SaveChanges();
            dataGridView1.DataSource = ef.Ogrenci.ToList();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmGSL_Load(object sender, EventArgs e)
        {
           
            
            dataGridView1.DataSource = ef.Ogrenci.ToList();


        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            


        }
    }
}
