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
    public partial class FrmKafe : Form
    {
        public FrmKafe()
        {
            InitializeComponent();
        }
        private CafeContext _context = new CafeContext();
        private KatRepository _katRepo = new KatRepository();
        private MasaRepository _masaRepo = new MasaRepository();

        private void FrmKafe_Load(object sender, EventArgs e)
        {
            List<Kat> Katlar = _katRepo.Get().ToList();
            for (int i = 0; i < Katlar.Count; i++)
            {
                Kat kat = Katlar[i];
                Button button = new Button()
                {
                    Text = kat.Ad,
                    Size = new Size(140, 95),
                    BackColor = Color.Green,
                    Tag = kat
                };
                button.Click += KatBtn_click;
                flpKatlar.Controls.Add(button);
            }
        }
        private Kat _selectedKat;
        private void KatBtn_click(object? sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            _selectedKat = selectedButton.Tag as Kat;
            List<Masa> masalar = _masaRepo.Get().Where(x => x.katId == _selectedKat.Id).ToList();


            flpMasalar.Controls.Clear();
            foreach (var masa in masalar)
            {
                Button button = new Button()
                {
                    Text = masa.Ad,
                    Size = new Size(140, 95),
                    BackColor = Color.Green,
                    Tag = masa
                };
                button.Click += MasaBtn_click;
                flpMasalar.Controls.Add(button);
            }
        }
        private FrmSiparis _frmSiparis;
        private void MasaBtn_click(object? sender, EventArgs e)
        {
            
            if(_frmSiparis==null|| _frmSiparis.IsDisposed)
                       _frmSiparis = new FrmSiparis();
                _frmSiparis.Show();
            
        }
    }
}
