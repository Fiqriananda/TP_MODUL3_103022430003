namespace TP_MODUL3_103022430003
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operand = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string number = btn.Text;

            if (isNewNumber)
            {
                textBox1.Text = number;
                isNewNumber = false;
            }
            else
            {
                textBox1.Text += number;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operation = btn.Text;

            if (!string.IsNullOrEmpty(operand) && !isNewNumber)
            {
                // Calculate previous operation
                CalculateResult();
            }

            result = double.Parse(textBox1.Text);
            operand = operation;
            isNewNumber = true;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operand))
            {
                CalculateResult();
                operand = "";
            }
        }

        private void CalculateResult()
        {
            double currentNumber = double.Parse(textBox1.Text);

            switch (operand)
            {
                case "+":
                    result += currentNumber;
                    break;
                case "-":
                    result -= currentNumber;
                    break;
                case "*":
                    result *= currentNumber;
                    break;
                case "/":
                    if (currentNumber != 0)
                        result /= currentNumber;
                    else
                        textBox1.Text = "Error";
                    break;
            }

            textBox1.Text = result.ToString();
            isNewNumber = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
