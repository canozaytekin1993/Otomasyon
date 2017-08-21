using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Otomasyon.Fonksiyonlar;

namespace Otomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public static int UserID = -1;
        public static int Aktarma = -1;

        Fonksiyonlar.Formlar Formlar = new Formlar();

        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barBtnStokGrupları_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void barBtnCariAcilis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKartı();
        }

        private void barBtnCariGrupları_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();}

        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void barBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

         }

        private void barBtnKasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void barBtnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void barBtnKasaDevir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void barBtnKasaTahsilat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }
    }
}