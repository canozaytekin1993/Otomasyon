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
    public partial class frmParaTransfer : DevExpress.XtraEditors.XtraForm
    {
        public frmParaTransfer()
        {
            InitializeComponent();
        }

        private string IslemTuru = "Banka Havalesi";

        private void txtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTuru.SelectedIndex == 0)
            {
                rbtGelen.Text = "Gelen Havale";
                rbtGiden.Text = "Giden Havale";
                IslemTuru = "Banka Havale";
            }
            else if (txtTransferTuru.SelectedIndex == 1)
            {
                rbtGelen.Text = "Gelen EFT";
                rbtGiden.Text = "Giden EFT";
                IslemTuru = "Banka EFT";
            }
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}