using System;
using System.Windows.Forms;
namespace lab_6_task_9
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"Characters left: {MaxCharacters}";

            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int remainingCharacters = MaxCharacters - textBox1.Text.Length;
            label1.Text = $"Characters left: {remainingCharacters}";

            if (textBox1.Text.Length > MaxCharacters)
            {
                textBox1.Text = textBox1.Text.Substring(0, MaxCharacters);
                textBox1.SelectionStart = textBox1.Text.Length; 
            }
        }
    }
}
