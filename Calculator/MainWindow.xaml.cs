using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        double result;
        string userInput = string.Empty;
        char operation;
        string operand1 = string.Empty;
        string operand2 = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            operand2 = userInput;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if ( operation == '+' )
            {
                result = num1 + num2;
                Display.Text = result.ToString();
            }
            else if ( operation == '-' )
            {
                result = num1 - num2;
                Display.Text = result.ToString();
            }
            else if ( operation == '*' )
            {
                result = num1 * num2;
                Display.Text = result.ToString();
            }
            else if ( operation == '/')
            {
                if ( num2 != 0 )
                {
                    result = num1 / num2;
                    Display.Text = result.ToString();
                }
                else
                {
                    Display.Text = "Cant divide by zero!";
                }
            }

            userInput = string.Empty;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "1";
            this.Display.Text += userInput;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "2";
            this.Display.Text += userInput;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "3";
            this.Display.Text += userInput;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "4";
            this.Display.Text += userInput;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "5";
            this.Display.Text += userInput;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "6";
            this.Display.Text += userInput;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "7";
            this.Display.Text += userInput;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "8";
            this.Display.Text += userInput;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "9";
            this.Display.Text += userInput;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += "0";
            this.Display.Text += userInput;
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            userInput += ".";
            this.Display.Text += userInput;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            operation = '+';
            userInput = string.Empty;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            operation = '-';
            userInput = string.Empty;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            operation = '*';
            userInput = string.Empty;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            operation = '/';
            userInput = string.Empty;
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            this.userInput = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            this.Display.Text = "";
            this.userInput = string.Empty;
        }
    }
}
