
namespace CafeOrderingApp
{
    partial class FrmAnaEkran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kurulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katMasaAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurulumToolStripMenuItem,
            this.kafeToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kurulumToolStripMenuItem
            // 
            this.kurulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.katMasaAyarlarıToolStripMenuItem});
            this.kurulumToolStripMenuItem.Name = "kurulumToolStripMenuItem";
            this.kurulumToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.kurulumToolStripMenuItem.Text = "Kurulum";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // katMasaAyarlarıToolStripMenuItem
            // 
            this.katMasaAyarlarıToolStripMenuItem.Name = "katMasaAyarlarıToolStripMenuItem";
            this.katMasaAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.katMasaAyarlarıToolStripMenuItem.Text = "Kat/Masa Ayarları";
            this.katMasaAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.katMasaAyarlarıToolStripMenuItem_Click);
            // 
            // kafeToolStripMenuItem
            // 
            this.kafeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişToolStripMenuItem});
            this.kafeToolStripMenuItem.Name = "kafeToolStripMenuItem";
            this.kafeToolStripMenuItem.Size = new System.Drawing.Size(75, 36);
            this.kafeToolStripMenuItem.Text = "Kafe";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            this.siparişToolStripMenuItem.Click += new System.EventHandler(this.siparişToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAnaEkran";
            this.Text = "FrmAnaEkran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kurulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katMasaAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kafeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}