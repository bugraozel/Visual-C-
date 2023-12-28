using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private int seconds = 0;
        

        public Form1()
        {
            InitializeComponent();
            label1.Text = "00:00:00";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer1.Start();
                isRunning = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                isRunning = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            seconds = 0;
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;

            label1.Text = $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            UpdateTimeLabel();
        }
    }
}
