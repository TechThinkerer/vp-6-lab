using System;
using System.Windows.Forms;

namespace lab_6_part_7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void InitializeClock()
        {
            
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();

           
            UpdateTimeAndDate();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimeAndDate();
        }

        private void UpdateTimeAndDate()
        {
            
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt"); 
            label2.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy"); 
        }

    }
}
