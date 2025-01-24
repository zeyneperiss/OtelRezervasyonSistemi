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

namespace OtelRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        private MusteriManager musteriManager;
        private OdaManager odaManager;

        public Form1()
        {
            InitializeComponent(); // Designer'daki kontroller burada başlatılır
            musteriManager = new MusteriManager(); // İş mantığı sınıfı başlatılır
            odaManager = new OdaManager();

            // ComboBox'a oda tiplerini ekliyoruz
            cmbOdaTipi.Items.AddRange(new string[] { "Standart", "Suit", "Deluxe" });
            // Form yüklendiğinde odaları listeleyeceğiz
            OdalariListele();
        }

        private void OdalariListele()
        {
            // OdaManager'dan tüm odaları alma ve DataGridView'da gösterme işlemi
            try
            {
                var odalar = odaManager.TumOdalariGetir();
                dgvOdalar.DataSource = odalar;
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
    }
}
