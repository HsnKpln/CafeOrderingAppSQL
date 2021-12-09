
namespace CafeOrderingApp
{
    partial class FrmKatAyar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKatAdi = new System.Windows.Forms.TextBox();
            this.txtKatSirasi = new System.Windows.Forms.TextBox();
            this.txtKatKodu = new System.Windows.Forms.TextBox();
            this.txtMasaSayisi = new System.Windows.Forms.TextBox();
            this.btnKatKaydet = new System.Windows.Forms.Button();
            this.lstKat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kat Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sırası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Masa Sayısı";
            // 
            // txtKatAdi
            // 
            this.txtKatAdi.Location = new System.Drawing.Point(127, 9);
            this.txtKatAdi.Name = "txtKatAdi";
            this.txtKatAdi.Size = new System.Drawing.Size(169, 33);
            this.txtKatAdi.TabIndex = 4;
            // 
            // txtKatSirasi
            // 
            this.txtKatSirasi.Location = new System.Drawing.Point(127, 48);
            this.txtKatSirasi.Name = "txtKatSirasi";
            this.txtKatSirasi.Size = new System.Drawing.Size(169, 33);
            this.txtKatSirasi.TabIndex = 4;
            // 
            // txtKatKodu
            // 
            this.txtKatKodu.Location = new System.Drawing.Point(127, 87);
            this.txtKatKodu.Name = "txtKatKodu";
            this.txtKatKodu.Size = new System.Drawing.Size(169, 33);
            this.txtKatKodu.TabIndex = 4;
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Location = new System.Drawing.Point(127, 126);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(169, 33);
            this.txtMasaSayisi.TabIndex = 4;
            // 
            // btnKatKaydet
            // 
            this.btnKatKaydet.Location = new System.Drawing.Point(127, 182);
            this.btnKatKaydet.Name = "btnKatKaydet";
            this.btnKatKaydet.Size = new System.Drawing.Size(169, 54);
            this.btnKatKaydet.TabIndex = 5;
            this.btnKatKaydet.Text = "Kaydet";
            this.btnKatKaydet.UseVisualStyleBackColor = true;
            this.btnKatKaydet.Click += new System.EventHandler(this.btnKatKaydet_Click);
            // 
            // lstKat
            // 
            this.lstKat.FormattingEnabled = true;
            this.lstKat.ItemHeight = 25;
            this.lstKat.Location = new System.Drawing.Point(323, 9);
            this.lstKat.Name = "lstKat";
            this.lstKat.Size = new System.Drawing.Size(189, 304);
            this.lstKat.TabIndex = 6;
            // 
            // FrmKatAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 443);
            this.Controls.Add(this.lstKat);
            this.Controls.Add(this.btnKatKaydet);
            this.Controls.Add(this.txtMasaSayisi);
            this.Controls.Add(this.txtKatKodu);
            this.Controls.Add(this.txtKatSirasi);
            this.Controls.Add(this.txtKatAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmKatAyar";
            this.Text = "FrmKatAyar";
            this.Load += new System.EventHandler(this.FrmKatAyar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKatAdi;
        private System.Windows.Forms.TextBox txtKatSirasi;
        private System.Windows.Forms.TextBox txtKatKodu;
        private System.Windows.Forms.TextBox txtMasaSayisi;
        private System.Windows.Forms.Button btnKatKaydet;
        private System.Windows.Forms.ListBox lstKat;
    }
}