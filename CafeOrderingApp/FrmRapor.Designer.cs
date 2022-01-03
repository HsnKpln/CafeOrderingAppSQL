namespace CafeOrderingApp
{
    partial class FrmRapor
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
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.dgvAylikRapor = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.lblFiltreliFiyat = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylikRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Location = new System.Drawing.Point(15, 132);
            this.dgvSiparis.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.RowHeadersWidth = 51;
            this.dgvSiparis.RowTemplate.Height = 29;
            this.dgvSiparis.Size = new System.Drawing.Size(735, 478);
            this.dgvSiparis.TabIndex = 0;
            // 
            // dgvAylikRapor
            // 
            this.dgvAylikRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAylikRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAylikRapor.Location = new System.Drawing.Point(775, 132);
            this.dgvAylikRapor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAylikRapor.Name = "dgvAylikRapor";
            this.dgvAylikRapor.RowHeadersWidth = 51;
            this.dgvAylikRapor.RowTemplate.Height = 29;
            this.dgvAylikRapor.Size = new System.Drawing.Size(785, 478);
            this.dgvAylikRapor.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 31);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(775, 80);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(311, 31);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1095, 80);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(311, 31);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrele.Location = new System.Drawing.Point(1415, 80);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(145, 37);
            this.btnFiltrele.TabIndex = 5;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGun.Location = new System.Drawing.Point(15, 631);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(91, 38);
            this.lblGun.TabIndex = 6;
            this.lblGun.Text = "label1";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplamFiyat.Location = new System.Drawing.Point(633, 631);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(91, 38);
            this.lblToplamFiyat.TabIndex = 6;
            this.lblToplamFiyat.Text = "label1";
            // 
            // lblFiltreliFiyat
            // 
            this.lblFiltreliFiyat.AutoSize = true;
            this.lblFiltreliFiyat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltreliFiyat.Location = new System.Drawing.Point(774, 631);
            this.lblFiltreliFiyat.Name = "lblFiltreliFiyat";
            this.lblFiltreliFiyat.Size = new System.Drawing.Size(439, 38);
            this.lblFiltreliFiyat.TabIndex = 6;
            this.lblFiltreliFiyat.Text = "Seçili Günlerde Toplam Ciro:   0.00";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(1415, 673);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(145, 72);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 855);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblFiltreliFiyat);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvAylikRapor);
            this.Controls.Add(this.dgvSiparis);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylikRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.DataGridView dgvAylikRapor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblFiltreliFiyat;
        private System.Windows.Forms.Button btnGeri;
    }
}