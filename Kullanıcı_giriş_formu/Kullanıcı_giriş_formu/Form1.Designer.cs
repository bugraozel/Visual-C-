namespace Kullanıcı_giriş_formu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.GirisButton = new System.Windows.Forms.Button();
            this.YeniKullaniciButton = new System.Windows.Forms.Button();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.SifreyiUnuttunuzLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.Location = new System.Drawing.Point(468, 340);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(269, 60);
            this.GirisButton.TabIndex = 0;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // YeniKullaniciButton
            // 
            this.YeniKullaniciButton.Location = new System.Drawing.Point(106, 340);
            this.YeniKullaniciButton.Name = "YeniKullaniciButton";
            this.YeniKullaniciButton.Size = new System.Drawing.Size(231, 60);
            this.YeniKullaniciButton.TabIndex = 1;
            this.YeniKullaniciButton.Text = "Yeni Kullanıcı";
            this.YeniKullaniciButton.UseVisualStyleBackColor = true;
            this.YeniKullaniciButton.Click += new System.EventHandler(this.YeniKullaniciButton_Click);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.Location = new System.Drawing.Point(196, 112);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(119, 25);
            this.kullaniciAdi.TabIndex = 2;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(199, 174);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(52, 25);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre";
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(487, 112);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(100, 22);
            this.KullaniciAdiTextBox.TabIndex = 4;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(487, 174);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(100, 22);
            this.SifreTextBox.TabIndex = 5;
            // 
            // SifreyiUnuttunuzLink
            // 
            this.SifreyiUnuttunuzLink.Location = new System.Drawing.Point(487, 239);
            this.SifreyiUnuttunuzLink.Name = "SifreyiUnuttunuzLink";
            this.SifreyiUnuttunuzLink.Size = new System.Drawing.Size(166, 39);
            this.SifreyiUnuttunuzLink.TabIndex = 6;
            this.SifreyiUnuttunuzLink.Text = "Şifreyi mi Unuttunuz?";
            this.SifreyiUnuttunuzLink.UseVisualStyleBackColor = true;
            this.SifreyiUnuttunuzLink.Click += new System.EventHandler(this.SifreyiUnuttunuzLink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanıcı Giriş Formu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SifreyiUnuttunuzLink);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.YeniKullaniciButton);
            this.Controls.Add(this.GirisButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button YeniKullaniciButton;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button SifreyiUnuttunuzLink;
        private System.Windows.Forms.Label label3;
    }
}

