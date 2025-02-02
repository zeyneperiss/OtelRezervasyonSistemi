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

namespace OtelRezervasyonSistemi
{
    public partial class LoginForm : Form
    {
        private readonly KullaniciManager _kullaniciManager;

        public LoginForm()
        {
            InitializeComponent();
            _kullaniciManager = new KullaniciManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı adı ve şifreyi textbox'lardan al ve boşlukları temizle
                string kullaniciAdi = txtUsername.Text.Trim();
                string sifre = txtPassword.Text.Trim();

                // KullaniciManager üzerinden giriş kontrolü yap
                var kullanici = _kullaniciManager.KullaniciGiris(kullaniciAdi, sifre);

                // Eğer buraya kadar gelebildiyse giriş başarılı demektir
                MessageBox.Show($"Hoş geldiniz, {kullanici.Ad} {kullanici.Soyad}!",
                              "Başarılı Giriş",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                // Ana forma geç
                Form1 anaForm = new Form1();
                this.Hide();
                anaForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show(ex.Message, "Hata",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        // Form kapatıldığında uygulamayı sonlandır
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}

