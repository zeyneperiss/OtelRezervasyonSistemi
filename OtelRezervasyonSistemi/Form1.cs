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

        public Form1()
        {
            InitializeComponent(); // Designer'daki kontroller burada başlatılır
            musteriManager = new MusteriManager(); // İş mantığı sınıfı başlatılır
            odaManager = new BusinessLayer.OdaManager();
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

            OdalariListele();
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
        //private void btnOdaSil_Click(object sender, EventArgs e)
        //{
        //    if (dgvOdalar.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Lütfen silinecek odayı seçin.");
        //        return;
        //    }

        //    var selectedRow = dgvOdalar.SelectedRows[0];
        //    var odaID = Convert.ToInt32(selectedRow.Cells["OdaID"].Value);

        //    var result = MessageBox.Show("Bu odayı silmek istediğinizden emin misiniz?",
        //                               "Silme Onayı",
        //                               MessageBoxButtons.YesNo,
        //                               MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
        //    {
        //        if (odaManager.OdaSil(odaID))
        //        {
        //            MessageBox.Show("Oda başarıyla silindi.");
        //            OdalariListele();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Oda silinirken bir hata oluştu.");
        //        }
        //    }
        //}

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
    }
}
