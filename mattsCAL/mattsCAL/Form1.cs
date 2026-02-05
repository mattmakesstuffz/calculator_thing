namespace mattsCAL
{
    public partial class mattsCAL : Form
    {
        public mattsCAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('=')) txtDisplay.Text = string.Empty;
            txtDisplay.Text += '0';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += '-';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += '*';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += '/';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += '+';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CalculateExpression(txtDisplay.Text);
            // Example: "12+5"
            /*char[] operators = { '+', '-', '*', '/' };

            foreach (char op in operators)
            {
                if (txtDisplay.Text.Contains(op))
                {
                    string[] parts = txtDisplay.Text.Split(op);
                    double operand1 = Convert.ToDouble(parts[0]);
                    double operand2 = Convert.ToDouble(parts[1]);

                    double result = 0;

                    switch (op)
                    {
                        case '+': result = operand1 + operand2; break;
                        case '-': result = operand1 - operand2; break;
                        case '*': result = operand1 * operand2; break;
                        case '/': result = operand1 / operand2; break;
                    }

                    //MessageBox.Show("Result: " + result);
                    txtDisplay.Text += "=" + result;
                    return;
                }
            }
            */

            // 1+1
            //char operator = GetOperator()
            //String[] numbers = txtDisplay.Text.Split('+');

            // long total = Add(numbers[0], numbers[1]);
            //txtDisplay.Text += "=" + total.ToString();

        }

        // private char GetOperator(String operatorTxt)
        private void CalculateExpression(string displayText)
        {
            try
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                var result = dt.Compute(displayText, "");
                txtDisplay.Text += "=" + result;
                //MessageBox.Show("Result: " + result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private long Add(String val1, String val2)
        {
            long num1 = long.Parse(val1);
            long num2 = long.Parse(val2);
            return num1 + num2;
        }

        private long Subtract(String val1, String val2)
        {
            long num1 = long.Parse(val1);
            long num2 = long.Parse(val2);
            return num1 - num2;
        }

        private long Multiply(String val1, String val2)
        {
            long num1 = long.Parse(val1);
            long num2 = long.Parse(val2);
            return num1 * num2;
        }

        private long Divide(String val1, String val2)
        {
            long num1 = long.Parse(val1);
            long num2 = long.Parse(val2);
            return num1 / num2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }
    }
}
