using CafeOrderingApp.Business;
using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOrderingApp
{
    public partial class FrmKatAyar : Form
    {
        public FrmKatAyar()
        {
            InitializeComponent();
        }
        private CafeContext _context = new CafeContext();
        private KatRepository _katRepo = new KatRepository();
        private MasaRepository _masaRepo = new MasaRepository();

        private void FrmKatAyar_Load(object sender, EventArgs e)
        {
            lstKat.DataSource = _katRepo.Get().ToList();
        }

        private void btnKatKaydet_Click(object sender, EventArgs e)
        {
            var kat = new Kat()
            {
                Ad = txtKatAdi.Text,
                Sira=Convert.ToInt32(txtKatSirasi.Text),
                Kod=txtKatKodu.Text

            };
            int masaSayisi = Convert.ToInt32(txtMasaSayisi.Text);
            for (int i = 0; i < masaSayisi; i++)
            {
                Masa masa = new Masa()
                {
                    Sira = i + 1,
                    Ad = $"{kat.Ad}/{kat.Kod}-{i+1}",
                    MasaDurumuDoluMu = false

                };
                kat.Masalar.Add(masa);
            }
            _katRepo.Add(kat);
            lstKat.DataSource = null;
            lstKat.DataSource = _katRepo.Get().ToList();
        }
    }
}
