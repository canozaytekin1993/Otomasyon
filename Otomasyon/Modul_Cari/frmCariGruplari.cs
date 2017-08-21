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

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        public frmCariGruplari()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        private bool Edit = false;
        private int SecimID = -1;

        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CARIGRUPLARIs select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception e)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIGRUPLARIs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni cari grup kaydı oluşturuldu.");
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
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID);
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.EDITDATE = DateTime.Now;
                Grup.EDITUSER = AnaForm.UserID;
                DB.TBL_CARIGRUPLARIs.InsertOnSubmit(Grup);
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
                DB.TBL_CARIGRUPLARIs.DeleteOnSubmit(DB.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}