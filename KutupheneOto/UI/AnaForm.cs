using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutupheneOto.UI
{
    public partial class AnaForm : Form
    {
        private string kullaniciYetki;

        public AnaForm(string yetki)
        {
            InitializeComponent();
            this.kullaniciYetki = yetki;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            if (kullaniciYetki == "Y")
            {
                this.Text = "Kütüphane Otomasyonu - Personel Paneli";
                rAPORLARToolStripMenuItem.Visible = false;
            }
            else
            {
                this.Text = "Kütüphane Otomasyonu - Yönetici Paneli";
                rAPORLARToolStripMenuItem.Visible = true; 
            }
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapForm frm = new KitapForm(kullaniciYetki);
            frm.Show();
        }

        private void üYEİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeForm frm = new UyeForm(kullaniciYetki);
            frm.Show();
        }

        private void ödünçALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OduncForm frm = new OduncForm();
            frm.Show();
        }

        private void iADEETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IadeForm frm = new IadeForm();
            frm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaporlar frm = new FrmRaporlar();
            frm.ShowDialog();
        }
    }
}