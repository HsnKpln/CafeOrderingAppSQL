namespace CafeOrderingApp
{
    partial class FrmSiparis
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
            this.flpKategori = new System.Windows.Forms.FlowLayoutPanel();
            this.flpUrun = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnAdisyon = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // flpKategori
            // 
            this.flpKategori.Location = new System.Drawing.Point(12, 12);
            this.flpKategori.Name = "flpKategori";
            this.flpKategori.Size = new System.Drawing.Size(839, 207);
            this.flpKategori.TabIndex = 0;
            // 
            // flpUrun
            // 
            this.flpUrun.Location = new System.Drawing.Point(12, 225);
            this.flpUrun.Name = "flpUrun";
            this.flpUrun.Size = new System.Drawing.Size(839, 267);
            this.flpUrun.TabIndex = 0;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(12, 515);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(149, 75);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(195, 515);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 75);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(373, 515);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(141, 75);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Location = new System.Drawing.Point(548, 515);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(144, 75);
            this.btnAdisyon.TabIndex = 5;
            this.btnAdisyon.Text = "Adisyon";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(716, 515);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 75);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Location = new System.Drawing.Point(869, 12);
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.RowHeadersWidth = 51;
            this.dgvSiparis.RowTemplate.Height = 29;
            this.dgvSiparis.Size = new System.Drawing.Size(541, 480);
            this.dgvSiparis.TabIndex = 7;
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplamFiyat.Location = new System.Drawing.Point(1210, 536);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(200, 31);
            this.lblToplamFiyat.TabIndex = 8;
            this.lblToplamFiyat.Text = "Toplam Tutar: 0.00";
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(869, 515);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(127, 75);
            this.btnAzalt.TabIndex = 9;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 630);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.dgvSiparis);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAdisyon);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.flpUrun);
            this.Controls.Add(this.flpKategori);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSiparis_FormClosed);
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKategori;
        private System.Windows.Forms.FlowLayoutPanel flpUrun;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAdisyon;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Button btnAzalt;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}