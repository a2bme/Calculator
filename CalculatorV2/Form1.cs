using System.Data;
namespace CalculatorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void buttonLeftBracket_Click(object sender, EventArgs e)
        {
            textBox.Text += "(";
        }

        private void buttonRightBracket_Click(object sender, EventArgs e)
        {
            textBox.Text += ")";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = new DataTable().Compute(textBox.Text, "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}