using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MySql.Data.MySqlClient;



namespace OtelRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        private MusteriManager musteriManager;
        private BusinessLayer.OdaManager odaManager;
        private RezervasyonManager rezervasyonManager;
        private FaturaManager faturaManager;

        public Form1()
        {
            InitializeComponent(); // Designer'daki kontroller burada başlatılır
            musteriManager = new MusteriManager(); // İş mantığı sınıfı başlatılır
            odaManager = new BusinessLayer.OdaManager();
            rezervasyonManager = new RezervasyonManager();
            faturaManager = new FaturaManager();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView ayarları
            dgvOdalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOdalar.MultiSelect = false;
            dgvOdalar.DataBindings.Clear();
            dgvOdalar.AutoGenerateColumns = false;
            dgvOdalar.Columns.Clear();

            // Sütun tanımları
            dgvOdalar.Columns.Add("OdaID", "Oda ID");
            dgvOdalar.Columns.Add("OdaNumarasi", "Oda No");
            dgvOdalar.Columns.Add("OdaTipi", "Oda Tipi");
            dgvOdalar.Columns.Add("Fiyat", "Fiyat (TL)");
            dgvOdalar.Columns.Add("Durum", "Müsait");

            // DataPropertyName ayarları
            dgvOdalar.Columns["OdaID"].DataPropertyName = "OdaID";
            dgvOdalar.Columns["OdaNumarasi"].DataPropertyName = "OdaNumarasi";
            dgvOdalar.Columns["OdaTipi"].DataPropertyName = "OdaTipi";
            dgvOdalar.Columns["Fiyat"].DataPropertyName = "Fiyat";
            dgvOdalar.Columns["Durum"].DataPropertyName = "Durum";

            // ComboBox ayarları
            cmbOdaTipi.Items.Clear();
            cmbOdaTipi.Items.AddRange(new string[] { "Standart", "Suit", "Deluxe" });
            cmbOdaTipi.SelectedIndex = 0;

            // Müşterileri ComboBox'a yükle
            var musteriler = musteriManager.TumMusterileriGetir();
            cmbMusteriler.DataSource = musteriler;
            cmbMusteriler.DisplayMember = "Ad";
            cmbMusteriler.ValueMember = "MusteriID";

            // Odaları ComboBox'a yükle
            var odalar = odaManager.TumOdalariGetir();
            cmbOdalar.DataSource = odalar;
            cmbOdalar.DisplayMember = "OdaNumarasi";
            cmbOdalar.ValueMember = "OdaID";

            // Rezervasyon DataGridView ayarları
            dgvRezervasyonlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRezervasyonlar.MultiSelect = false;
            dgvRezervasyonlar.DataBindings.Clear();
            dgvRezervasyonlar.AutoGenerateColumns = false;
            dgvRezervasyonlar.Columns.Clear();

            // Rezervasyon sütun tanımları
            dgvRezervasyonlar.Columns.Add("RezervasyonID", "Rezervasyon ID");
            dgvRezervasyonlar.Columns.Add("MusteriID", "Müşteri ID");
            dgvRezervasyonlar.Columns.Add("OdaID", "Oda No");
            dgvRezervasyonlar.Columns.Add("GirisTarihi", "Giriş Tarihi");
            dgvRezervasyonlar.Columns.Add("CikisTarihi", "Çıkış Tarihi");
            dgvRezervasyonlar.Columns.Add("Durum", "Rezervasyon Durumu");  // Başlığı değiştirdik
            dgvRezervasyonlar.Columns.Add("ToplamTutar", "Toplam Tutar");


            // DataPropertyName ayarları
            dgvRezervasyonlar.Columns["RezervasyonID"].DataPropertyName = "RezervasyonID";
            dgvRezervasyonlar.Columns["MusteriID"].DataPropertyName = "MusteriID";
            dgvRezervasyonlar.Columns["OdaID"].DataPropertyName = "OdaID";
            dgvRezervasyonlar.Columns["GirisTarihi"].DataPropertyName = "GirisTarihi";
            dgvRezervasyonlar.Columns["CikisTarihi"].DataPropertyName = "CikisTarihi";
            dgvRezervasyonlar.Columns["Durum"].DataPropertyName = "DurumText";  // Yeni özelliği kullan
            dgvRezervasyonlar.Columns["ToplamTutar"].DataPropertyName = "ToplamTutar";
            // DataGridView sütun ayarları
            dgvRezervasyonlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgvRezervasyonlar.Columns)
            {
                switch (column.Name)
                {
                    case "RezervasyonID":
                    case "MusteriID":
                    case "OdaID":
                    case "Durum":
                        column.Width = 100;
                        break;
                    case "GirisTarihi":
                    case "CikisTarihi":
                        column.Width = 150;
                        break;
                }
            }
            // Fatura DataGridView ayarları
            dgvFaturalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFaturalar.MultiSelect = false;
            dgvFaturalar.AutoGenerateColumns = false;
            dgvFaturalar.Columns.Clear();

            // Fatura sütunlarını ekle
            dgvFaturalar.Columns.Add("FaturaID", "Fatura No");
            dgvFaturalar.Columns.Add("MusteriAdi", "Müşteri Adı");
            dgvFaturalar.Columns.Add("OdaNumarasi", "Oda No");
            dgvFaturalar.Columns.Add("GirisTarihi", "Giriş Tarihi");
            dgvFaturalar.Columns.Add("CikisTarihi", "Çıkış Tarihi");
            dgvFaturalar.Columns.Add("ToplamTutar", "Toplam Tutar");
            dgvFaturalar.Columns.Add("OdemeDurumu", "Ödeme Durumu");

            // DataPropertyName ayarları
            dgvFaturalar.Columns["FaturaID"].DataPropertyName = "FaturaID";
            dgvFaturalar.Columns["MusteriAdi"].DataPropertyName = "MusteriAdi";
            dgvFaturalar.Columns["OdaNumarasi"].DataPropertyName = "OdaNumarasi";
            dgvFaturalar.Columns["GirisTarihi"].DataPropertyName = "GirisTarihi";
            dgvFaturalar.Columns["CikisTarihi"].DataPropertyName = "CikisTarihi";
            dgvFaturalar.Columns["ToplamTutar"].DataPropertyName = "ToplamTutar";
            dgvFaturalar.Columns["OdemeDurumu"].DataPropertyName = "OdemeDurumu";


            OdalariListele();
            RezervasyonlariListele();
            FaturalariListele();

            RezervasyonlariComboBoxaYukle();


        }



        private void OdalariListele()
        {
            // OdaManager'dan tüm odaları alma ve DataGridView'da gösterme işlemi
            try
            {
                var odalar = odaManager.TumOdalariGetir();
                dgvOdalar.DataSource = null;
                dgvOdalar.DataSource = odalar;
                Console.WriteLine($"Listelenen oda sayısı: {odalar.Count}"); // Debug için
                //var odalar = odaManager.TumOdalariGetir();
                ////dgvOdalar.DataSource = odalar;
                //if (odalar != null && odalar.Any())
                //{
                //    dgvOdalar.DataSource = null; // Önce mevcut veriyi temizle
                //    dgvOdalar.DataSource = odalar; // Yeni veriyi ata
                //    dgvOdalar.Refresh(); // DataGridView'ı yenile
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnOdaEkle_Click_1(object sender, EventArgs e)
        {
            // Veri doğrulama kontrolleri
            if (string.IsNullOrWhiteSpace(txtOdaNumarasi.Text))
            {
                MessageBox.Show("Oda numarası boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Oda tipi kontrolü
            if (cmbOdaTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Oda tipi seçiniz!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fiyat kontrolü
            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat giriniz!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni oda nesnesi oluştur
            Oda yeniOda = new Oda
            {
                OdaNumarasi = txtOdaNumarasi.Text,
                OdaTipi = cmbOdaTipi.SelectedItem.ToString(),
                Fiyat = fiyat,
                Durum = true // Oda müsait
            };

            // Oda ekleme işlemi
            if (odaManager.OdaEkle(yeniOda))
            {
                MessageBox.Show("Oda başarıyla eklendi!");

                // Formu temizle
                txtOdaNumarasi.Clear();
                cmbOdaTipi.SelectedIndex = -1;
                txtFiyat.Clear();

                // Odaları yeniden listele
                OdalariListele();
            }
            else
            {
                MessageBox.Show("Oda eklenirken hata oluştu!");
            }
        }
        

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTCNo.Text.Length != 11 || !txtTCNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("TC No 11 haneli ve yalnızca rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TextBox'lardaki değerleri alıyoruz
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tcNo = txtTCNo.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;

            // Yeni bir müşteri oluşturuyoruz
            Musteri yeniMusteri = new Musteri
            {
                Ad = ad,
                Soyad = soyad,
                TCNo = tcNo,
                Telefon = telefon,
                Email = email
            };

            // MusteriManager kullanarak müşteri ekleme işlemi
            bool basarili = musteriManager.MusteriEkle(yeniMusteri);

            if (basarili)
            {
                MessageBox.Show("Müşteri başarıyla eklendi!");
            }
            else
            {
                MessageBox.Show("Müşteri eklenirken bir hata oluştu.");
            }
        }

        private void btnOdaSil_Click_1(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek odayı seçin.");
                return;
            }

            var selectedRow = dgvOdalar.SelectedRows[0];
            var odaID = Convert.ToInt32(selectedRow.Cells["OdaID"].Value);

            var result = MessageBox.Show("Bu odayı silmek istediğinizden emin misiniz?",
                                       "Silme Onayı",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (odaManager.OdaSil(odaID))
                {
                    MessageBox.Show("Oda başarıyla silindi.");
                    OdalariListele();
                }
                else
                {
                    MessageBox.Show("Oda silinirken bir hata oluştu.");
                }
            }
        }

        private void dgvOdalar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count > 0)
            {
                var selectedRow = dgvOdalar.SelectedRows[0];
                txtOdaNumarasi.Text = selectedRow.Cells["OdaNumarasi"].Value.ToString();
                cmbOdaTipi.Text = selectedRow.Cells["OdaTipi"].Value.ToString();
                txtFiyat.Text = selectedRow.Cells["Fiyat"].Value.ToString();
            }
        }

        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek odayı seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOdaNumarasi.Text) ||
                string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Tüm alanları doldurun!");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat girin!");
                return;
            }

            var selectedRow = dgvOdalar.SelectedRows[0];
            var odaID = Convert.ToInt32(selectedRow.Cells["OdaID"].Value);

            var guncelOda = new Oda
            {
                OdaID = odaID,
                OdaNumarasi = txtOdaNumarasi.Text,
                OdaTipi = cmbOdaTipi.SelectedItem.ToString(),
                Fiyat = fiyat,
                Durum = true
            };

            if (odaManager.OdaGuncelle(guncelOda))
            {
                MessageBox.Show("Oda başarıyla güncellendi!");
                OdalariListele();
            }
            else
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu!");
            }
        }
        private void RezervasyonlariListele()
        {
            try
            {
                var rezervasyonlar = rezervasyonManager.TumRezervasyonlariGetir();
                dgvRezervasyonlar.DataSource = rezervasyonlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar listelenirken hata oluştu: " + ex.Message);
            }
        }
        private bool OdaMusaitMi(int odaID, DateTime girisTarihi, DateTime cikisTarihi)
        {
            try
            {
                // Bu kontrolü RezervasyonManager'a taşıyacağız, şimdilik burada yapıyoruz
                var tumRezervasyonlar = rezervasyonManager.TumRezervasyonlariGetir();

                // Sadece aktif ve aynı odaya ait rezervasyonları filtrele
                var odaRezervasyonlari = tumRezervasyonlar.Where(r =>
                    r.OdaID == odaID &&
                    r.Durum == true);  // Sadece aktif rezervasyonlar

                foreach (var rezervasyon in odaRezervasyonlari)
                {
                    // Tarih çakışması kontrolü
                    if ((girisTarihi >= rezervasyon.GirisTarihi && girisTarihi < rezervasyon.CikisTarihi) ||
                        (cikisTarihi > rezervasyon.GirisTarihi && cikisTarihi <= rezervasyon.CikisTarihi) ||
                        (girisTarihi <= rezervasyon.GirisTarihi && cikisTarihi >= rezervasyon.CikisTarihi))
                    {
                        return false; // Tarih çakışması var
                    }
                }

                return true; // Tarih çakışması yok
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda müsaitlik kontrolü sırasında hata: {ex.Message}");
                return false;
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedValue == null || cmbOdalar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri ve oda seçin.");
                return;
            }

            // Tarih kontrollerini yap
            if (!TarihKontrolleriGecerli(dtpGirisTarihi.Value, dtpCikisTarihi.Value))
            {
                return; // Tarih kontrolleri başarısızsa işlemi sonlandır
            }

            // Seçilen tarihler için odanın müsaitlik kontrolü
            int secilenOdaID = Convert.ToInt32(cmbOdalar.SelectedValue);
            if (!OdaMusaitMi(secilenOdaID, dtpGirisTarihi.Value, dtpCikisTarihi.Value))
            {
                MessageBox.Show("Seçilen tarihler için oda müsait değil!",
                               "Oda Dolu",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            decimal toplamFiyat = ToplamFiyatHesapla(dtpGirisTarihi.Value, dtpCikisTarihi.Value, secilenOdaID);

            var result = MessageBox.Show($"Toplam Fiyat: {toplamFiyat:N2} TL\nOnaylıyor musunuz?",
                            "Fiyat Onayı",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            var rezervasyon = new Rezervasyon
            {
                MusteriID = Convert.ToInt32(cmbMusteriler.SelectedValue),
                OdaID = Convert.ToInt32(cmbOdalar.SelectedValue),
                GirisTarihi = dtpGirisTarihi.Value,
                CikisTarihi = dtpCikisTarihi.Value,
                Durum = true
            };

            if (rezervasyonManager.RezervasyonEkle(rezervasyon))
            {
                MessageBox.Show("Rezervasyon başarıyla yapıldı!");
                RezervasyonlariListele();
                OdalariListele(); // Oda listesini de yenile (durumları güncellendi)

                // ComboBox'ları yenile
                var odalar = odaManager.TumOdalariGetir();
                cmbOdalar.DataSource = odalar;
            }
            else
            {
                MessageBox.Show("Rezervasyon yapılırken hata oluştu!");
            }


        }

        private void btnRezervasyonİptal_Click(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iptal edilecek rezervasyonu seçin.");
                return;
            }

            var selectedRow = dgvRezervasyonlar.SelectedRows[0];
            var rezervasyonID = Convert.ToInt32(selectedRow.Cells["RezervasyonID"].Value);

            var result = MessageBox.Show("Bu rezervasyonu iptal etmek istediğinizden emin misiniz?",
                                       "İptal Onayı",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (rezervasyonManager.RezervasyonIptal(rezervasyonID))
                {
                    MessageBox.Show("Rezervasyon başarıyla iptal edildi.");
                    RezervasyonlariListele(); // Listeyi güncelle
                    OdalariListele(); // Oda durumlarını güncelle
                }
                else
                {
                    MessageBox.Show("Rezervasyon iptal edilirken bir hata oluştu.");
                }
            }
        }

        private bool TarihKontrolleriGecerli(DateTime girisTarihi, DateTime cikisTarihi)
        {
            // Bugünün tarihini al (saat bilgisi olmadan)
            DateTime bugun = DateTime.Today;

            // 1. Kontrol: Giriş tarihi bugünden önce olmamalı
            if (girisTarihi.Date < bugun)
            {
                MessageBox.Show("Geçmiş bir tarihe rezervasyon yapılamaz!",
                               "Hatalı Tarih",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }

            // 2. Kontrol: Çıkış tarihi giriş tarihinden önce olmamalı
            if (cikisTarihi.Date <= girisTarihi.Date)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden sonra olmalıdır!",
                               "Hatalı Tarih",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }

            // 3. Kontrol: Maksimum rezervasyon süresi (örneğin 30 gün)
            TimeSpan kalisSuresi = cikisTarihi.Date - girisTarihi.Date;
            if (kalisSuresi.TotalDays > 30)
            {
                MessageBox.Show("Rezervasyon süresi 30 günden fazla olamaz!",
                               "Uzun Süre",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private decimal ToplamFiyatHesapla(DateTime girisTarihi, DateTime cikisTarihi, int odaID)
        {
            try
            {
                // Kalış süresini hesapla
                int gunSayisi = (cikisTarihi - girisTarihi).Days;

                // Odanın gecelik fiyatını al
                var odalar = odaManager.TumOdalariGetir();
                var oda = odalar.First(o => o.OdaID == odaID);
                decimal gecelikFiyat = oda.Fiyat;

                // Oda tipine göre ek ücret
                switch (oda.OdaTipi.ToLower())
                {
                    case "suit":
                        gecelikFiyat *= 1.5m; // %50 ek ücret
                        break;
                    case "deluxe":
                        gecelikFiyat *= 2.0m; // %100 ek ücret
                        break;
                }

                return gunSayisi * gecelikFiyat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fiyat hesaplama hatası: {ex.Message}");
                return 0;
            }
        }

        private void FaturalariListele()
        {
            try
            {
                var faturalar = faturaManager.TumFaturalariGetir();
                dgvFaturalar.DataSource = faturalar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faturalar listelenirken hata oluştu: " + ex.Message);
            }
        }
        private void btnFaturaOlustur_Click(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen fatura oluşturulacak rezervasyonu seçin.");
                return;
            }

            var selectedRow = dgvRezervasyonlar.SelectedRows[0];
            var rezervasyonID = Convert.ToInt32(selectedRow.Cells["RezervasyonID"].Value);
            // Toplam tutarı rezervasyon için yeniden hesapla
            var rezervasyon = rezervasyonManager.TumRezervasyonlariGetir()
                .FirstOrDefault(r => r.RezervasyonID == rezervasyonID);

            if (rezervasyon != null)
            {
                var toplamTutar = ToplamFiyatHesapla(rezervasyon.GirisTarihi, rezervasyon.CikisTarihi, rezervasyon.OdaID);

                if (faturaManager.FaturaOlustur(rezervasyonID, toplamTutar))
                {
                    MessageBox.Show("Fatura başarıyla oluşturuldu!");
                    FaturalariListele();
                }
                else
                {
                    MessageBox.Show("Fatura oluşturulurken hata oluştu!");
                }
            }
        }

        private void RezervasyonlariComboBoxaYukle()
        {
            var rezervasyonlar = rezervasyonManager.TumRezervasyonlariGetir();
            cmbRezervasyonlar.DataSource = rezervasyonlar;
            cmbRezervasyonlar.DisplayMember = "RezervasyonID";
            cmbRezervasyonlar.ValueMember = "RezervasyonID";
        }

    }
}
