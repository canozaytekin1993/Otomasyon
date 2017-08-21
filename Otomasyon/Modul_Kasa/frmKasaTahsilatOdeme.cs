using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Otomasyon.Fonksiyonlar;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Formlar();

        private bool Edit = false;
        private int IslemID = -1;
        private int CariHareketID = -1;
        private int KasaID = -1;
        private int CariID = -1;

        public frmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmKasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtKasaBelgeNo.Text = "";
            txtCariAdı.Text = "";
            txtCariKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            txtKasaAdı.Text = "";
            txtKasaKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            KasaID = -1;
            CariID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                CariHareketID = DB.TBL_CARIHAREKETLERIs
                    .First(s => s.EVRAKTURU == KasaHareketi.EVRAKTURU && s.EVRAKID == IslemID).ID;
                txtAciklama.Text = KasaHareketi.ACIKLAMA;
                txtKasaBelgeNo.Text = KasaHareketi.BELGEID;
                if (KasaHareketi.EVRAKTURU == "Kasa Tahsilatı") txtIslemTuru.SelectedIndex = 0;
                if (KasaHareketi.EVRAKTURU == "Kasa Ödeme") txtIslemTuru.SelectedIndex = 1;
                txtTarih.Text = KasaHareketi.TARIH.Value.ToShortDateString();
                txtTutar.Text = KasaHareketi.TUTAR.Value.ToString();
                KasaAc(KasaHareketi.KASAID.Value);
                CariAc(KasaHareketi.CARDID.Value);
            }
            catch (Exception e)
            {
                Temizle();Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdı.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception e)
            {
                KasaID = -1;
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdı.Text = DB.TBL_CARILERs.First(s => s.ID == KasaID).CARIADI;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == KasaID).CARIKODU;
            }
            catch (Exception e)
            {
                CariID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = new TBL_KASAHAREKETLERI();
                KasaHareketi.ACIKLAMA = txtAciklama.Text;
                KasaHareketi.BELGEID = txtKasaBelgeNo.Text;
                KasaHareketi.CARDID = CariID;
                KasaHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.SAVEDATE = DateTime.Now;
                KasaHareketi.SAVEUSER = AnaForm.UserID;
                KasaHareketi.TARIH =DateTime.Parse(txtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txtTutar.Text);
                DB.TBL_KASAHAREKETLERIs.InsertOnSubmit(KasaHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString() + " yeni kasa hareketi olarak işlemiştir.");
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtKasaBelgeNo.Text + " belge numaralı " + txtIslemTuru.SelectedItem.ToString() +  " işlemi";
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.TIPI = "KÖ";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString() + " yeni cari hareketi olarak işlenmiştir.");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket =
                    DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == KasaHareketi.EVRAKTURU && s.EVRAKID == KasaHareketi.EVRAKID);
                KasaHareketi.ACIKLAMA = txtAciklama.Text;
                KasaHareketi.BELGEID = txtKasaBelgeNo.Text;
                KasaHareketi.CARDID = CariID;
                KasaHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.EDITDATE = DateTime.Now;
                KasaHareketi.EDITUSER = AnaForm.UserID;
                KasaHareketi.TARIH = DateTime.Parse(txtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);    
                CariHareket.ACIKLAMA = txtKasaBelgeNo.Text + " belge numaralı " + txtIslemTuru.SelectedItem.ToString() +
                                       " işlemi";
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.TIPI = "KÖ";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

            void Sil()
            {
                try
                {
                    DB.TBL_KASAHAREKETLERIs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                    DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID));
                    Temizle();
                }
                catch (Exception e)
                {
                    Mesajlar.Hata(e);
                }
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_KASAHAREKETLERIs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID));
                Temizle();
            }
            catch (Exception e)
            {
               Mesajlar.Hata(e);
            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0)
            {
                CariAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && IslemID > 0 && CariHareketID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}