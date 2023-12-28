namespace Banka
{
    public partial class Form1 : Form
    {
        private decimal bakiye = 0;
        public Form1()
        {
            InitializeComponent();
            lblBakiye.Text = "Bakiye: ₺" + bakiye.ToString("N2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMiktar.Clear();
            MessageBox.Show("Yatırmak İstediğiniz tutar temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMiktar.Text, out decimal yatirilanMiktar))
            {
                bakiye += yatirilanMiktar;

                lblBakiye.Text = "Bakiye:₺" + bakiye.ToString("N2");

                MessageBox.Show("Para yatırma işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Geçersiz miktar girişi. Lütfen doğru bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bakiye = 0;
            lblBakiye.Text = "Bakiye: ₺" + bakiye.ToString("N2");
            MessageBox.Show("Bakiye sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblBakiye_Click(object sender, EventArgs e)
        {
           
        }
    }
}