using System;

namespace lab_6_task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public double ConvertFahrenheitToCelsius(double fahrenheit)
        {
           
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double f))
            {

                double celsius = ConvertFahrenheitToCelsius(f);
                textBox2.Text = celsius.ToString("F2");
            }
            else
            {
                
                MessageBox.Show("Please enter a valid number for Fahrenheit.");
            }
        }
    }
}
