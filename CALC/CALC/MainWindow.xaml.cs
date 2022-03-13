using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CALC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calculator.InputRestriction = 12;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            string cont = b.Content.ToString();

            switch (cont)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    Calculator.EnterNumber(Int32.Parse(cont));
                    break;
                case ".":
                    Calculator.EnterDot();
                    break;
                case "⟵":
                    Calculator.EraseLast();
                    break;
                case "C":
                    Calculator.Clear();
                    break;
                case "+":
                    Calculator.ExecuteOperation(Calculator.CalculatorOperationType.Addition);
                    break;
                case "-":
                    Calculator.ExecuteOperation(Calculator.CalculatorOperationType.Substraction);
                    break;
                case "*":
                    Calculator.ExecuteOperation(Calculator.CalculatorOperationType.Multiplying);
                    break;
                case "/":
                    Calculator.ExecuteOperation(Calculator.CalculatorOperationType.Dividing);
                    break;
                case "=":
                    Calculator.Equal();
                    break;
                case "±":
                    Calculator.ChangeSign();
                    break;
                case "√":
                    Calculator.SquareRoot();
                    break;
            }
        }

        
        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Clipboard.SetText(text.Text);
        }


    }
}