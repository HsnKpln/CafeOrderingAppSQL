using CafeOrderingApp.Business;
using CafeOrderingApp.Data;
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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

      private CafeContext _context= new CafeContext();
      private KategoriRepository _kategoriRepo=new KategoriRepository();
        private UrunRepository _urunRepo=new UrunRepository();
        private SiparisRepository _siparisRepo=new SiparisRepository();
        private MasaRepository _masaRepo=new MasaRepository();

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            DayReport();
           FilterLoad();
        }
        private decimal toplam=0;
        private void DayReport()
        {
            lblGun.Text = $"{dateTimePicker1.Value.ToString("dd/MM/yyyy")} Günü Toplam Cirosu";
            var query = from sip in _context.Siparisler
                        join urn in _context.Urunler on sip.UrunId equals urn.Id
                        join mas in _context.Masalar on sip.MasaId equals mas.Id
                        select new ReportVlewModel
                        {
                            MasaIsmi = mas.Ad,
                            UrunIsmi = urn.Ad,
                            AraToplam = sip.AraToplam,
                            SiparisDurum = sip.SiparisDurum,
                            DateTime = sip.DateTime,
                            DateTimeDay = sip.DateTimeDay,
                            DateTimeHour = sip.DateTimeHour
                        };
            var liste = query.Where(x => x.DateTimeDay == dateTimePicker1.Value.ToString("dd/MM/yyyy") && x.SiparisDurum == false).OrderByDescending(x => x.DateTimeHour).ToList();
            dgvSiparis.DataSource = null;
            dgvSiparis.DataSource = liste;
            dgvSiparis.Columns["SiparisDurum"].Visible = false;
            dgvSiparis.Columns["DateTimeDay"].Visible = false;
            dgvSiparis.Columns["DateTimeHour"].Visible = false;
            dgvSiparis.Columns[0].HeaderText = "MASA İSMİ";
            dgvSiparis.Columns[1].HeaderText = "ÜRÜN ADI";
            dgvSiparis.Columns[2].HeaderText = "ARA TOPLAM";
            dgvSiparis.Columns[4].HeaderText = "TARİH";

            toplam = 0;
            foreach (var item in liste)
            {
                toplam += item.AraToplam;
            }
            lblToplamFiyat.Text = $"{toplam}₺";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DayReport();
        }
        private void FilterLoad()
        {
            //var query = from sip in _context.Siparisler
            //            join urn in _context.Urunler on sip.UrunId equals urn.Id
            //            join mas in _context.Masalar on sip.MasaId equals mas.Id
            //            where sip.DateTimeDay == dateTimePicker1.Value.ToString("dd/MM/yyyy") && sip.SiparisDurum == false
            //            group new { sip, urn, mas } by new
            //            {
            //                urn.Ad,
            //            } into list
            //            orderby list.Key.Ad
            //            select new ReportVlewModel
            //            {
            //                UrunIsmi = list.Key.Ad,
            //                AraToplam = list.Sum(x => x.sip.AraToplam),
            //            };
            //var liste = query.ToList();

            var query = from sip in _context.Siparisler
                        join urn in _context.Urunler on sip.UrunId equals urn.Id
                        join mas in _context.Masalar on sip.MasaId equals mas.Id
                        select new ReportVlewModel
                        {
                            MasaIsmi = mas.Ad,
                            UrunIsmi = urn.Ad,
                            AraToplam = sip.AraToplam,
                            SiparisDurum = sip.SiparisDurum,
                            DateTime = sip.DateTime,
                            DateTimeDay = sip.DateTimeDay,
                            DateTimeHour = sip.DateTimeHour
                        };
            var liste = query.Where(x => x.DateTimeDay == dateTimePicker2.Value.ToString("dd/MM/yyyy") && x.SiparisDurum == false).OrderByDescending(x => x.DateTimeHour).ToList();

            dgvAylikRapor.DataSource = null;
            dgvAylikRapor.DataSource = liste;
            dgvAylikRapor.Columns["SiparisDurum"].Visible = false;
            dgvAylikRapor.Columns["MasaIsmi"].Visible = false;
            dgvAylikRapor.Columns["DateTime"].Visible = false;
            dgvAylikRapor.Columns["DateTimeDay"].Visible = false;
            dgvAylikRapor.Columns["DateTimeHour"].Visible = false;
            dgvAylikRapor.Columns[1].HeaderText = "ÜRÜN ADI";
            dgvAylikRapor.Columns[2].HeaderText = "TOPLAM SATIŞ";
            toplam = 0;
            foreach (var item in liste)
            {
                toplam += item.AraToplam;
            }
            lblFiltreliFiyat.Text = $"Seçili Günler Arası Toplam Ciro:        {toplam}₺";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
