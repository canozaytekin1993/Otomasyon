using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otomasyon.Modul_Cari;
using Otomasyon.Modul_Kasa;
using Otomasyon.Modul_Stok;

namespace Otomasyon.Fonksiyonlar
{
    class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool Secim = false)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public int StokGruplari(bool Secim = false)
        {
            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }
        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.frmStokKarti frm = new frmStokKarti();
            frm.ShowDialog();
        }
        public void StokHareketleri(bool Ac = false)
        {

        }
        #endregion

        #region Cari Formları
        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.frmCariGruplari frm = new frmCariGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.frmCariListesi frm = new frmCariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void CariAcilisKartı(bool Ac = false, int CariID = -1)
        {
            Modul_Cari.frmCariAcılısKarti frm = new frmCariAcılısKarti();
            if (Ac)
            {
                frm.Ac(CariID);
            }
            frm.ShowDialog();
        } 
        #endregion

        public void KasaAcilisKarti()
        {
            Modul_Kasa.frmKasaAcilisKarti frm = new frmKasaAcilisKarti();
            frm.ShowDialog();
        }

        public void KasaDevirIslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.frmKasaDevirIslemKarti frm = new frmKasaDevirIslemKarti();
            if (Ac)
            {
                frm.Ac(IslemID);
            }
            frm.ShowDialog();
        }

        public int KasaListesi(bool Secim = false)
        {
            Modul_Kasa.frmKasaListesi frm = new frmKasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void KasaTahsilatOdemeKarti(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmKasaTahsilatOdeme frm = new frmKasaTahsilatOdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
    }
}
