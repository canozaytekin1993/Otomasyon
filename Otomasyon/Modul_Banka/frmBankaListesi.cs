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

namespace Otomasyon.Modul_Banka
{
    public partial class frmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        private int SecimID = -1;
        public frmBankaListesi()
        {
            InitializeComponent();
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            
        }
    }
}