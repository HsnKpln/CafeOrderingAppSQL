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
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }
        private CafeContext _context= new CafeContext();
        private KategoriRepository _kategoriRepo= new KategoriRepository();
        private UrunRepository _urunRepo= new UrunRepository();
        private MasaRepository _masaRepo= new MasaRepository();
        private SiparisRepository _siparisRepo= new SiparisRepository();
        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            List<Kategori>Kategoriler= _kategoriRepo.Get().ToList();
            for (int i = 0; i < Kategoriler.Count; i++)
            {
                Kategori kategori= Kategoriler[i];
                Button button = new Button()
                {
                    Text = kategori.Ad,
                    Size = new Size(140, 95),
                    BackColor = Color.White,
                    Tag = kategori
                };
                flpKategori.Controls.Add(button);
                button.Click += KategoriBtn_click;
            }
        }
        private Kategori _selectedKategori;
        private void KategoriBtn_click(object? sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            _selectedKategori=selectedButton.Tag as Kategori;
            List<Urun> urunler= _urunRepo.Get().Where(x=>x.KategoriId==_selectedKategori.Id)
                .ToList();
        }
    }
}
