
namespace CafeOrderingApp
{
    partial class FrmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.pbKategori = new System.Windows.Forms.PictureBox();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.pbUrunler = new System.Windows.Forms.PictureBox();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(102, 5);
            this.txtKategoriAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(153, 29);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // pbKategori
            // 
            this.pbKategori.Location = new System.Drawing.Point(102, 53);
            this.pbKategori.Name = "pbKategori";
            this.pbKategori.Size = new System.Drawing.Size(153, 178);
            this.pbKategori.TabIndex = 2;
            this.pbKategori.TabStop = false;
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(102, 253);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(153, 61);
            this.btnKategoriKaydet.TabIndex = 3;
            this.btnKategoriKaydet.Text = "Kaydet";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 21;
            this.lstKategoriler.Location = new System.Drawing.Point(263, 8);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(168, 361);
            this.lstKategoriler.TabIndex = 4;
            this.lstKategoriler.SelectedIndexChanged += new System.EventHandler(this.lstKategoriler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(516, 5);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(153, 29);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // nUrunFiyat
            // 
            this.nUrunFiyat.Location = new System.Drawing.Point(516, 41);
            this.nUrunFiyat.Name = "nUrunFiyat";
            this.nUrunFiyat.Size = new System.Drawing.Size(153, 29);
            this.nUrunFiyat.TabIndex = 7;
            // 
            // pbUrunler
            // 
            this.pbUrunler.Location = new System.Drawing.Point(516, 87);
            this.pbUrunler.Name = "pbUrunler";
            this.pbUrunler.Size = new System.Drawing.Size(153, 178);
            this.pbUrunler.TabIndex = 8;
            this.pbUrunler.TabStop = false;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(516, 282);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(153, 61);
            this.btnUrunKaydet.TabIndex = 9;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 21;
            this.lstUrunler.Location = new System.Drawing.Point(676, 5);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(171, 361);
            this.lstUrunler.TabIndex = 10;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 629);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.pbUrunler);
            this.Controls.Add(this.nUrunFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.btnKategoriKaydet);
            this.Controls.Add(this.pbKategori);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.PictureBox pbKategori;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nUrunFiyat;
        private System.Windows.Forms.PictureBox pbUrunler;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}