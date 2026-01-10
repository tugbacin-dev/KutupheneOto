namespace KutupheneOto.UI
{
    partial class FrmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            this.dgvYaklasanlar = new System.Windows.Forms.DataGridView();
            this.dgvAktifUyeler = new System.Windows.Forms.DataGridView();
            this.dgvEnCokOkunan = new System.Windows.Forms.DataGridView();
            this.dgvGecikenler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaklasanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifUyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokOkunan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYaklasanlar
            // 
            this.dgvYaklasanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYaklasanlar.Location = new System.Drawing.Point(34, 50);
            this.dgvYaklasanlar.Name = "dgvYaklasanlar";
            this.dgvYaklasanlar.RowHeadersWidth = 51;
            this.dgvYaklasanlar.RowTemplate.Height = 24;
            this.dgvYaklasanlar.Size = new System.Drawing.Size(285, 177);
            this.dgvYaklasanlar.TabIndex = 0;
            // 
            // dgvAktifUyeler
            // 
            this.dgvAktifUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktifUyeler.Location = new System.Drawing.Point(436, 266);
            this.dgvAktifUyeler.Name = "dgvAktifUyeler";
            this.dgvAktifUyeler.RowHeadersWidth = 51;
            this.dgvAktifUyeler.RowTemplate.Height = 24;
            this.dgvAktifUyeler.Size = new System.Drawing.Size(289, 185);
            this.dgvAktifUyeler.TabIndex = 1;
            // 
            // dgvEnCokOkunan
            // 
            this.dgvEnCokOkunan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCokOkunan.Location = new System.Drawing.Point(436, 50);
            this.dgvEnCokOkunan.Name = "dgvEnCokOkunan";
            this.dgvEnCokOkunan.RowHeadersWidth = 51;
            this.dgvEnCokOkunan.RowTemplate.Height = 24;
            this.dgvEnCokOkunan.Size = new System.Drawing.Size(289, 177);
            this.dgvEnCokOkunan.TabIndex = 2;
            // 
            // dgvGecikenler
            // 
            this.dgvGecikenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikenler.Location = new System.Drawing.Point(34, 266);
            this.dgvGecikenler.Name = "dgvGecikenler";
            this.dgvGecikenler.RowHeadersWidth = 51;
            this.dgvGecikenler.RowTemplate.Height = 24;
            this.dgvGecikenler.Size = new System.Drawing.Size(285, 185);
            this.dgvGecikenler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "İade Tarihi Yaklaşan Kitaplar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geç Kalan Kitaplar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(449, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "En Çok Ödünç Alınan Kitaplar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(449, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aktif Üyeler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 501);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(85)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(802, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGecikenler);
            this.Controls.Add(this.dgvEnCokOkunan);
            this.Controls.Add(this.dgvAktifUyeler);
            this.Controls.Add(this.dgvYaklasanlar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaklasanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifUyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokOkunan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYaklasanlar;
        private System.Windows.Forms.DataGridView dgvAktifUyeler;
        private System.Windows.Forms.DataGridView dgvEnCokOkunan;
        private System.Windows.Forms.DataGridView dgvGecikenler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}