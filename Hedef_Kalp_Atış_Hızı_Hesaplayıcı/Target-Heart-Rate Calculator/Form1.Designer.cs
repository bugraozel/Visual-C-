namespace Target_Heart_Rate_Calculator
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.birthYear = new System.Windows.Forms.Label();
            this.currentYear = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.dogumYiliTextBox = new System.Windows.Forms.TextBox();
            this.guncelYilTextBox = new System.Windows.Forms.TextBox();
            this.MaxHeartRate = new System.Windows.Forms.Label();
            this.maxKalpAtisLabelSonuc = new System.Windows.Forms.Label();
            this.TargetHeartRateRange = new System.Windows.Forms.Label();
            this.hedefKalpAtisLabelSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adLabelSonuc = new System.Windows.Forms.Label();
            this.soyadLabelSonuc = new System.Windows.Forms.Label();
            this.yasLabelSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstName.Location = new System.Drawing.Point(39, 9);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(46, 25);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "Ad:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastName.Location = new System.Drawing.Point(39, 48);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(81, 25);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Soyad:";
            // 
            // birthYear
            // 
            this.birthYear.AutoSize = true;
            this.birthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birthYear.Location = new System.Drawing.Point(39, 93);
            this.birthYear.Name = "birthYear";
            this.birthYear.Size = new System.Drawing.Size(122, 25);
            this.birthYear.TabIndex = 2;
            this.birthYear.Text = "Doğum Yılı:";
            // 
            // currentYear
            // 
            this.currentYear.AutoSize = true;
            this.currentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentYear.Location = new System.Drawing.Point(39, 137);
            this.currentYear.Name = "currentYear";
            this.currentYear.Size = new System.Drawing.Size(119, 25);
            this.currentYear.TabIndex = 3;
            this.currentYear.Text = "Mevcut Yıl:";
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(310, 13);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 22);
            this.adTextBox.TabIndex = 4;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(310, 52);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadTextBox.TabIndex = 5;
            // 
            // dogumYiliTextBox
            // 
            this.dogumYiliTextBox.Location = new System.Drawing.Point(310, 96);
            this.dogumYiliTextBox.Name = "dogumYiliTextBox";
            this.dogumYiliTextBox.Size = new System.Drawing.Size(100, 22);
            this.dogumYiliTextBox.TabIndex = 6;
            // 
            // guncelYilTextBox
            // 
            this.guncelYilTextBox.Location = new System.Drawing.Point(310, 141);
            this.guncelYilTextBox.Name = "guncelYilTextBox";
            this.guncelYilTextBox.Size = new System.Drawing.Size(100, 22);
            this.guncelYilTextBox.TabIndex = 7;
            // 
            // MaxHeartRate
            // 
            this.MaxHeartRate.AutoSize = true;
            this.MaxHeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaxHeartRate.Location = new System.Drawing.Point(39, 321);
            this.MaxHeartRate.Name = "MaxHeartRate";
            this.MaxHeartRate.Size = new System.Drawing.Size(220, 25);
            this.MaxHeartRate.TabIndex = 8;
            this.MaxHeartRate.Text = "Maksimum Kalp Atışı:";
            // 
            // maxKalpAtisLabelSonuc
            // 
            this.maxKalpAtisLabelSonuc.AutoSize = true;
            this.maxKalpAtisLabelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maxKalpAtisLabelSonuc.Location = new System.Drawing.Point(362, 321);
            this.maxKalpAtisLabelSonuc.Name = "maxKalpAtisLabelSonuc";
            this.maxKalpAtisLabelSonuc.Size = new System.Drawing.Size(74, 25);
            this.maxKalpAtisLabelSonuc.TabIndex = 9;
            this.maxKalpAtisLabelSonuc.Text = "Sonuç";
            // 
            // TargetHeartRateRange
            // 
            this.TargetHeartRateRange.AutoSize = true;
            this.TargetHeartRateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TargetHeartRateRange.Location = new System.Drawing.Point(39, 363);
            this.TargetHeartRateRange.Name = "TargetHeartRateRange";
            this.TargetHeartRateRange.Size = new System.Drawing.Size(174, 25);
            this.TargetHeartRateRange.TabIndex = 10;
            this.TargetHeartRateRange.Text = "Hedef Kalp Atışı:";
            // 
            // hedefKalpAtisLabelSonuc
            // 
            this.hedefKalpAtisLabelSonuc.AutoSize = true;
            this.hedefKalpAtisLabelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedefKalpAtisLabelSonuc.Location = new System.Drawing.Point(362, 363);
            this.hedefKalpAtisLabelSonuc.Name = "hedefKalpAtisLabelSonuc";
            this.hedefKalpAtisLabelSonuc.Size = new System.Drawing.Size(74, 25);
            this.hedefKalpAtisLabelSonuc.TabIndex = 11;
            this.hedefKalpAtisLabelSonuc.Text = "Sonuç";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(458, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(39, 197);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(46, 25);
            this.ad.TabIndex = 13;
            this.ad.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yaş:";
            // 
            // adLabelSonuc
            // 
            this.adLabelSonuc.AutoSize = true;
            this.adLabelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adLabelSonuc.Location = new System.Drawing.Point(362, 197);
            this.adLabelSonuc.Name = "adLabelSonuc";
            this.adLabelSonuc.Size = new System.Drawing.Size(74, 25);
            this.adLabelSonuc.TabIndex = 16;
            this.adLabelSonuc.Text = "Sonuç";
            // 
            // soyadLabelSonuc
            // 
            this.soyadLabelSonuc.AutoSize = true;
            this.soyadLabelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadLabelSonuc.Location = new System.Drawing.Point(362, 236);
            this.soyadLabelSonuc.Name = "soyadLabelSonuc";
            this.soyadLabelSonuc.Size = new System.Drawing.Size(74, 25);
            this.soyadLabelSonuc.TabIndex = 17;
            this.soyadLabelSonuc.Text = "Sonuç";
            // 
            // yasLabelSonuc
            // 
            this.yasLabelSonuc.AutoSize = true;
            this.yasLabelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasLabelSonuc.Location = new System.Drawing.Point(362, 275);
            this.yasLabelSonuc.Name = "yasLabelSonuc";
            this.yasLabelSonuc.Size = new System.Drawing.Size(74, 25);
            this.yasLabelSonuc.TabIndex = 18;
            this.yasLabelSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.yasLabelSonuc);
            this.Controls.Add(this.soyadLabelSonuc);
            this.Controls.Add(this.adLabelSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hedefKalpAtisLabelSonuc);
            this.Controls.Add(this.TargetHeartRateRange);
            this.Controls.Add(this.maxKalpAtisLabelSonuc);
            this.Controls.Add(this.MaxHeartRate);
            this.Controls.Add(this.guncelYilTextBox);
            this.Controls.Add(this.dogumYiliTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.currentYear);
            this.Controls.Add(this.birthYear);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "Kalp Atışı Hesaplayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label birthYear;
        private System.Windows.Forms.Label currentYear;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox dogumYiliTextBox;
        private System.Windows.Forms.TextBox guncelYilTextBox;
        private System.Windows.Forms.Label MaxHeartRate;
        private System.Windows.Forms.Label maxKalpAtisLabelSonuc;
        private System.Windows.Forms.Label TargetHeartRateRange;
        private System.Windows.Forms.Label hedefKalpAtisLabelSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adLabelSonuc;
        private System.Windows.Forms.Label soyadLabelSonuc;
        private System.Windows.Forms.Label yasLabelSonuc;
    }
}

