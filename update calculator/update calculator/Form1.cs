using System;

namespace update_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Square of first 10 numbers";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateSquares();
        }
        private void CalculateSquares()
        {
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                
                textBox1.Text += $"Square of {i} is: {square}\n";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
