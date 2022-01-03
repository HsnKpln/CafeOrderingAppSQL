using CafeOrderingApp.Business;
using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using CafeOrderingApp.ViewModel;
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
        public Masa _selectedMasa { get; set; }
        public FrmSiparis(Masa selectedMasa)
        {
            InitializeComponent();
            _selectedMasa = selectedMasa;
        }
        private CafeContext _context= new CafeContext();
        private KategoriRepository _kategoriRepo= new KategoriRepository();
        private UrunRepository _urunRepo= new UrunRepository();
        private MasaRepository _masaRepo= new MasaRepository();
        private SiparisRepository _siparisRepo= new SiparisRepository();
        public List<Siparis> MasaninSiparisleri { get; set; }
        //public Masa _selectedMasa;
        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            SiparisleriGetir();
        }
        private void KategorileriGetir()
        {
            List<Kategori> Kategoriler = _kategoriRepo.Get().ToList();
            for (int i = 0; i < Kategoriler.Count; i++)
            {
                Kategori kategori = Kategoriler[i];
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
            List<Urun> urunler= _urunRepo.Get().Where(x=>x.KategoriId==_selectedKategori.Id).ToList();

            flpUrun.Controls.Clear();
            foreach (Urun urun in urunler)
            {
                Button button = new Button()
                {
                    Text = urun.Ad,
                    Size = new Size(140, 95),
                    BackColor = Color.Green,
                    Tag = urun
                };
                flpUrun.Controls.Add(button);
                button.Click += UrunBtn_Click;
            }
        }
        Urun _seciliUrun;
        private void UrunBtn_Click(object? sender, EventArgs e)
        {
            Button selectedButton= sender as Button;
            _seciliUrun = selectedButton.Tag as Urun;
            // var siparis= _siparisRepo.Get().FirstOrDefault(x=>x.UrunId==_seciliUrun.Id && x.MasaId==_selectedMasa.Id);
            var siparis = _siparisRepo.Get().FirstOrDefault(x => x.UrunId == _seciliUrun.Id &&
              x.MasaId == _selectedMasa.Id && x.SiparisDurum == true && x.IsDeleted == false);
            if (siparis == null)
            {
                Siparis yeniSiparis = new Siparis()
                {
                    Adet = 1,
                    Fiyat=_seciliUrun.Fiyat,
                    AraToplam=_seciliUrun.Fiyat*1,
                    SiparisDurum=true,
                    DateTime = DateTime.Now,
                    DateTimeDay = DateTime.Now.ToString("MM/dd/yyyy"),
                    DateTimeHour = DateTime.Now.ToString("HH:mm:ss"),
                    MasaId = _selectedMasa.Id,
                    UrunId= _seciliUrun.Id,
                    IsDeleted= false

                };
                _siparisRepo.Add(yeniSiparis);
            }
            else
            {
                siparis.Adet++;
                siparis.AraToplam = siparis.Adet * siparis.Fiyat;
                _siparisRepo.Update(siparis);

            }
            SiparisleriGetir();
        }

        private void SiparisleriGetir()
        {

            var query = from sip in _context.Siparisler
                        join ur in _context.Urunler on sip.UrunId equals ur.Id  
                        where sip.IsDeleted==false
                        select new SiparisViewModel()
                        {
                            SiparisDurum = sip.SiparisDurum,
                            SiparisId=sip.Id,
                            UrunId = sip.Id,
                            UrunAd = ur.Ad,
                            Adet = sip.Adet,
                            Fiyat = sip.Fiyat,
                            AraToplam = sip.AraToplam,
                            MasaId = sip.MasaId
                        };
           

            var liste = query.Where(x => x.MasaId == _selectedMasa.Id && x.SiparisDurum==true).ToList();

            dgvSiparis.DataSource = null;
            dgvSiparis.DataSource= liste;
            //dgvSiparis.Columns["SiparisId"].Visible = false;
            //dgvSiparis.Columns["SiparisDurum"].Visible = false;
            //dgvSiparis.Columns["UrunId"].Visible = false;
            //dgvSiparis.Columns["MasaId"].Visible = false;
            dgvSiparis.Columns[2].HeaderText = "ÜRÜN ADI";
            dgvSiparis.Columns[3].HeaderText = "ADET";
            dgvSiparis.Columns[4].HeaderText = "FİYAT";
            dgvSiparis.Columns[5].HeaderText = "ARA TOPLAM";
            dgvSiparis.ClearSelection();

            decimal toplamFiyat = 0;
            foreach (var item in liste)
            {
                toplamFiyat += item.AraToplam;
            };
            lblToplamFiyat.Text = $"Toplam Tutar:{toplamFiyat:c2}₺";
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvSiparis.SelectedRows[0];
                int selectedId=Convert.ToInt32(selected.Cells[0].Value);
                var siparis= _siparisRepo.Get().FirstOrDefault(x => x.Id == selectedId);

                if (siparis.Adet == 1)
                {
                    _siparisRepo.Remove(siparis);
                }
                else
                {
                    siparis.Adet--;
                    siparis.AraToplam = siparis.Adet * siparis.Fiyat;
                    _siparisRepo.Update(siparis);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen azaltacağınız siparişi seçiniz..");
            }
            SiparisleriGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvSiparis.SelectedRows[0];
                int selectedId = Convert.ToInt32(selected.Cells[0].Value);
                var siparis = _siparisRepo.Get().FirstOrDefault(x => x.Id == selectedId);
                _siparisRepo.Remove(siparis);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen silmek istediğiniz siparişi seçiniz..");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            var siparisList= _siparisRepo.Get().ToList();
            foreach (var item in siparisList)
            {
                if (item.Id==_selectedMasa.Id)
                {
                    _siparisRepo.Remove(item);
                }
            }
            SiparisleriGetir();
            Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            var siparisList = _siparisRepo.Get().ToList();
            foreach (var item in siparisList)
            {
                if (item.MasaId==_selectedMasa.Id && item.SiparisDurum==true)
                {
                    item.SiparisDurum = false;
                    item.DateTime = DateTime.Now;
                    item.DateTimeDay = DateTime.Now.ToString("dd/MM/yyyy");
                    item.DateTimeHour = DateTime.Now.ToString("HH:mm:ss");
                    _siparisRepo.Update(item);
                }
            }
            SiparisleriGetir();
            Close();


        }
        private FrmKafe _frmKafe;
        private void FrmSiparis_FormClosed(object sender, FormClosedEventArgs e)
        {
             if(_frmKafe==null || _frmKafe.IsDisposed)
            {
                _frmKafe= new FrmKafe();
               
            }
            _frmKafe.Show();
            _frmKafe.WindowState= FormWindowState.Maximized;
            _frmKafe.Hide();
        }

        private void btnAdisyon_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            SolidBrush firca = new SolidBrush(Color.Black);
            Pen kalem = new Pen(Color.Black);
            e.Graphics.DrawString($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);
            font = new Font("Arial", 20, FontStyle.Bold);
            e.Graphics.DrawString($"Satış Raporu", font, firca, 290, 75);
            e.Graphics.DrawLine(kalem, 50, 70, 780, 70);
            e.Graphics.DrawLine(kalem, 50, 110, 780, 110);
            e.Graphics.DrawLine(kalem, 50, 70, 50, 110);
            e.Graphics.DrawLine(kalem, 780, 70, 780, 110);

            font = new Font("Arial", 14, FontStyle.Bold);

            e.Graphics.DrawString("ÜRÜN ADI", font, firca, 60, 140);
            e.Graphics.DrawString("ADETİ", font, firca, 280, 140);
            e.Graphics.DrawString("FİYATI", font, firca, 420, 140);
            e.Graphics.DrawString("ARA TOPLAM", font, firca, 550, 140);

            int i = 0;
            int y = 170;
            font = new Font("Arial", 14);
            while (i <= dgvSiparis.Rows.Count - 1)
            {
                e.Graphics.DrawString(dgvSiparis.Rows[i].Cells[2].Value.ToString(), font, firca, 60, y);
                e.Graphics.DrawString($"{dgvSiparis.Rows[i].Cells[1].Value}".ToString(), font, firca, 280, y);
                e.Graphics.DrawString($"{dgvSiparis.Rows[i].Cells[4].Value:c2}", font, firca, 420, y);
                e.Graphics.DrawString($"{ dgvSiparis.Rows[i].Cells[5].Value:c2}".ToString(), font, firca, 550, y);
                y = y + 40;
                i = i + 1;
            }
            e.Graphics.DrawString($"Toplam Tutar: {dgvSiparis.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells[5].Value)):c2}".ToString(), font, firca, 550, y + 40);

        }


    }

}
