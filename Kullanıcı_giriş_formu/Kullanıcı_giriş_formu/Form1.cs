using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_giriş_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            {
                string kullaniciAdi = KullaniciAdiTextBox.Text;
                string sifre = SifreTextBox.Text;

                
                if (kullaniciAdi == "admin" && sifre == "12345")
                {
                    MessageBox.Show("Giriş Başarılı!");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız. Lütfen bilgilerinizi kontrol edin.");
                }
            }
        }

        private void YeniKullaniciButton_Click(object sender, EventArgs e)
        {
            {
                
                MessageBox.Show("Yeni kullanıcı kaydı sayfasına yönlendiriliyorsunuz.");
            }
        }

        private void SifreyiUnuttunuzLink_Click(object sender, EventArgs e)
        {
            {
                
                MessageBox.Show("Şifrenizi sıfırlamak için talimatlar gönderilecektir.");
            }
        }
    }
}
