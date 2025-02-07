using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Yeni kontroller
        private TabControl tabFaturalar;
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
            this.tabFaturalar = new System.Windows.Forms.TabControl();
            this.tabMusteri = new System.Windows.Forms.TabPage();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabOda = new System.Windows.Forms.TabPage();
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.tabRezervasyon = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvFaturalar = new System.Windows.Forms.DataGridView();
            this.grpFaturalar = new System.Windows.Forms.GroupBox();
            this.lblSeciliRezervasyon = new System.Windows.Forms.Label();
            this.cmbRezervasyonlar = new System.Windows.Forms.ComboBox();
            this.btnFaturaOlustur = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colFaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdemeDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFaturalar.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            this.tabOda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).BeginInit();
            this.grpOdaEkle.SuspendLayout();
            this.tabRezervasyon.SuspendLayout();
            this.grpRezervasyonBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).BeginInit();
            this.grpFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFaturalar
            // 
            this.tabFaturalar.Controls.Add(this.tabMusteri);
            this.tabFaturalar.Controls.Add(this.tabOda);
            this.tabFaturalar.Controls.Add(this.tabRezervasyon);
            this.tabFaturalar.Controls.Add(this.tabPage1);
            this.tabFaturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFaturalar.Location = new System.Drawing.Point(0, 0);
            this.tabFaturalar.Name = "tabFaturalar";
            this.tabFaturalar.SelectedIndex = 0;
            this.tabFaturalar.Size = new System.Drawing.Size(1086, 662);
            this.tabFaturalar.TabIndex = 0;
            // 
            // tabMusteri
            // 
            this.tabMusteri.Controls.Add(this.btnMusteriEkle);
            this.tabMusteri.Controls.Add(this.label5);
            this.tabMusteri.Controls.Add(this.label4);
            this.tabMusteri.Controls.Add(this.label3);
            this.tabMusteri.Controls.Add(this.label2);
            this.tabMusteri.Controls.Add(this.label1);
            this.tabMusteri.Controls.Add(this.txtEmail);
            this.tabMusteri.Controls.Add(this.txtTelefon);
            this.tabMusteri.Controls.Add(this.txtTCNo);
            this.tabMusteri.Controls.Add(this.txtSoyad);
            this.tabMusteri.Controls.Add(this.txtAd);
            this.tabMusteri.Location = new System.Drawing.Point(4, 29);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.Size = new System.Drawing.Size(1078, 629);
            this.tabMusteri.TabIndex = 0;
            this.tabMusteri.Text = "Müşteri İşlemleri";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(181)))));
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Location = new System.Drawing.Point(101, 187);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(130, 47);
            this.btnMusteriEkle.TabIndex = 11;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 110);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 26);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(120, 80);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 26);
            this.txtTCNo.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 1;
            // 
            // tabOda
            // 
            this.tabOda.Controls.Add(this.btnOdaSil);
            this.tabOda.Controls.Add(this.dgvOdalar);
            this.tabOda.Controls.Add(this.grpOdaEkle);
            this.tabOda.Location = new System.Drawing.Point(4, 29);
            this.tabOda.Name = "tabOda";
            this.tabOda.Size = new System.Drawing.Size(1078, 629);
            this.tabOda.TabIndex = 1;
            this.tabOda.Text = "Oda İşlemleri";
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Location = new System.Drawing.Point(948, 345);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(93, 37);
            this.btnOdaSil.TabIndex = 4;
            this.btnOdaSil.Text = "Oda Sil";
            this.btnOdaSil.UseVisualStyleBackColor = true;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click_1);
            // 
            // dgvOdalar
            // 
            this.dgvOdalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdaID,
            this.OdaNumarasi,
            this.OdaTipi,
            this.Fiyat,
            this.Durum});
            this.dgvOdalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOdalar.Location = new System.Drawing.Point(0, 449);
            this.dgvOdalar.MultiSelect = false;
            this.dgvOdalar.Name = "dgvOdalar";
            this.dgvOdalar.ReadOnly = true;
            this.dgvOdalar.RowHeadersWidth = 62;
            this.dgvOdalar.RowTemplate.Height = 28;
            this.dgvOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdalar.Size = new System.Drawing.Size(1078, 180);
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
            // 
            // OdaNumarasi
            // 
            this.OdaNumarasi.HeaderText = "Oda No";
            this.OdaNumarasi.MinimumWidth = 8;
            this.OdaNumarasi.Name = "OdaNumarasi";
            this.OdaNumarasi.ReadOnly = true;
            // 
            // OdaTipi
            // 
            this.OdaTipi.HeaderText = "Oda Tipi";
            this.OdaTipi.MinimumWidth = 8;
            this.OdaTipi.Name = "OdaTipi";
            this.OdaTipi.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat TL";
            this.Fiyat.MinimumWidth = 8;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Müsait";
            this.Durum.MinimumWidth = 8;
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            // 
            // grpOdaEkle
            // 
            this.grpOdaEkle.Controls.Add(this.btnOdaGuncelle);
            this.grpOdaEkle.Controls.Add(this.btnOdaEkle);
            this.grpOdaEkle.Controls.Add(this.txtFiyat);
            this.grpOdaEkle.Controls.Add(this.label8);
            this.grpOdaEkle.Controls.Add(this.cmbOdaTipi);
            this.grpOdaEkle.Controls.Add(this.label7);
            this.grpOdaEkle.Controls.Add(this.label6);
            this.grpOdaEkle.Controls.Add(this.txtOdaNumarasi);
            this.grpOdaEkle.Location = new System.Drawing.Point(3, 3);
            this.grpOdaEkle.Name = "grpOdaEkle";
            this.grpOdaEkle.Size = new System.Drawing.Size(300, 200);
            this.grpOdaEkle.TabIndex = 2;
            this.grpOdaEkle.TabStop = false;
            this.grpOdaEkle.Text = "Oda Bilgileri";
            // 
            // btnOdaGuncelle
            // 
            this.btnOdaGuncelle.Location = new System.Drawing.Point(6, 150);
            this.btnOdaGuncelle.Name = "btnOdaGuncelle";
            this.btnOdaGuncelle.Size = new System.Drawing.Size(100, 30);
            this.btnOdaGuncelle.TabIndex = 5;
            this.btnOdaGuncelle.Text = "Güncelle";
            this.btnOdaGuncelle.UseVisualStyleBackColor = true;
            this.btnOdaGuncelle.Click += new System.EventHandler(this.btnOdaGuncelle_Click);
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Location = new System.Drawing.Point(120, 150);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(100, 30);
            this.btnOdaEkle.TabIndex = 7;
            this.btnOdaEkle.Text = "Oda Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click_1);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(120, 110);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(150, 26);
            this.txtFiyat.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fiyat:";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Items.AddRange(new object[] {
            "Standart",
            "Suit",
            "Deluxe"});
            this.cmbOdaTipi.Location = new System.Drawing.Point(120, 70);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(150, 28);
            this.cmbOdaTipi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Oda Tipi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Oda Numarası:";
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.Location = new System.Drawing.Point(120, 30);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(150, 26);
            this.txtOdaNumarasi.TabIndex = 1;
            // 
            // tabRezervasyon
            // 
            this.tabRezervasyon.Controls.Add(this.btnRezervasyonİptal);
            this.tabRezervasyon.Controls.Add(this.label12);
            this.tabRezervasyon.Controls.Add(this.grpRezervasyonBilgileri);
            this.tabRezervasyon.Controls.Add(this.btnRezervasyonYap);
            this.tabRezervasyon.Controls.Add(this.dgvRezervasyonlar);
            this.tabRezervasyon.Location = new System.Drawing.Point(4, 29);
            this.tabRezervasyon.Name = "tabRezervasyon";
            this.tabRezervasyon.Size = new System.Drawing.Size(1078, 629);
            this.tabRezervasyon.TabIndex = 2;
            this.tabRezervasyon.Text = "Rezervasyon İşlemleri";
            // 
            // btnRezervasyonİptal
            // 
            this.btnRezervasyonİptal.Location = new System.Drawing.Point(302, 242);
            this.btnRezervasyonİptal.Name = "btnRezervasyonİptal";
            this.btnRezervasyonİptal.Size = new System.Drawing.Size(149, 56);
            this.btnRezervasyonİptal.TabIndex = 8;
            this.btnRezervasyonİptal.Text = "Rezervasyon İptal";
            this.btnRezervasyonİptal.UseVisualStyleBackColor = true;
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
            this.grpRezervasyonBilgileri.Controls.Add(this.lblCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblGirisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblMusteri);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbOdalar);
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbMusteriler);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblOda);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpGirisTarihi);
            this.grpRezervasyonBilgileri.Location = new System.Drawing.Point(20, 20);
            this.grpRezervasyonBilgileri.Name = "grpRezervasyonBilgileri";
            this.grpRezervasyonBilgileri.Size = new System.Drawing.Size(600, 200);
            this.grpRezervasyonBilgileri.TabIndex = 9;
            this.grpRezervasyonBilgileri.TabStop = false;
            this.grpRezervasyonBilgileri.Text = "Rezervasyon Bilgileri";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCikisTarihi.Location = new System.Drawing.Point(9, 158);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(93, 25);
            this.lblCikisTarihi.TabIndex = 13;
            this.lblCikisTarihi.Text = "Çıkış Tarihi";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisTarihi.Location = new System.Drawing.Point(11, 118);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(91, 25);
            this.lblGirisTarihi.TabIndex = 12;
            this.lblGirisTarihi.Text = "Giriş Tarihi";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteri.Location = new System.Drawing.Point(9, 78);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(71, 25);
            this.lblMusteri.TabIndex = 10;
            this.lblMusteri.Text = "Müşteri";
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(108, 30);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(121, 28);
            this.cmbOdalar.TabIndex = 6;
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(108, 75);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(135, 28);
            this.cmbMusteriler.TabIndex = 7;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(108, 157);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpCikisTarihi.TabIndex = 5;
            // 
            // lblOda
            // 
            this.lblOda.AutoSize = true;
            this.lblOda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOda.Location = new System.Drawing.Point(20, 30);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(46, 25);
            this.lblOda.TabIndex = 11;
            this.lblOda.Text = "Oda";
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(108, 118);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpGirisTarihi.TabIndex = 4;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Location = new System.Drawing.Point(471, 242);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(149, 56);
            this.btnRezervasyonYap.TabIndex = 8;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // dgvRezervasyonlar
            // 
            this.dgvRezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervasyonId,
            this.Musteri,
            this.Oda,
            this.girisTarihi,
            this.cikisTarihi,
            this.rezervasyonDurum});
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(4, 348);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.ReadOnly = true;
            this.dgvRezervasyonlar.RowHeadersWidth = 62;
            this.dgvRezervasyonlar.RowTemplate.Height = 28;
            this.dgvRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(1070, 281);
            this.dgvRezervasyonlar.TabIndex = 2;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFaturalar);
            this.tabPage1.Controls.Add(this.grpFaturalar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 629);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Faturalar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvFaturalar
            // 
            this.dgvFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFaturaID,
            this.colMusteriAdi,
            this.ColOdaNo,
            this.colGirisTarihi,
            this.colCikisTarihi,
            this.ToplamTutar,
            this.colOdemeDurumu});
            this.dgvFaturalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFaturalar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFaturalar.Location = new System.Drawing.Point(3, 382);
            this.dgvFaturalar.Name = "dgvFaturalar";
            this.dgvFaturalar.RowHeadersWidth = 62;
            this.dgvFaturalar.RowTemplate.Height = 28;
            this.dgvFaturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturalar.Size = new System.Drawing.Size(1072, 244);
            this.dgvFaturalar.TabIndex = 1;
            // 
            // grpFaturalar
            // 
            this.grpFaturalar.Controls.Add(this.lblSeciliRezervasyon);
            this.grpFaturalar.Controls.Add(this.cmbRezervasyonlar);
            this.grpFaturalar.Controls.Add(this.btnFaturaOlustur);
            this.grpFaturalar.Location = new System.Drawing.Point(20, 20);
            this.grpFaturalar.Name = "grpFaturalar";
            this.grpFaturalar.Size = new System.Drawing.Size(600, 200);
            this.grpFaturalar.TabIndex = 0;
            this.grpFaturalar.TabStop = false;
            this.grpFaturalar.Text = "Fatura Bilgileri";
            // 
            // lblSeciliRezervasyon
            // 
            this.lblSeciliRezervasyon.AutoSize = true;
            this.lblSeciliRezervasyon.Location = new System.Drawing.Point(28, 49);
            this.lblSeciliRezervasyon.Name = "lblSeciliRezervasyon";
            this.lblSeciliRezervasyon.Size = new System.Drawing.Size(142, 20);
            this.lblSeciliRezervasyon.TabIndex = 4;
            this.lblSeciliRezervasyon.Text = "Seçili Rezervasyon";
            // 
            // cmbRezervasyonlar
            // 
            this.cmbRezervasyonlar.FormattingEnabled = true;
            this.cmbRezervasyonlar.Location = new System.Drawing.Point(198, 49);
            this.cmbRezervasyonlar.Name = "cmbRezervasyonlar";
            this.cmbRezervasyonlar.Size = new System.Drawing.Size(121, 28);
            this.cmbRezervasyonlar.TabIndex = 3;
            // 
            // btnFaturaOlustur
            // 
            this.btnFaturaOlustur.Location = new System.Drawing.Point(487, 130);
            this.btnFaturaOlustur.Name = "btnFaturaOlustur";
            this.btnFaturaOlustur.Size = new System.Drawing.Size(96, 52);
            this.btnFaturaOlustur.TabIndex = 2;
            this.btnFaturaOlustur.Text = "Fatura Oluştur";
            this.btnFaturaOlustur.UseVisualStyleBackColor = true;
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
            // colFaturaID
            // 
            this.colFaturaID.DataPropertyName = "FaturaID";
            this.colFaturaID.HeaderText = "Fatura No";
            this.colFaturaID.MinimumWidth = 8;
            this.colFaturaID.Name = "colFaturaID";
            this.colFaturaID.Width = 150;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.DataPropertyName = "MusteriAdi";
            this.colMusteriAdi.HeaderText = "Müşteri Adı";
            this.colMusteriAdi.MinimumWidth = 8;
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.Width = 150;
            // 
            // ColOdaNo
            // 
            this.ColOdaNo.DataPropertyName = "OdaNumarasi";
            this.ColOdaNo.HeaderText = "Oda No";
            this.ColOdaNo.MinimumWidth = 8;
            this.ColOdaNo.Name = "ColOdaNo";
            this.ColOdaNo.Width = 80;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.DataPropertyName = "GirisTarihi";
            this.colGirisTarihi.HeaderText = "Giriş Tarihi";
            this.colGirisTarihi.MinimumWidth = 8;
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.Width = 150;
            // 
            // colCikisTarihi
            // 
            this.colCikisTarihi.DataPropertyName = "CikisTarihi";
            this.colCikisTarihi.HeaderText = "Çıkış Tarihi";
            this.colCikisTarihi.MinimumWidth = 8;
            this.colCikisTarihi.Name = "colCikisTarihi";
            this.colCikisTarihi.Width = 150;
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.DataPropertyName = "ToplamTutar";
            this.ToplamTutar.HeaderText = "Toplam Tutar";
            this.ToplamTutar.MinimumWidth = 8;
            this.ToplamTutar.Name = "ToplamTutar";
            this.ToplamTutar.Width = 150;
            // 
            // colOdemeDurumu
            // 
            this.colOdemeDurumu.DataPropertyName = "OdemeDurumu";
            this.colOdemeDurumu.HeaderText = "Ödeme Durumu";
            this.colOdemeDurumu.MinimumWidth = 8;
            this.colOdemeDurumu.Name = "colOdemeDurumu";
            this.colOdemeDurumu.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1086, 662);
            this.Controls.Add(this.tabFaturalar);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Otel Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabFaturalar.ResumeLayout(false);
            this.tabMusteri.ResumeLayout(false);
            this.tabMusteri.PerformLayout();
            this.tabOda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).EndInit();
            this.grpOdaEkle.ResumeLayout(false);
            this.grpOdaEkle.PerformLayout();
            this.tabRezervasyon.ResumeLayout(false);
            this.grpRezervasyonBilgileri.ResumeLayout(false);
            this.grpRezervasyonBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.tabPage1.ResumeLayout(false);
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
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnMusteriEkle;
        private GroupBox grpOdaEkle;
        private Label label6;
        private ComboBox cmbOdaTipi;
        private Label label7;
        private Label label8;
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
        private TabPage tabPage1;
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
    }
}
