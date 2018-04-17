using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalc
{
    
    public partial class MainWindow : Window
    {
        
            Calculator calculator;
            bool isLastButtonOperation = false;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void AddDigitToDisplay(String digit)
        {
            if (isLastButtonOperation)
                Display.Text = "";

            if (Display.Text.Equals("0"))
                Display.Text = digit;
            else
                Display.Text += digit;
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }


        private void btn2_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btnComma_Click_1(object sender, EventArgs e)
        {
            if (!Display.Text.Contains(","))
                if (Display.Text == "0")
                    Display.Text = "0,";
                else
                    AddDigitToDisplay(((Button)sender).Content as String);
        }

        private void btnClearLastSymbol_Click_1(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
            if (Display.Text.Length == 0)
                Display.Text = Convert.ToString(0);
        }

        private void btnMemoryClear_Click_1(object sender, EventArgs e)
        {
            calculator.Memory = 0;
            Display.Text = Convert.ToString(0);
        }

        private void btnMemoryMinus_Click_1(object sender, EventArgs e)
        {
            calculator.Memory -= Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(calculator.Memory);
        }

        private void btnMemoryPlus_Click_1(object sender, EventArgs e)
        {
            calculator.Memory += Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(calculator.Memory);
        }

        private void btnMemory_Click_1(object sender, EventArgs e)
        {
            if (calculator.Memory == 0)
                calculator.Memory = Convert.ToDouble(Display.Text);
            else
                Display.Text = Convert.ToString(calculator.Memory);

        }

        private void btnReverse_Click_1(object sender, EventArgs e)
        {
            if (Display.Text == "0")
                Display.Text = "Division on zero";
            else
                Display.Text = (1 / Convert.ToDouble(Display.Text)).ToString();
        }

        private void btnPercent_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 7;
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(0);
            isLastButtonOperation = false;
        }

        private void btnPow_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 6;
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(0);
            isLastButtonOperation = false;
        }

        private void btnSquareRoot_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 5;
            isLastButtonOperation = true;
            calculator.Calculate();
            Display.Text = calculator.Result;
            isLastButtonOperation = false;
        }

        private void btnSign_Click_1(object sender, EventArgs e)
        {
            Display.Text = (-1 * Convert.ToDouble(Display.Text)).ToString();
        }

        private void btnClearLast_Click_1(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(0);
        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = 0;
            calculator.Operand2 = 0;
            Display.Text = Convert.ToString(0);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            calculator.Operand2 = Convert.ToDouble(Display.Text);
            calculator.Calculate();
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(calculator.Result);
            isLastButtonOperation = false;
        }

        private void btnRaz_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 4;
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(0);
            isLastButtonOperation = false;
        }

        private void btnUmn_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 3;
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(0);
            isLastButtonOperation = false;
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 2;
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(0);
            isLastButtonOperation = false;
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            calculator.Operand1 = Convert.ToDouble(Display.Text);
            calculator.Operation = 1;
            isLastButtonOperation = true;
            Display.Text = Convert.ToString(0);
            isLastButtonOperation = false;
        }
        
    }
}
