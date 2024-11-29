namespace Iterative_problem_1
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        int result;
        public Form1()
        {
            InitializeComponent();
            number1 = 0;
            number2 = 0;
            result = 0;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(txtNumber.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            result = MultiplicationR(number1, number2);
            MessageBox.Show("Result: " + result);
            
        }

        int MultiplicationR(int number1, int number2)
        {
            if (number2 == 0) 
            {
                return 0;
            }

            if (number2 > 0)
            {
                return number1 + MultiplicationR(number1,number2 - 1);
                
            }
            else
            {
                return -MultiplicationR(number1,number2);
            }

        }
    }
}
