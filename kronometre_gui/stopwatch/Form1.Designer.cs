namespace stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Basla = new System.Windows.Forms.Button();
            this.Durdur = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Basla
            // 
            this.Basla.Location = new System.Drawing.Point(51, 168);
            this.Basla.Name = "Basla";
            this.Basla.Size = new System.Drawing.Size(117, 74);
            this.Basla.TabIndex = 1;
            this.Basla.Text = "Basla";
            this.Basla.UseVisualStyleBackColor = true;
            this.Basla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Durdur
            // 
            this.Durdur.Location = new System.Drawing.Point(211, 168);
            this.Durdur.Name = "Durdur";
            this.Durdur.Size = new System.Drawing.Size(123, 74);
            this.Durdur.TabIndex = 2;
            this.Durdur.Text = "Durdur";
            this.Durdur.UseVisualStyleBackColor = true;
            this.Durdur.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(374, 168);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(132, 74);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 277);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Durdur);
            this.Controls.Add(this.Basla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Basla;
        private System.Windows.Forms.Button Durdur;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer timer1;
    }
}

