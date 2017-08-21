namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaDevirIslemKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaDevirIslemKarti));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtnCıkıs = new System.Windows.Forms.RadioButton();
            this.rbtnGiris = new System.Windows.Forms.RadioButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtKasaAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKasaBelgeNo = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaBelgeNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 136);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Açıklama:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(119, 64);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(209, 22);
            this.txtTutar.TabIndex = 13;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 67);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 16);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Tutar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(35, 16);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Tarih:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 133);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(209, 107);
            this.txtAciklama.TabIndex = 17;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(223, 33);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(104, 51);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btnKaydet.Location = new System.Drawing.Point(3, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 51);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(113, 33);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 51);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnKapat);
            this.groupControl3.Controls.Add(this.btnKaydet);
            this.groupControl3.Controls.Add(this.btnSil);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 254);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(334, 94);
            this.groupControl3.TabIndex = 27;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtnCıkıs);
            this.groupControl2.Controls.Add(this.rbtnGiris);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtTarih);
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 135);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(338, 350);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "İşlem Bilgileri";
            // 
            // rbtnCıkıs
            // 
            this.rbtnCıkıs.AutoSize = true;
            this.rbtnCıkıs.Location = new System.Drawing.Point(237, 97);
            this.rbtnCıkıs.Name = "rbtnCıkıs";
            this.rbtnCıkıs.Size = new System.Drawing.Size(92, 21);
            this.rbtnCıkıs.TabIndex = 30;
            this.rbtnCıkıs.Text = "Çıkış İşlemi";
            this.rbtnCıkıs.UseVisualStyleBackColor = true;
            // 
            // rbtnGiris
            // 
            this.rbtnGiris.AutoSize = true;
            this.rbtnGiris.Checked = true;
            this.rbtnGiris.Location = new System.Drawing.Point(120, 100);
            this.rbtnGiris.Name = "rbtnGiris";
            this.rbtnGiris.Size = new System.Drawing.Size(90, 21);
            this.rbtnGiris.TabIndex = 29;
            this.rbtnGiris.TabStop = true;
            this.rbtnGiris.Text = "Giriş İşlemi";
            this.rbtnGiris.UseVisualStyleBackColor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 102);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 16);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "İşlem Türü:";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(120, 35);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(208, 22);
            this.txtTarih.TabIndex = 11;
            // 
            // txtKasaAdı
            // 
            this.txtKasaAdı.Location = new System.Drawing.Point(120, 101);
            this.txtKasaAdı.Name = "txtKasaAdı";
            this.txtKasaAdı.Properties.ReadOnly = true;
            this.txtKasaAdı.Size = new System.Drawing.Size(208, 22);
            this.txtKasaAdı.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Kasa Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kasa Kodu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Belge/Makbuz No:";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(120, 66);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(208, 22);
            this.txtKasaKodu.TabIndex = 3;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtKasaAdı);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.txtKasaBelgeNo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(338, 135);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa/Cari Bilgileri";
            // 
            // txtKasaBelgeNo
            // 
            this.txtKasaBelgeNo.Location = new System.Drawing.Point(120, 36);
            this.txtKasaBelgeNo.Name = "txtKasaBelgeNo";
            this.txtKasaBelgeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaBelgeNo.Size = new System.Drawing.Size(208, 22);
            this.txtKasaBelgeNo.TabIndex = 1;
            this.txtKasaBelgeNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaBelgeNo_ButtonClick);
            // 
            // frmKasaDevirIslemKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 485);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaDevirIslemKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Devir İşlemi";
            this.Load += new System.EventHandler(this.frmKasaDevirIslemKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaBelgeNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rbtnCıkıs;
        private System.Windows.Forms.RadioButton rbtnGiris;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtKasaAdı;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txtKasaBelgeNo;
    }
}