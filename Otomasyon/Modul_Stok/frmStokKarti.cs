using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;
using Otomasyon.Fonksiyonlar;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKarti()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Numara();
        Fonksiyonlar.Formlar Formlar = new Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Resimleme();

        private bool Edit = false;
        private bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        private int GrupID = -1;
        private int StokID = -1;

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            txtStokKodu.Text = Numaralar.StokKodNumarasi();
        }

        void Temizle()
        {
            txtStokKodu.Text = Numaralar.StokKodNumarasi();
            txtStokAdi.Text = "";
            txtSatıskdv.Text = "";
            txtSatısfiyatı.Text = "";
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            txtAlıskdv.Text = "0";
            txtAlısfiyatı.Text = "0";
            pictureBox1.Image = null;
            Edit = false;
            Resim = false;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKayıt()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = new TBL_STOKLAR();
                Stok.STOKADI = txtStokAdi.Text;
                Stok.STOKALISFIYATI = decimal.Parse(txtAlısfiyatı.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlıskdv.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKodu.Text;
                Stok.STOKRESİM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYATI = decimal.Parse(txtSatısfiyatı.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatıskdv.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = AnaForm.UserID;
                DB.TBL_STOKLARs.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni stok kaydı oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLARs.First(s => s.ID == StokID);
                Stok.STOKADI = txtStokAdi.Text;
                Stok.STOKALISFIYATI = decimal.Parse(txtAlısfiyatı.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlıskdv.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKodu.Text;
                if(Resim) Stok.STOKRESİM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYATI = decimal.Parse(txtSatısfiyatı.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatıskdv.Text);
                Stok.STOKEDITDATE = DateTime.Now;
                Stok.STOKEDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_STOKGRUPLARIs.DeleteOnSubmit(DB.TBL_STOKGRUPLARIs.First(s => s.ID == StokID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            txtGrupAdi.Text = DB.TBL_STOKGRUPLARIs.First(s => s.ID == GrupID).GRUPADI;
            txtGrupKodu.Text = DB.TBL_STOKGRUPLARIs.First(s => s.ID == GrupID).GRUPKODU;
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLARs.First(s => s.ID == StokID);
            GrupAc(Stok.STOKGRUPID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.STOKRESİM.ToArray());
            txtAlısfiyatı.Text = Stok.STOKALISFIYATI.ToString();
            txtAlıskdv.Text = Stok.STOKALISKDV.ToString();
            txtBarkod.Text = Stok.STOKBARKOD;
            txtBirim.Text = Stok.STOKBIRIM;
            txtSatısfiyatı.Text = Stok.STOKSATISFIYATI.ToString();
            txtSatıskdv.Text = Stok.STOKSATISKDV.ToString();
            txtStokAdi.Text = Stok.STOKADI;
            txtStokKodu.Text = Stok.STOKKODU;
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.StokGruplari(true);
            if (Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;}

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKayıt();}
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes)
                Sil();
        }
    }
}