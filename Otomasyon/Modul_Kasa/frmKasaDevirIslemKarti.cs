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
    public partial class frmKasaDevirIslemKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Formlar();

        private bool Edit = false;
        private int KasaID = -1;
        private int IslemID = -1;
        public frmKasaDevirIslemKarti()
        {
            InitializeComponent();
        }

        private void frmKasaDevirIslemKarti_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtKasaBelgeNo.Text = "";
            txtKasaAdı.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = new TBL_KASAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGEID = txtKasaBelgeNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCıkıs.Checked)
                    Hareket.GCKODU = "C";
                if(rbtnGiris.Checked)
                        Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Devir Kartı Hareket Kaydı İşlenmiştir.");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGEID = txtKasaBelgeNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCıkıs.Checked)
                    Hareket.GCKODU = "C";
                if (rbtnGiris.Checked)
                    Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = AnaForm.UserID;
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
                DB.TBL_KASAHAREKETLERIs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtKasaBelgeNo.Text = Hareket.BELGEID;
                KasaAc(Hareket.KASAID.Value);
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.Value.ToString();
                if (Hareket.GCKODU == "G")
                    rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C")
                    rbtnCıkıs.Checked = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
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
                Mesajlar.Hata(e);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
                YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtKasaBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            }
    }
}