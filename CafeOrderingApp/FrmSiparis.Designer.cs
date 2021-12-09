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
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnAdisyon = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
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
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 28;
            this.lstSiparis.Location = new System.Drawing.Point(857, 12);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(231, 480);
            this.lstSiparis.TabIndex = 1;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(12, 515);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(149, 75);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(195, 515);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 75);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(373, 515);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(141, 75);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Location = new System.Drawing.Point(548, 515);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(144, 75);
            this.btnAdisyon.TabIndex = 5;
            this.btnAdisyon.Text = "Adisyon";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(716, 515);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 75);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAdisyon);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.flpUrun);
            this.Controls.Add(this.flpKategori);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKategori;
        private System.Windows.Forms.FlowLayoutPanel flpUrun;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAdisyon;
        private System.Windows.Forms.Button btnKapat;
    }
}