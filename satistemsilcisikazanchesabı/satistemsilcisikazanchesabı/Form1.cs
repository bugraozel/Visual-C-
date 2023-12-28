using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satistemsilcisikazanchesabı
{
    public partial class Form1 : Form
    {
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            decimal[] itemValues = { 239.99m, 129.75m, 99.95m, 350.89m };

            
            decimal totalSales = 0;
            foreach (decimal itemValue in lstItemsSold.Items)
            {
                totalSales += itemValue;
            }

            decimal commission = 0.09m * totalSales;
            decimal earnings = 400m + commission;

            
            lblEarnings.Text = $"Satış Temsilcisinin Günlük Kazancı: {earnings:C}";
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string inputValue = txtItemValue.Text;
            

            if (decimal.TryParse(inputValue, out decimal value))
            {
                
                lstItemsSold.Items.Add(value);

                
                txtItemValue.Clear();
            }
            else
            {
                MessageBox.Show("Geçersiz değer. Lütfen bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
            btnAddItem.Click += btnAddItem_Click;
            btnClear.Click += btnClear_Click_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            lstItemsSold.Items.Clear();
        }
    }
}

