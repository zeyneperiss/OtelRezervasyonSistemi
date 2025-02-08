using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Yeni kontroller
        private TabControl tabControl1;
        private TextBox txtAd;
        private TextBox txtOdaNumarasi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnasayfa = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnRezervasyonİslemleri = new System.Windows.Forms.Button();
            this.btnOdaİslemleri = new System.Windows.Forms.Button();
            this.btnMusteriİslemleri = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.tabMusteri = new System.Windows.Forms.TabPage();
            this.btnToHomeMusteriler = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.grpMusteriListesi = new System.Windows.Forms.GroupBox();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.dgvMusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTCno = new System.Windows.Forms.Label();
            this.tabOda = new System.Windows.Forms.TabPage();
            this.btnToHomeOdalar = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.dgvOdalar = new System.Windows.Forms.DataGridView();
            this.OdaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOdaEkle = new System.Windows.Forms.GroupBox();
            this.btnOdaGuncelle = new System.Windows.Forms.Button();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.llblOdaTipi = new System.Windows.Forms.Label();
            this.lblOdaNumarasi = new System.Windows.Forms.Label();
            this.txtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.tabRezervasyon = new System.Windows.Forms.TabPage();
            this.btnToHomeRezervasyon = new System.Windows.Forms.Button();
            this.btnRezervasyonİptal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grpRezervasyonBilgileri = new System.Windows.Forms.GroupBox();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblOda = new System.Windows.Forms.Label();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.RezervasyonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFaturalar = new System.Windows.Forms.TabPage();
            this.btnToHomeFaturalar = new System.Windows.Forms.Button();
            this.dgvFaturalar = new System.Windows.Forms.DataGridView();
            this.colFaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdemeDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFaturalar = new System.Windows.Forms.GroupBox();
            this.lblSeciliRezervasyon = new System.Windows.Forms.Label();
            this.cmbRezervasyonlar = new System.Windows.Forms.ComboBox();
            this.btnFaturaOlustur = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAnasayfa.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            this.grpMusteriListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.tabOda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).BeginInit();
            this.grpOdaEkle.SuspendLayout();
            this.tabRezervasyon.SuspendLayout();
            this.grpRezervasyonBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.tabFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).BeginInit();
            this.grpFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnasayfa);
            this.tabControl1.Controls.Add(this.tabMusteri);
            this.tabControl1.Controls.Add(this.tabOda);
            this.tabControl1.Controls.Add(this.tabRezervasyon);
            this.tabControl1.Controls.Add(this.tabFaturalar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1518, 870);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnasayfa
            // 
            this.tabAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.tabAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabAnasayfa.Controls.Add(this.btnExit);
            this.tabAnasayfa.Controls.Add(this.pnlWelcome);
            this.tabAnasayfa.Controls.Add(this.btnFaturalar);
            this.tabAnasayfa.Controls.Add(this.btnRezervasyonİslemleri);
            this.tabAnasayfa.Controls.Add(this.btnOdaİslemleri);
            this.tabAnasayfa.Controls.Add(this.btnMusteriİslemleri);
            this.tabAnasayfa.Controls.Add(this.pnlSidebar);
            this.tabAnasayfa.Location = new System.Drawing.Point(4, 29);
            this.tabAnasayfa.Name = "tabAnasayfa";
            this.tabAnasayfa.Size = new System.Drawing.Size(1510, 837);
            this.tabAnasayfa.TabIndex = 4;
            this.tabAnasayfa.Text = "ANASAYFA";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(149)))), ((int)(((byte)(123)))));
            this.btnExit.Location = new System.Drawing.Point(1250, 700);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 100);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(185)))), ((int)(((byte)(203)))));
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(200, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(1310, 150);
            this.pnlWelcome.TabIndex = 5;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(177)))), ((int)(((byte)(153)))));
            this.lblWelcome.Location = new System.Drawing.Point(189, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(944, 67);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "KİDALYO BUTİK OTEL YÖNETİM SİSTEMİ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnFaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturalar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.btnFaturalar.Location = new System.Drawing.Point(800, 500);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(400, 100);
            this.btnFaturalar.TabIndex = 4;
            this.btnFaturalar.Text = "Faturalar";
            this.btnFaturalar.UseVisualStyleBackColor = false;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // btnRezervasyonİslemleri
            // 
            this.btnRezervasyonİslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnRezervasyonİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonİslemleri.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervasyonİslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.btnRezervasyonİslemleri.Location = new System.Drawing.Point(400, 500);
            this.btnRezervasyonİslemleri.Name = "btnRezervasyonİslemleri";
            this.btnRezervasyonİslemleri.Size = new System.Drawing.Size(400, 100);
            this.btnRezervasyonİslemleri.TabIndex = 3;
            this.btnRezervasyonİslemleri.Text = "Rezervasyon İşlemleri";
            this.btnRezervasyonİslemleri.UseVisualStyleBackColor = false;
            this.btnRezervasyonİslemleri.Click += new System.EventHandler(this.btnRezervasyonİslemleri_Click);
            // 
            // btnOdaİslemleri
            // 
            this.btnOdaİslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnOdaİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaİslemleri.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaİslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.btnOdaİslemleri.Location = new System.Drawing.Point(800, 300);
            this.btnOdaİslemleri.Name = "btnOdaİslemleri";
            this.btnOdaİslemleri.Size = new System.Drawing.Size(400, 100);
            this.btnOdaİslemleri.TabIndex = 2;
            this.btnOdaİslemleri.Text = "Oda İşlemleri";
            this.btnOdaİslemleri.UseVisualStyleBackColor = false;
            this.btnOdaİslemleri.Click += new System.EventHandler(this.btnOdaİslemleri_Click);
            // 
            // btnMusteriİslemleri
            // 
            this.btnMusteriİslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnMusteriİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriİslemleri.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriİslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.btnMusteriİslemleri.Location = new System.Drawing.Point(400, 300);
            this.btnMusteriİslemleri.Name = "btnMusteriİslemleri";
            this.btnMusteriİslemleri.Size = new System.Drawing.Size(400, 100);
            this.btnMusteriİslemleri.TabIndex = 1;
            this.btnMusteriİslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriİslemleri.UseVisualStyleBackColor = false;
            this.btnMusteriİslemleri.Click += new System.EventHandler(this.btnMusteriİslemleri_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(217)))));
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 837);
            this.pnlSidebar.TabIndex = 0;
            // 
            // tabMusteri
            // 
            this.tabMusteri.AutoScroll = true;
            this.tabMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.tabMusteri.Controls.Add(this.btnToHomeMusteriler);
            this.tabMusteri.Controls.Add(this.btnMusteriEkle);
            this.tabMusteri.Controls.Add(this.txtAd);
            this.tabMusteri.Controls.Add(this.grpMusteriListesi);
            this.tabMusteri.Controls.Add(this.lblEmail);
            this.tabMusteri.Controls.Add(this.lblAd);
            this.tabMusteri.Controls.Add(this.txtSoyad);
            this.tabMusteri.Controls.Add(this.txtEmail);
            this.tabMusteri.Controls.Add(this.lblTelefon);
            this.tabMusteri.Controls.Add(this.lblSoyad);
            this.tabMusteri.Controls.Add(this.txtTCNo);
            this.tabMusteri.Controls.Add(this.txtTelefon);
            this.tabMusteri.Controls.Add(this.lblTCno);
            this.tabMusteri.Location = new System.Drawing.Point(4, 29);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.Size = new System.Drawing.Size(1510, 837);
            this.tabMusteri.TabIndex = 0;
            this.tabMusteri.Text = "Müşteri İşlemleri";
            // 
            // btnToHomeMusteriler
            // 
            this.btnToHomeMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnToHomeMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHomeMusteriler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHomeMusteriler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.btnToHomeMusteriler.Location = new System.Drawing.Point(20, 20);
            this.btnToHomeMusteriler.Name = "btnToHomeMusteriler";
            this.btnToHomeMusteriler.Size = new System.Drawing.Size(212, 75);
            this.btnToHomeMusteriler.TabIndex = 13;
            this.btnToHomeMusteriler.Text = "Anasayfaya Dön";
            this.btnToHomeMusteriler.UseVisualStyleBackColor = false;
            this.btnToHomeMusteriler.Click += new System.EventHandler(this.btnToHomeMusteriler_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(181)))));
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Location = new System.Drawing.Point(358, 512);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(174, 69);
            this.btnMusteriEkle.TabIndex = 11;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.txtAd.Location = new System.Drawing.Point(334, 225);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(130, 26);
            this.txtAd.TabIndex = 1;
            // 
            // grpMusteriListesi
            // 
            this.grpMusteriListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpMusteriListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpMusteriListesi.Controls.Add(this.dgvMusteriler);
            this.grpMusteriListesi.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMusteriListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMusteriListesi.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMusteriListesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.grpMusteriListesi.Location = new System.Drawing.Point(636, 0);
            this.grpMusteriListesi.Name = "grpMusteriListesi";
            this.grpMusteriListesi.Size = new System.Drawing.Size(874, 837);
            this.grpMusteriListesi.TabIndex = 12;
            this.grpMusteriListesi.TabStop = false;
            this.grpMusteriListesi.Text = "Müşteriler";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(208)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMusteriID,
            this.dgvAdi,
            this.dgvSoyad,
            this.dgvTcNo,
            this.dgvTelefon,
            this.dgvEmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusteriler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvMusteriler.Location = new System.Drawing.Point(25, 278);
            this.dgvMusteriler.Name = "dgvMusteriler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMusteriler.RowHeadersWidth = 62;
            this.dgvMusteriler.RowTemplate.Height = 28;
            this.dgvMusteriler.Size = new System.Drawing.Size(815, 489);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // dgvMusteriID
            // 
            this.dgvMusteriID.DataPropertyName = "dgvMusteriID";
            this.dgvMusteriID.HeaderText = "Müşteri ID";
            this.dgvMusteriID.MinimumWidth = 8;
            this.dgvMusteriID.Name = "dgvMusteriID";
            this.dgvMusteriID.Visible = false;
            this.dgvMusteriID.Width = 150;
            // 
            // dgvAdi
            // 
            this.dgvAdi.DataPropertyName = "dgvAdi";
            this.dgvAdi.HeaderText = "Ad";
            this.dgvAdi.MinimumWidth = 8;
            this.dgvAdi.Name = "dgvAdi";
            this.dgvAdi.Width = 150;
            // 
            // dgvSoyad
            // 
            this.dgvSoyad.DataPropertyName = "dgvSoyad";
            this.dgvSoyad.HeaderText = "Soyad";
            this.dgvSoyad.MinimumWidth = 8;
            this.dgvSoyad.Name = "dgvSoyad";
            this.dgvSoyad.Width = 150;
            // 
            // dgvTcNo
            // 
            this.dgvTcNo.DataPropertyName = "dgvTcNo";
            this.dgvTcNo.HeaderText = "TC No";
            this.dgvTcNo.MinimumWidth = 8;
            this.dgvTcNo.Name = "dgvTcNo";
            this.dgvTcNo.Width = 150;
            // 
            // dgvTelefon
            // 
            this.dgvTelefon.DataPropertyName = "dgvTelefon";
            this.dgvTelefon.HeaderText = "Telefon";
            this.dgvTelefon.MinimumWidth = 8;
            this.dgvTelefon.Name = "dgvTelefon";
            this.dgvTelefon.Width = 150;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "dgvEmail";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 8;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Width = 150;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(189, 445);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 40);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.lblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(189, 217);
            this.lblAd.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(130, 40);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Ad";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.txtSoyad.Location = new System.Drawing.Point(334, 278);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(130, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.txtEmail.Location = new System.Drawing.Point(334, 458);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblTelefon
            // 
            this.lblTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.lblTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefon.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(189, 389);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(130, 40);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.lblSoyad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(189, 270);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(130, 40);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTCNo
            // 
            this.txtTCNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.txtTCNo.Location = new System.Drawing.Point(334, 336);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(130, 26);
            this.txtTCNo.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.txtTelefon.Location = new System.Drawing.Point(334, 394);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(130, 26);
            this.txtTelefon.TabIndex = 4;
            // 
            // lblTCno
            // 
            this.lblTCno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.lblTCno.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCno.Location = new System.Drawing.Point(189, 330);
            this.lblTCno.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblTCno.Name = "lblTCno";
            this.lblTCno.Size = new System.Drawing.Size(130, 40);
            this.lblTCno.TabIndex = 8;
            this.lblTCno.Text = "TC No";
            this.lblTCno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabOda
            // 
            this.tabOda.AutoScroll = true;
            this.tabOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(194)))));
            this.tabOda.Controls.Add(this.btnToHomeOdalar);
            this.tabOda.Controls.Add(this.dgvOdalar);
            this.tabOda.Controls.Add(this.grpOdaEkle);
            this.tabOda.Location = new System.Drawing.Point(4, 29);
            this.tabOda.Name = "tabOda";
            this.tabOda.Size = new System.Drawing.Size(1510, 837);
            this.tabOda.TabIndex = 1;
            this.tabOda.Text = "Oda İşlemleri";
            // 
            // btnToHomeOdalar
            // 
            this.btnToHomeOdalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnToHomeOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHomeOdalar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHomeOdalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.btnToHomeOdalar.Location = new System.Drawing.Point(1272, 28);
            this.btnToHomeOdalar.Name = "btnToHomeOdalar";
            this.btnToHomeOdalar.Size = new System.Drawing.Size(217, 67);
            this.btnToHomeOdalar.TabIndex = 14;
            this.btnToHomeOdalar.Text = "Anasayfaya Dön";
            this.btnToHomeOdalar.UseVisualStyleBackColor = false;
            this.btnToHomeOdalar.Click += new System.EventHandler(this.btnToHomeOdalar_Click);
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.btnOdaSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdaSil.Location = new System.Drawing.Point(192, 284);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(165, 50);
            this.btnOdaSil.TabIndex = 4;
            this.btnOdaSil.Text = "Oda Sil";
            this.btnOdaSil.UseVisualStyleBackColor = false;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click_1);
            // 
            // dgvOdalar
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOdalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOdalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.dgvOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdaID,
            this.OdaNumarasi,
            this.OdaTipi,
            this.Fiyat,
            this.Durum});
            this.dgvOdalar.Location = new System.Drawing.Point(129, 368);
            this.dgvOdalar.MultiSelect = false;
            this.dgvOdalar.Name = "dgvOdalar";
            this.dgvOdalar.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOdalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOdalar.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(90)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(191)))));
            this.dgvOdalar.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOdalar.RowTemplate.Height = 28;
            this.dgvOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdalar.Size = new System.Drawing.Size(1212, 431);
            this.dgvOdalar.TabIndex = 3;
            this.dgvOdalar.SelectionChanged += new System.EventHandler(this.dgvOdalar_SelectionChanged);
            // 
            // OdaID
            // 
            this.OdaID.HeaderText = "Oda ID";
            this.OdaID.MinimumWidth = 8;
            this.OdaID.Name = "OdaID";
            this.OdaID.ReadOnly = true;
            this.OdaID.Visible = false;
            this.OdaID.Width = 150;
            // 
            // OdaNumarasi
            // 
            this.OdaNumarasi.HeaderText = "Oda No";
            this.OdaNumarasi.MinimumWidth = 8;
            this.OdaNumarasi.Name = "OdaNumarasi";
            this.OdaNumarasi.ReadOnly = true;
            this.OdaNumarasi.Width = 362;
            // 
            // OdaTipi
            // 
            this.OdaTipi.HeaderText = "Oda Tipi";
            this.OdaTipi.MinimumWidth = 8;
            this.OdaTipi.Name = "OdaTipi";
            this.OdaTipi.ReadOnly = true;
            this.OdaTipi.Width = 361;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat TL";
            this.Fiyat.MinimumWidth = 8;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Width = 362;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Müsait";
            this.Durum.MinimumWidth = 8;
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Width = 361;
            // 
            // grpOdaEkle
            // 
            this.grpOdaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.grpOdaEkle.Controls.Add(this.btnOdaGuncelle);
            this.grpOdaEkle.Controls.Add(this.btnOdaSil);
            this.grpOdaEkle.Controls.Add(this.btnOdaEkle);
            this.grpOdaEkle.Controls.Add(this.txtFiyat);
            this.grpOdaEkle.Controls.Add(this.lblFiyat);
            this.grpOdaEkle.Controls.Add(this.cmbOdaTipi);
            this.grpOdaEkle.Controls.Add(this.llblOdaTipi);
            this.grpOdaEkle.Controls.Add(this.lblOdaNumarasi);
            this.grpOdaEkle.Controls.Add(this.txtOdaNumarasi);
            this.grpOdaEkle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOdaEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.grpOdaEkle.Location = new System.Drawing.Point(397, 28);
            this.grpOdaEkle.Name = "grpOdaEkle";
            this.grpOdaEkle.Size = new System.Drawing.Size(616, 357);
            this.grpOdaEkle.TabIndex = 2;
            this.grpOdaEkle.TabStop = false;
            this.grpOdaEkle.Text = "Oda Bilgileri";
            // 
            // btnOdaGuncelle
            // 
            this.btnOdaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.btnOdaGuncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdaGuncelle.Location = new System.Drawing.Point(45, 228);
            this.btnOdaGuncelle.Name = "btnOdaGuncelle";
            this.btnOdaGuncelle.Size = new System.Drawing.Size(165, 50);
            this.btnOdaGuncelle.TabIndex = 5;
            this.btnOdaGuncelle.Text = "Güncelle";
            this.btnOdaGuncelle.UseVisualStyleBackColor = false;
            this.btnOdaGuncelle.Click += new System.EventHandler(this.btnOdaGuncelle_Click);
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.btnOdaEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdaEkle.Location = new System.Drawing.Point(337, 228);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(165, 50);
            this.btnOdaEkle.TabIndex = 7;
            this.btnOdaEkle.Text = "Oda Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = false;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click_1);
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(194)))));
            this.txtFiyat.Location = new System.Drawing.Point(337, 159);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(150, 32);
            this.txtFiyat.TabIndex = 6;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.lblFiyat.Location = new System.Drawing.Point(37, 137);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(101, 44);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(194)))));
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Items.AddRange(new object[] {
            "Standart",
            "Suit",
            "Deluxe"});
            this.cmbOdaTipi.Location = new System.Drawing.Point(337, 97);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(150, 32);
            this.cmbOdaTipi.TabIndex = 4;
            // 
            // llblOdaTipi
            // 
            this.llblOdaTipi.AutoSize = true;
            this.llblOdaTipi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblOdaTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.llblOdaTipi.Location = new System.Drawing.Point(37, 85);
            this.llblOdaTipi.Name = "llblOdaTipi";
            this.llblOdaTipi.Size = new System.Drawing.Size(153, 44);
            this.llblOdaTipi.TabIndex = 3;
            this.llblOdaTipi.Text = "Oda Tipi:";
            // 
            // lblOdaNumarasi
            // 
            this.lblOdaNumarasi.AutoSize = true;
            this.lblOdaNumarasi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaNumarasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.lblOdaNumarasi.Location = new System.Drawing.Point(37, 33);
            this.lblOdaNumarasi.Name = "lblOdaNumarasi";
            this.lblOdaNumarasi.Size = new System.Drawing.Size(241, 44);
            this.lblOdaNumarasi.TabIndex = 3;
            this.lblOdaNumarasi.Text = "Oda Numarası:";
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(194)))));
            this.txtOdaNumarasi.Location = new System.Drawing.Point(337, 45);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(140, 32);
            this.txtOdaNumarasi.TabIndex = 1;
            // 
            // tabRezervasyon
            // 
            this.tabRezervasyon.AutoScroll = true;
            this.tabRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(93)))), ((int)(((byte)(105)))));
            this.tabRezervasyon.Controls.Add(this.btnToHomeRezervasyon);
            this.tabRezervasyon.Controls.Add(this.label12);
            this.tabRezervasyon.Controls.Add(this.grpRezervasyonBilgileri);
            this.tabRezervasyon.Controls.Add(this.dgvRezervasyonlar);
            this.tabRezervasyon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(93)))), ((int)(((byte)(105)))));
            this.tabRezervasyon.Location = new System.Drawing.Point(4, 29);
            this.tabRezervasyon.Name = "tabRezervasyon";
            this.tabRezervasyon.Size = new System.Drawing.Size(1510, 837);
            this.tabRezervasyon.TabIndex = 2;
            this.tabRezervasyon.Text = "Rezervasyon İşlemleri";
            // 
            // btnToHomeRezervasyon
            // 
            this.btnToHomeRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnToHomeRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHomeRezervasyon.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHomeRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.btnToHomeRezervasyon.Location = new System.Drawing.Point(1264, 20);
            this.btnToHomeRezervasyon.Name = "btnToHomeRezervasyon";
            this.btnToHomeRezervasyon.Size = new System.Drawing.Size(223, 87);
            this.btnToHomeRezervasyon.TabIndex = 14;
            this.btnToHomeRezervasyon.Text = "Anasayfaya Dön";
            this.btnToHomeRezervasyon.UseVisualStyleBackColor = false;
            this.btnToHomeRezervasyon.Click += new System.EventHandler(this.btnToHomeRezervasyon_Click);
            // 
            // btnRezervasyonİptal
            // 
            this.btnRezervasyonİptal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRezervasyonİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRezervasyonİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonİptal.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervasyonİptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.btnRezervasyonİptal.Location = new System.Drawing.Point(18, 373);
            this.btnRezervasyonİptal.Name = "btnRezervasyonİptal";
            this.btnRezervasyonİptal.Size = new System.Drawing.Size(338, 72);
            this.btnRezervasyonİptal.TabIndex = 8;
            this.btnRezervasyonİptal.Text = "Rezervasyon İptal";
            this.btnRezervasyonİptal.UseVisualStyleBackColor = false;
            this.btnRezervasyonİptal.Click += new System.EventHandler(this.btnRezervasyonİptal_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // grpRezervasyonBilgileri
            // 
            this.grpRezervasyonBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.grpRezervasyonBilgileri.Controls.Add(this.lblCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.btnRezervasyonİptal);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblGirisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.btnRezervasyonYap);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblMusteri);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbOdalar);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbMusteriler);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblOda);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpGirisTarihi);
            this.grpRezervasyonBilgileri.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRezervasyonBilgileri.Location = new System.Drawing.Point(20, 20);
            this.grpRezervasyonBilgileri.Name = "grpRezervasyonBilgileri";
            this.grpRezervasyonBilgileri.Size = new System.Drawing.Size(753, 465);
            this.grpRezervasyonBilgileri.TabIndex = 9;
            this.grpRezervasyonBilgileri.TabStop = false;
            this.grpRezervasyonBilgileri.Text = "Rezervasyon Bilgileri";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCikisTarihi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCikisTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCikisTarihi.Location = new System.Drawing.Point(149, 259);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(190, 85);
            this.lblCikisTarihi.TabIndex = 13;
            this.lblCikisTarihi.Text = "Çıkış Tarihi";
            this.lblCikisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGirisTarihi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblGirisTarihi.Location = new System.Drawing.Point(149, 190);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(190, 85);
            this.lblGirisTarihi.TabIndex = 12;
            this.lblGirisTarihi.Text = "Giriş Tarihi";
            this.lblGirisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusteri
            // 
            this.lblMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMusteri.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMusteri.Location = new System.Drawing.Point(149, 130);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(190, 85);
            this.lblMusteri.TabIndex = 10;
            this.lblMusteri.Text = "Müşteri";
            this.lblMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMusteri.Click += new System.EventHandler(this.lblMusteri_Click);
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(467, 81);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(121, 43);
            this.cmbOdalar.TabIndex = 6;
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(467, 147);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(135, 43);
            this.cmbMusteriler.TabIndex = 7;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(467, 280);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 42);
            this.dtpCikisTarihi.TabIndex = 5;
            // 
            // lblOda
            // 
            this.lblOda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOda.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblOda.Location = new System.Drawing.Point(149, 64);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(190, 85);
            this.lblOda.TabIndex = 11;
            this.lblOda.Text = "Oda";
            this.lblOda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(467, 211);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 42);
            this.dtpGirisTarihi.TabIndex = 4;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.btnRezervasyonYap.Location = new System.Drawing.Point(389, 373);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(338, 72);
            this.btnRezervasyonYap.TabIndex = 8;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // dgvRezervasyonlar
            // 
            this.dgvRezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervasyonlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervasyonId,
            this.Musteri,
            this.Oda,
            this.girisTarihi,
            this.cikisTarihi,
            this.rezervasyonDurum});
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(303, 461);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.ReadOnly = true;
            this.dgvRezervasyonlar.RowHeadersVisible = false;
            this.dgvRezervasyonlar.RowHeadersWidth = 62;
            this.dgvRezervasyonlar.RowTemplate.Height = 28;
            this.dgvRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(1070, 368);
            this.dgvRezervasyonlar.TabIndex = 2;
            this.dgvRezervasyonlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervasyonlar_CellContentClick);
            // 
            // RezervasyonId
            // 
            this.RezervasyonId.HeaderText = "Rezervasyon ID";
            this.RezervasyonId.MinimumWidth = 8;
            this.RezervasyonId.Name = "RezervasyonId";
            this.RezervasyonId.ReadOnly = true;
            this.RezervasyonId.Visible = false;
            // 
            // Musteri
            // 
            this.Musteri.FillWeight = 4.172127F;
            this.Musteri.HeaderText = "Müşteri";
            this.Musteri.MinimumWidth = 8;
            this.Musteri.Name = "Musteri";
            this.Musteri.ReadOnly = true;
            // 
            // Oda
            // 
            this.Oda.FillWeight = 9.625481F;
            this.Oda.HeaderText = "Oda";
            this.Oda.MinimumWidth = 8;
            this.Oda.Name = "Oda";
            this.Oda.ReadOnly = true;
            // 
            // girisTarihi
            // 
            this.girisTarihi.FillWeight = 75.30232F;
            this.girisTarihi.HeaderText = "Giriş Tarihi";
            this.girisTarihi.MinimumWidth = 8;
            this.girisTarihi.Name = "girisTarihi";
            this.girisTarihi.ReadOnly = true;
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.FillWeight = 409.0909F;
            this.cikisTarihi.HeaderText = "Çıkkış Tarihi";
            this.cikisTarihi.MinimumWidth = 8;
            this.cikisTarihi.Name = "cikisTarihi";
            this.cikisTarihi.ReadOnly = true;
            // 
            // rezervasyonDurum
            // 
            this.rezervasyonDurum.FillWeight = 1.809185F;
            this.rezervasyonDurum.HeaderText = "Durum";
            this.rezervasyonDurum.MinimumWidth = 8;
            this.rezervasyonDurum.Name = "rezervasyonDurum";
            this.rezervasyonDurum.ReadOnly = true;
            // 
            // tabFaturalar
            // 
            this.tabFaturalar.AutoScroll = true;
            this.tabFaturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabFaturalar.Controls.Add(this.btnToHomeFaturalar);
            this.tabFaturalar.Controls.Add(this.dgvFaturalar);
            this.tabFaturalar.Controls.Add(this.grpFaturalar);
            this.tabFaturalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(168)))), ((int)(((byte)(136)))));
            this.tabFaturalar.Location = new System.Drawing.Point(4, 29);
            this.tabFaturalar.Name = "tabFaturalar";
            this.tabFaturalar.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaturalar.Size = new System.Drawing.Size(1510, 837);
            this.tabFaturalar.TabIndex = 3;
            this.tabFaturalar.Text = "Faturalar";
            // 
            // btnToHomeFaturalar
            // 
            this.btnToHomeFaturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnToHomeFaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHomeFaturalar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHomeFaturalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.btnToHomeFaturalar.Location = new System.Drawing.Point(21, 22);
            this.btnToHomeFaturalar.Name = "btnToHomeFaturalar";
            this.btnToHomeFaturalar.Size = new System.Drawing.Size(199, 73);
            this.btnToHomeFaturalar.TabIndex = 14;
            this.btnToHomeFaturalar.Text = "Anasayfaya Dön";
            this.btnToHomeFaturalar.UseVisualStyleBackColor = false;
            this.btnToHomeFaturalar.Click += new System.EventHandler(this.btnToHomeFaturalar_Click);
            // 
            // dgvFaturalar
            // 
            this.dgvFaturalar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvFaturalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(233)))));
            this.dgvFaturalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFaturaID,
            this.colMusteriAdi,
            this.ColOdaNo,
            this.colGirisTarihi,
            this.colCikisTarihi,
            this.ToplamTutar,
            this.colOdemeDurumu});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(168)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(185)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturalar.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFaturalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(212)))));
            this.dgvFaturalar.Location = new System.Drawing.Point(331, 425);
            this.dgvFaturalar.MultiSelect = false;
            this.dgvFaturalar.Name = "dgvFaturalar";
            this.dgvFaturalar.ReadOnly = true;
            this.dgvFaturalar.RowHeadersVisible = false;
            this.dgvFaturalar.RowHeadersWidth = 62;
            this.dgvFaturalar.RowTemplate.Height = 28;
            this.dgvFaturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturalar.Size = new System.Drawing.Size(956, 361);
            this.dgvFaturalar.TabIndex = 1;
            // 
            // colFaturaID
            // 
            this.colFaturaID.DataPropertyName = "FaturaID";
            this.colFaturaID.HeaderText = "Fatura No";
            this.colFaturaID.MinimumWidth = 8;
            this.colFaturaID.Name = "colFaturaID";
            this.colFaturaID.ReadOnly = true;
            this.colFaturaID.Width = 150;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.DataPropertyName = "MusteriAdi";
            this.colMusteriAdi.HeaderText = "Müşteri Adı";
            this.colMusteriAdi.MinimumWidth = 8;
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.ReadOnly = true;
            this.colMusteriAdi.Width = 150;
            // 
            // ColOdaNo
            // 
            this.ColOdaNo.DataPropertyName = "OdaNumarasi";
            this.ColOdaNo.HeaderText = "Oda No";
            this.ColOdaNo.MinimumWidth = 8;
            this.ColOdaNo.Name = "ColOdaNo";
            this.ColOdaNo.ReadOnly = true;
            this.ColOdaNo.Width = 80;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.DataPropertyName = "GirisTarihi";
            this.colGirisTarihi.HeaderText = "Giriş Tarihi";
            this.colGirisTarihi.MinimumWidth = 8;
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.ReadOnly = true;
            this.colGirisTarihi.Width = 150;
            // 
            // colCikisTarihi
            // 
            this.colCikisTarihi.DataPropertyName = "CikisTarihi";
            this.colCikisTarihi.HeaderText = "Çıkış Tarihi";
            this.colCikisTarihi.MinimumWidth = 8;
            this.colCikisTarihi.Name = "colCikisTarihi";
            this.colCikisTarihi.ReadOnly = true;
            this.colCikisTarihi.Width = 150;
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.DataPropertyName = "ToplamTutar";
            this.ToplamTutar.HeaderText = "Toplam Tutar";
            this.ToplamTutar.MinimumWidth = 8;
            this.ToplamTutar.Name = "ToplamTutar";
            this.ToplamTutar.ReadOnly = true;
            this.ToplamTutar.Width = 150;
            // 
            // colOdemeDurumu
            // 
            this.colOdemeDurumu.DataPropertyName = "OdemeDurumu";
            this.colOdemeDurumu.HeaderText = "Ödeme Durumu";
            this.colOdemeDurumu.MinimumWidth = 8;
            this.colOdemeDurumu.Name = "colOdemeDurumu";
            this.colOdemeDurumu.ReadOnly = true;
            this.colOdemeDurumu.Width = 120;
            // 
            // grpFaturalar
            // 
            this.grpFaturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.grpFaturalar.Controls.Add(this.lblSeciliRezervasyon);
            this.grpFaturalar.Controls.Add(this.cmbRezervasyonlar);
            this.grpFaturalar.Controls.Add(this.btnFaturaOlustur);
            this.grpFaturalar.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFaturalar.Location = new System.Drawing.Point(378, 22);
            this.grpFaturalar.Name = "grpFaturalar";
            this.grpFaturalar.Size = new System.Drawing.Size(750, 378);
            this.grpFaturalar.TabIndex = 0;
            this.grpFaturalar.TabStop = false;
            this.grpFaturalar.Text = "Fatura Bilgileri";
            // 
            // lblSeciliRezervasyon
            // 
            this.lblSeciliRezervasyon.AutoSize = true;
            this.lblSeciliRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSeciliRezervasyon.Location = new System.Drawing.Point(43, 90);
            this.lblSeciliRezervasyon.Name = "lblSeciliRezervasyon";
            this.lblSeciliRezervasyon.Size = new System.Drawing.Size(258, 39);
            this.lblSeciliRezervasyon.TabIndex = 4;
            this.lblSeciliRezervasyon.Text = "Seçili Rezervasyon";
            // 
            // cmbRezervasyonlar
            // 
            this.cmbRezervasyonlar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbRezervasyonlar.FormattingEnabled = true;
            this.cmbRezervasyonlar.Location = new System.Drawing.Point(343, 90);
            this.cmbRezervasyonlar.Name = "cmbRezervasyonlar";
            this.cmbRezervasyonlar.Size = new System.Drawing.Size(121, 47);
            this.cmbRezervasyonlar.TabIndex = 3;
            // 
            // btnFaturaOlustur
            // 
            this.btnFaturaOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.btnFaturaOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaOlustur.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnFaturaOlustur.Location = new System.Drawing.Point(380, 229);
            this.btnFaturaOlustur.Name = "btnFaturaOlustur";
            this.btnFaturaOlustur.Size = new System.Drawing.Size(237, 67);
            this.btnFaturaOlustur.TabIndex = 2;
            this.btnFaturaOlustur.Text = "Fatura Oluştur";
            this.btnFaturaOlustur.UseVisualStyleBackColor = false;
            this.btnFaturaOlustur.Click += new System.EventHandler(this.btnFaturaOlustur_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1518, 870);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAnasayfa.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.tabMusteri.ResumeLayout(false);
            this.tabMusteri.PerformLayout();
            this.grpMusteriListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.tabOda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).EndInit();
            this.grpOdaEkle.ResumeLayout(false);
            this.grpOdaEkle.PerformLayout();
            this.tabRezervasyon.ResumeLayout(false);
            this.grpRezervasyonBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.tabFaturalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).EndInit();
            this.grpFaturalar.ResumeLayout(false);
            this.grpFaturalar.PerformLayout();
            this.ResumeLayout(false);

        }

        private TabPage tabMusteri;
        private TabPage tabOda;
        private TabPage tabRezervasyon;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtSoyad;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox txtTCNo;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblEmail;
        private Label lblTelefon;
        private Label lblTCno;
        private Button btnMusteriEkle;
        private GroupBox grpOdaEkle;
        private Label lblOdaNumarasi;
        private ComboBox cmbOdaTipi;
        private Label llblOdaTipi;
        private Label lblFiyat;
        private Button btnOdaEkle;
        private TextBox txtFiyat;
        private DataGridView dgvOdalar;
        private DataGridViewTextBoxColumn OdaID;
        private DataGridViewTextBoxColumn OdaNumarasi;
        private DataGridViewTextBoxColumn OdaTipi;
        private DataGridViewTextBoxColumn Fiyat;
        private DataGridViewTextBoxColumn Durum;
        private Button btnOdaSil;
        private Button btnOdaGuncelle;
        private DataGridView dgvRezervasyonlar;
        private DateTimePicker dtpCikisTarihi;
        private DateTimePicker dtpGirisTarihi;
        private ComboBox cmbOdalar;
        private ComboBox cmbMusteriler;
        private Button btnRezervasyonYap;
        private GroupBox grpRezervasyonBilgileri;
        private DataGridViewTextBoxColumn RezervasyonId;
        private DataGridViewTextBoxColumn Musteri;
        private DataGridViewTextBoxColumn Oda;
        private DataGridViewTextBoxColumn girisTarihi;
        private DataGridViewTextBoxColumn cikisTarihi;
        private DataGridViewTextBoxColumn rezervasyonDurum;
        private Label label12;
        private Label lblGirisTarihi;
        private Label lblOda;
        private Label lblMusteri;
        private Label lblCikisTarihi;
        private Button btnRezervasyonİptal;
        private TabPage tabFaturalar;
        private GroupBox grpFaturalar;
        private Button btnFaturaOlustur;
        private DataGridView dgvFaturalar;
        private ComboBox cmbRezervasyonlar;
        private Label lblSeciliRezervasyon;
        private DataGridViewTextBoxColumn colFaturaID;
        private DataGridViewTextBoxColumn colMusteriAdi;
        private DataGridViewTextBoxColumn ColOdaNo;
        private DataGridViewTextBoxColumn colGirisTarihi;
        private DataGridViewTextBoxColumn colCikisTarihi;
        private DataGridViewTextBoxColumn ToplamTutar;
        private DataGridViewTextBoxColumn colOdemeDurumu;
        private TabPage tabAnasayfa;
        private Panel pnlSidebar;
        private Button btnFaturalar;
        private Button btnRezervasyonİslemleri;
        private Button btnOdaİslemleri;
        private Button btnMusteriİslemleri;
        private Panel pnlWelcome;
        private Label lblWelcome;
        private Button btnExit;
        private GroupBox grpMusteriListesi;
        private DataGridView dgvMusteriler;
        private DataGridViewTextBoxColumn dgvMusteriID;
        private DataGridViewTextBoxColumn dgvAdi;
        private DataGridViewTextBoxColumn dgvSoyad;
        private DataGridViewTextBoxColumn dgvTcNo;
        private DataGridViewTextBoxColumn dgvTelefon;
        private DataGridViewTextBoxColumn dgvEmail;
        private Button btnToHomeMusteriler;
        private Button btnToHomeOdalar;
        private Button btnToHomeRezervasyon;
        private Button btnToHomeFaturalar;
        //private Panel pnlSidebar;
    }
}
