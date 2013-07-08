using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorTest;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        private CalculatorHelper calculatorHelper = new CalculatorHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatorHelper.HandleButton1();
            DisplayTextBox.Text = calculatorHelper.DisplayText;
        }
    }
}
