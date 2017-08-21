namespace Otomasyon.Modul_Banka
{
    partial class frmBankaListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaListesi));
            this.STOKBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // STOKBARKOD
            // 
            this.STOKBARKOD.Caption = "STOKBARKOD";
            this.STOKBARKOD.FieldName = "STOKBARKOD";
            this.STOKBARKOD.Name = "STOKBARKOD";
            this.STOKBARKOD.Visible = true;
            this.STOKBARKOD.VisibleIndex = 3;
            // 
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOKKODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 1;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(102, 209);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 50);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 209);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(86, 50);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(11, 160);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(193, 22);
            this.txtBarkod.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "IBAN";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(11, 99);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(193, 22);
            this.txtStokAdi.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.STOKBARKOD});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOKADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 2;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(638, 636);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hesap No";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(11, 39);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(193, 22);
            this.txtStokKodu.TabIndex = 1;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtBarkod);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(207, 602);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hesap Adı/Türü";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(858, 636);
            this.splitContainerControl1.SplitterPosition = 214;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(214, 636);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // frmBankaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 636);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Listesi";
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn STOKBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}