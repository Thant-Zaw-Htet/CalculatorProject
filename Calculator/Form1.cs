using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtResult.Text += "+";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            txtResult.Text += "-";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            txtResult.Text += "*";
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            txtResult.Text += "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txtResult.Text, null);
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
