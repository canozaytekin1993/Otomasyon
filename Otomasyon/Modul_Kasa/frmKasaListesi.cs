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
    public partial class frmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        private Fonksiyonlar.DatabaseDataContext DB = new DatabaseDataContext();

        public bool Secim = false;
        private int SecimID = -1;

        public frmKasaListesi()
        {
            InitializeComponent();
        }
        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KASALARs where s.KASAKODU.Contains(txtKasaKodu.Text) && s.KASAADI.Contains(txtKasaAdi.Text) select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception e)
            {
                SecimID = -1;
            }
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