namespace b209_hw1_alper_sahin
{
    public partial class Form1 : Form
    {
        private char process;

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "1";
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "2";
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "3";
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "4";
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "5";
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "6";
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "7";
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "8";
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "9";
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0") calculatorScreen.Text = "";
            calculatorScreen.Text += "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            process = '+';
        }
    }
}