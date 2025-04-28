using QRCoder;
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
using YeniOrnek1.Ogrenci;

namespace YeniOrnek1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        OkulEntities ef = new OkulEntities();
        string str;
        private void Login_Load(object sender, EventArgs e)
        {
            
            str = Guid.NewGuid().ToString().Substring(1, 5);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrKodBitmap = qrCode.GetGraphic(20);
            pictureBoxQR.Image = qrKodBitmap;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtSifre.Text == str)
            {
                Main frm = new Main();
                this.Hide();
                frm.Show();

            }

            else
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
