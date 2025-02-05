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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.txtRezervasyonNo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            this.tabOda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).BeginInit();
            this.grpOdaEkle.SuspendLayout();
            this.tabRezervasyon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMusteri);
            this.tabControl1.Controls.Add(this.tabOda);
            this.tabControl1.Controls.Add(this.tabRezervasyon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 662);
            this.tabControl1.TabIndex = 0;
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
            this.btnMusteriEkle.Location = new System.Drawing.Point(120, 170);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(78, 51);
            this.btnMusteriEkle.TabIndex = 11;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
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
            this.btnOdaSil.Location = new System.Drawing.Point(763, 570);
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
            this.tabRezervasyon.Controls.Add(this.txtRezervasyonNo);
            this.tabRezervasyon.Location = new System.Drawing.Point(4, 29);
            this.tabRezervasyon.Name = "tabRezervasyon";
            this.tabRezervasyon.Size = new System.Drawing.Size(1078, 629);
            this.tabRezervasyon.TabIndex = 2;
            this.tabRezervasyon.Text = "Rezervasyon İşlemleri";
            // 
            // txtRezervasyonNo
            // 
            this.txtRezervasyonNo.Location = new System.Drawing.Point(0, 0);
            this.txtRezervasyonNo.Name = "txtRezervasyonNo";
            this.txtRezervasyonNo.Size = new System.Drawing.Size(100, 26);
            this.txtRezervasyonNo.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(1086, 662);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Otel Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMusteri.ResumeLayout(false);
            this.tabMusteri.PerformLayout();
            this.tabOda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).EndInit();
            this.grpOdaEkle.ResumeLayout(false);
            this.grpOdaEkle.PerformLayout();
            this.tabRezervasyon.ResumeLayout(false);
            this.tabRezervasyon.PerformLayout();
            this.ResumeLayout(false);

        }

        private TabPage tabMusteri;
        private TabPage tabOda;
        private TabPage tabRezervasyon;
        private TextBox txtRezervasyonNo;
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
    }
}
