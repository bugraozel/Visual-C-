namespace CarPoolCalculator
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
            this.günlükMiktar = new System.Windows.Forms.Label();
            this.günlükMiktarMilesTextBox = new System.Windows.Forms.TextBox();
            this.benzinGallondaMaliyet = new System.Windows.Forms.Label();
            this.ortalamaMPG = new System.Windows.Forms.Label();
            this.parkÜcretleri = new System.Windows.Forms.Label();
            this.geçişler = new System.Windows.Forms.Label();
            this.benzinGallondaMaliyetTextBox = new System.Windows.Forms.TextBox();
            this.ortalamaMPGTextBox = new System.Windows.Forms.TextBox();
            this.parkÜcretleriTextBox = new System.Windows.Forms.TextBox();
            this.geçişlerTextBox = new System.Windows.Forms.TextBox();
            this.Hesapla = new System.Windows.Forms.Button();
            this.sonuçEtiketi = new System.Windows.Forms.Label();
            this.günlükSürüşMaliyetiUSD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // günlükMiktar
            // 
            this.günlükMiktar.AutoSize = true;
            this.günlükMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.günlükMiktar.Location = new System.Drawing.Point(27, 49);
            this.günlükMiktar.Name = "günlükMiktar";
            this.günlükMiktar.Size = new System.Drawing.Size(233, 16);
            this.günlükMiktar.TabIndex = 0;
            this.günlükMiktar.Text = "Günlük sürülen toplam km miktarı";
            // 
            // günlükMiktarMilesTextBox
            // 
            this.günlükMiktarMilesTextBox.Location = new System.Drawing.Point(372, 49);
            this.günlükMiktarMilesTextBox.Name = "günlükMiktarMilesTextBox";
            this.günlükMiktarMilesTextBox.Size = new System.Drawing.Size(100, 22);
            this.günlükMiktarMilesTextBox.TabIndex = 1;
            // 
            // benzinGallondaMaliyet
            // 
            this.benzinGallondaMaliyet.AutoSize = true;
            this.benzinGallondaMaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.benzinGallondaMaliyet.Location = new System.Drawing.Point(27, 87);
            this.benzinGallondaMaliyet.Name = "benzinGallondaMaliyet";
            this.benzinGallondaMaliyet.Size = new System.Drawing.Size(226, 16);
            this.benzinGallondaMaliyet.TabIndex = 2;
            this.benzinGallondaMaliyet.Text = "Benzinin litre başına maliyeti TL";
            // 
            // ortalamaMPG
            // 
            this.ortalamaMPG.AutoSize = true;
            this.ortalamaMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortalamaMPG.Location = new System.Drawing.Point(27, 125);
            this.ortalamaMPG.Name = "ortalamaMPG";
            this.ortalamaMPG.Size = new System.Drawing.Size(309, 16);
            this.ortalamaMPG.TabIndex = 3;
            this.ortalamaMPG.Text = " Ortalama km başına yakılan yakıt TL (MPG)";
            // 
            // parkÜcretleri
            // 
            this.parkÜcretleri.AutoSize = true;
            this.parkÜcretleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parkÜcretleri.Location = new System.Drawing.Point(27, 165);
            this.parkÜcretleri.Name = "parkÜcretleri";
            this.parkÜcretleri.Size = new System.Drawing.Size(149, 16);
            this.parkÜcretleri.TabIndex = 4;
            this.parkÜcretleri.Text = "Günlük park ücretleri";
            // 
            // geçişler
            // 
            this.geçişler.AutoSize = true;
            this.geçişler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geçişler.Location = new System.Drawing.Point(27, 207);
            this.geçişler.Name = "geçişler";
            this.geçişler.Size = new System.Drawing.Size(156, 16);
            this.geçişler.TabIndex = 5;
            this.geçişler.Text = "Günlük geçiş ücretleri";
            // 
            // benzinGallondaMaliyetTextBox
            // 
            this.benzinGallondaMaliyetTextBox.Location = new System.Drawing.Point(372, 87);
            this.benzinGallondaMaliyetTextBox.Name = "benzinGallondaMaliyetTextBox";
            this.benzinGallondaMaliyetTextBox.Size = new System.Drawing.Size(100, 22);
            this.benzinGallondaMaliyetTextBox.TabIndex = 6;
            // 
            // ortalamaMPGTextBox
            // 
            this.ortalamaMPGTextBox.Location = new System.Drawing.Point(372, 125);
            this.ortalamaMPGTextBox.Name = "ortalamaMPGTextBox";
            this.ortalamaMPGTextBox.Size = new System.Drawing.Size(100, 22);
            this.ortalamaMPGTextBox.TabIndex = 7;
            // 
            // parkÜcretleriTextBox
            // 
            this.parkÜcretleriTextBox.Location = new System.Drawing.Point(372, 165);
            this.parkÜcretleriTextBox.Name = "parkÜcretleriTextBox";
            this.parkÜcretleriTextBox.Size = new System.Drawing.Size(100, 22);
            this.parkÜcretleriTextBox.TabIndex = 8;
            // 
            // geçişlerTextBox
            // 
            this.geçişlerTextBox.Location = new System.Drawing.Point(372, 207);
            this.geçişlerTextBox.Name = "geçişlerTextBox";
            this.geçişlerTextBox.Size = new System.Drawing.Size(100, 22);
            this.geçişlerTextBox.TabIndex = 9;
            // 
            // Hesapla
            // 
            this.Hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hesapla.Location = new System.Drawing.Point(372, 261);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(133, 23);
            this.Hesapla.TabIndex = 10;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // sonuçEtiketi
            // 
            this.sonuçEtiketi.AutoSize = true;
            this.sonuçEtiketi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuçEtiketi.Location = new System.Drawing.Point(372, 294);
            this.sonuçEtiketi.Name = "sonuçEtiketi";
            this.sonuçEtiketi.Size = new System.Drawing.Size(50, 16);
            this.sonuçEtiketi.TabIndex = 12;
            this.sonuçEtiketi.Text = "Sonuç";
            // 
            // günlükSürüşMaliyetiUSD
            // 
            this.günlükSürüşMaliyetiUSD.AutoSize = true;
            this.günlükSürüşMaliyetiUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.günlükSürüşMaliyetiUSD.Location = new System.Drawing.Point(30, 293);
            this.günlükSürüşMaliyetiUSD.Name = "günlükSürüşMaliyetiUSD";
            this.günlükSürüşMaliyetiUSD.Size = new System.Drawing.Size(155, 16);
            this.günlükSürüşMaliyetiUSD.TabIndex = 13;
            this.günlükSürüşMaliyetiUSD.Text = "Günlük Sürüş Maliyeti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 347);
            this.Controls.Add(this.günlükSürüşMaliyetiUSD);
            this.Controls.Add(this.sonuçEtiketi);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.geçişlerTextBox);
            this.Controls.Add(this.parkÜcretleriTextBox);
            this.Controls.Add(this.ortalamaMPGTextBox);
            this.Controls.Add(this.benzinGallondaMaliyetTextBox);
            this.Controls.Add(this.geçişler);
            this.Controls.Add(this.parkÜcretleri);
            this.Controls.Add(this.ortalamaMPG);
            this.Controls.Add(this.benzinGallondaMaliyet);
            this.Controls.Add(this.günlükMiktarMilesTextBox);
            this.Controls.Add(this.günlükMiktar);
            this.Name = "Form1";
            this.Text = "Araç Kiralama Hesaplayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label günlükMiktar;
        private System.Windows.Forms.TextBox günlükMiktarMilesTextBox;
        private System.Windows.Forms.Label benzinGallondaMaliyet;
        private System.Windows.Forms.Label ortalamaMPG;
        private System.Windows.Forms.Label parkÜcretleri;
        private System.Windows.Forms.Label geçişler;
        private System.Windows.Forms.TextBox benzinGallondaMaliyetTextBox;
        private System.Windows.Forms.TextBox ortalamaMPGTextBox;
        private System.Windows.Forms.TextBox parkÜcretleriTextBox;
        private System.Windows.Forms.TextBox geçişlerTextBox;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label sonuçEtiketi;
        private System.Windows.Forms.Label günlükSürüşMaliyetiUSD;
    }
}

