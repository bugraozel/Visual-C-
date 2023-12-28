using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPoolCalculator
{
    public partial class Form1 : Form
    {
        private const double USDToTRYExchangeRate = 29.40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double günlükMiktarMiles = double.Parse(günlükMiktarMilesTextBox.Text); 
                double benzinGallondaMaliyet = double.Parse(benzinGallondaMaliyetTextBox.Text); 
                double ortalamaMPG = double.Parse(ortalamaMPGTextBox.Text); 
                double parkÜcretleri = double.Parse(parkÜcretleriTextBox.Text); 
                double geçişler = double.Parse(geçişlerTextBox.Text); 

                
                double günlükMiktarKilometers = günlükMiktarMiles * 1.60934;


                double günlükSürüşMaliyetiUSD = (günlükMiktarKilometers / ortalamaMPG) * (benzinGallondaMaliyet / 100) + (parkÜcretleri / 100) + (geçişler / 100);

                double günlükSürüşMaliyetiTL = günlükSürüşMaliyetiUSD * USDToTRYExchangeRate;

                sonuçEtiketi.Text = $"Günlük Maliyet: {günlükSürüşMaliyetiTL:F2} TL";
            }
            catch (FormatException)
            {
                sonuçEtiketi.Text = "Lütfen tüm alanlar için geçerli sayılar girin.";
            }
        }
    }
}
