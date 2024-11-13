using System;

namespace lab_6_task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer.");
                }
                else
                {
                  
                    long factorial = CalculateFactorial(number);
                    textBox2.Text = factorial.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        public long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

    }

       


    
}
