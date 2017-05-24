using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var randomNumber = this.GenerateRandomNumber(1, 18);

            this.label1.Text = $"Random Number is {randomNumber}";
        }

        private int GenerateRandomNumber(int min, int max)
        {
            if (min >= max || max <= min)
            {
                throw new ArgumentOutOfRangeException(
                    "The parameter @min should be less than and not equal to the parameter @max" + 
                    $"@min: {min}, @max:{max}");
            }

            return new Random().Next(min, max);
        }
    }
}
