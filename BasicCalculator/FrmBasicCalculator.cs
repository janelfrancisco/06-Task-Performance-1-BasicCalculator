using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);    
            string operation = cbxOperation.SelectedItem.ToString();
            float result = 0;

            if (operation == "+")
            {
                result = BasicComputation.Add((int)num1, (int)num2);
            }
            else if (operation == "-")
            {
                result = BasicComputation.Subtract((int)num1, (int)num2);
            }
            else if (operation == "x")
            {
                result = BasicComputation.Multiply((int)num1, (int)num2);
            }
            else if (operation == "/")
            {
                try
                {
                    result = BasicComputation.Divide((int)num1, (int)num2);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            label3.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
