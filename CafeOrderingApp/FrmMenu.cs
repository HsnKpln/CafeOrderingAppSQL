using CafeOrderingApp.Business;
using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private CafeContext _context = new CafeContext();
        private KategoriRepository _kategoriRepo = new KategoriRepository();
        private UrunRepository _urunRepo = new UrunRepository();

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            UrunleriGetir();
        }

        private void KategorileriGetir()
        {
            lstKategoriler.DataSource = null;
            lstKategoriler.DataSource = _kategoriRepo.Get()
                .ToList();
        }
        private void UrunleriGetir()
        {
            if (_selectedKategori == null) return;
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = _urunRepo.Get()
                .Where(x => x.KategoriId == _selectedKategori.Id)
                .ToList();
        }
        private Kategori _selectedKategori;
        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null) return;
            _selectedKategori = lstKategoriler.SelectedItem as Kategori;
            UrunleriGetir();
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            var kategori = new Kategori()
            {
                Ad = txtKategoriAdi.Text
            };
            _kategoriRepo.Add(kategori);
            KategorileriGetir();

        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            var urun = new Urun()
            {
                Ad = txtUrunAdi.Text,
                Fiyat = nUrunFiyat.Value,
                KategoriId=_selectedKategori.Id
            };
            _urunRepo.Add(urun);
            UrunleriGetir();
        }
    }
}
