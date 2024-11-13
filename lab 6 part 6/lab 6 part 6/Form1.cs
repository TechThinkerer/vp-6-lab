namespace lab_6_part_6
{
    public partial class Form1 : Form
    {
        private int countdownTime;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out countdownTime) && countdownTime > 0)
            {

                label1.Text = $"Time Remaining: {countdownTime} seconds";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownTime--;

           
            label1.Text = $"Time Remaining: {countdownTime} seconds";

            
            if (countdownTime <= 0)
            {
                
                timer1.Stop();

               
                MessageBox.Show("Time's up!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

