namespace b209_hw1_alper_sahin
{
    public partial class Form1 : Form
    {
        private char process;
        private bool cleanScreen;
        private int firstNumber;

        public Form1()
        {
            InitializeComponent();
        }


        private void numberOne_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "1";
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "2";
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "3";
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "4";
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "5";
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "6";
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "7";
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "8";
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "9";
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            if (cleanScreen)
            {
                calculatorScreen.Text = "";
                cleanScreen = false;
            }

            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            process = '+';
            cleanScreen = true;
            firstNumber = Convert.ToInt32(calculatorScreen.Text);
        }
        private void substractionButton_Click(object sender, EventArgs e)
        {
            process = '-';
            cleanScreen = true;
            firstNumber = Convert.ToInt32(calculatorScreen.Text);

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            process = '/';
            cleanScreen = true;
            firstNumber = Convert.ToInt32(calculatorScreen.Text);
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            process = '*';
            cleanScreen = true;
            firstNumber = Convert.ToInt32(calculatorScreen.Text);
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int secondNumber = Convert.ToInt32(calculatorScreen.Text);
            int result;

            switch (process)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                default:
                    result = 0; break;
            }

            calculatorScreen.Text = Convert.ToString(result);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "0";
        }
    }
}