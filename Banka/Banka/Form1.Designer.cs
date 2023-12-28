namespace Banka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBakiye = new Label();
            txtMiktar = new TextBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBakiye.Location = new Point(402, 81);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(80, 28);
            lblBakiye.TabIndex = 0;
            lblBakiye.Text = "Bakiye:";
            lblBakiye.Click += lblBakiye_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(402, 141);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(206, 27);
            txtMiktar.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(678, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 141);
            label2.Name = "label2";
            label2.Size = new Size(334, 28);
            label2.TabIndex = 3;
            label2.Text = "Yatırmak İstediğiniz Tutarı Giriniz:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(402, 203);
            button2.Name = "button2";
            button2.Size = new Size(206, 84);
            button2.TabIndex = 4;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(678, 83);
            button3.Name = "button3";
            button3.Size = new Size(162, 29);
            button3.TabIndex = 5;
            button3.Text = "Bakiyeyi Sıfırla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 494);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtMiktar);
            Controls.Add(lblBakiye);
            Name = "Form1";
            Text = "Banka";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBakiye;
        private TextBox txtMiktar;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}