using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target_Heart_Rate_Calculator
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
        public class HeartRates
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int BirthYear { get; set; }
            public int CurrentYear { get; set; }

            public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
            {
                FirstName = firstName;
                LastName = lastName;
                BirthYear = birthYear;
                CurrentYear = currentYear;
            }

            public int Age
            {
                get { return CurrentYear - BirthYear; }
            }

            public int MaxHeartRate
            {
                get { return 220 - Age; }
            }

            public string TargetHeartRateRange
            {
                get
                {
                    int minRate = (int)(MaxHeartRate * 0.5); 
                    int maxRate = (int)(MaxHeartRate * 0.85); 
                    return $"{minRate} - {maxRate} BPM";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = adTextBox.Text;
            string lastName = soyadTextBox.Text;
            int birthYear = Convert.ToInt32(dogumYiliTextBox.Text);
            int currentYear = Convert.ToInt32(guncelYilTextBox.Text);

            HeartRates person = new HeartRates(firstName, lastName, birthYear, currentYear);

            adLabelSonuc.Text = $"Ad: {person.FirstName}";
            soyadLabelSonuc.Text = $"Soyad: {person.LastName}";
            yasLabelSonuc.Text = $"Yaş: {person.Age} yaş";
            maxKalpAtisLabelSonuc.Text = $"Maksimum Kalp Atış Hızı: {person.MaxHeartRate} BPM";
            hedefKalpAtisLabelSonuc.Text = $"Hedef Kalp Atış Hızı Aralığı: {person.TargetHeartRateRange}";
        }
    }
}