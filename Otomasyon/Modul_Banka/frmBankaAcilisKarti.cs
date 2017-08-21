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
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        private bool Edit = false;
        private int SecimID = -1;

        public frmBankaAcilisKarti()
        {
            InitializeComponent();
        }
    }
}