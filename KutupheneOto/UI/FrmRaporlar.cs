using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Windows.Forms;
using KutupheneOto.Services;

namespace KutupheneOto.UI
{
    public partial class FrmRaporlar : Form
    {
      
        RaporService raporService = new RaporService();

        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            RaporlariYukle();
        }

        public void RaporlariYukle()
        {
            try
            {
               
                dgvYaklasanlar.DataSource = raporService.RaporuGetir("yaklasan");

                
                dgvEnCokOkunan.DataSource = raporService.RaporuGetir("populer");

              
                dgvGecikenler.DataSource = raporService.RaporuGetir("gecikmis");

               
                dgvAktifUyeler.DataSource = raporService.RaporuGetir("aktif");

               
                TabloyuGüzellestir(dgvYaklasanlar);
                TabloyuGüzellestir(dgvEnCokOkunan);
                TabloyuGüzellestir(dgvGecikenler);
                TabloyuGüzellestir(dgvAktifUyeler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void TabloyuGüzellestir(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true; 
            dgv.AllowUserToAddRows = false; 
        }
    }
}