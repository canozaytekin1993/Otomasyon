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
    public partial class frmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Numara();

        private bool Edit = false;
        private int SecimID = -1;

        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            Listele();
        }

        void Temizle()
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            txtKasaAdi.Text = "";
            txtAcıklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele(); 
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = new TBL_KASALAR();
                Kasa.ACIKLAMA = txtAcıklama.Text;
                Kasa.KASAADI = txtKasaAdi.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.SAVEDATE = DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASALARs.InsertOnSubmit(Kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kasa kaydı oluşturulmuştur.");
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
                Fonksiyonlar.TBL_KASALAR Kasa = DB.TBL_KASALARs.First(s => s.ID == SecimID);
                Kasa.ACIKLAMA = txtAcıklama.Text;
                Kasa.KASAADI = txtKasaAdi.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.EDITDATE = DateTime.Now;
                Kasa.EDITUSER = AnaForm.UserID;
                DB.TBL_KASALARs.InsertOnSubmit(Kasa);
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
                DB.TBL_KASALARs.DeleteOnSubmit(DB.TBL_KASALARs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true; 
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
                txtAcıklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KASALARs select s;
            Liste.DataSource = lst;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaAdi.Text != "" && txtAcıklama.Text != "")
            {
                if(Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
                    Guncelle();
                else
                {
                    MessageBox.Show("Kasa adı ve açıklama girilmesi gereklidir.", "İşlem Hatası", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
                Sil();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}