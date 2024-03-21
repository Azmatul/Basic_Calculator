using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string operation;
        int result;

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnOne.Content.ToString();
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnTwo.Content.ToString();
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnThree.Content.ToString();
        }

        private void btnFour_Click_1(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnFour.Content.ToString();
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnFive.Content.ToString();
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnSix.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnSeven.Content.ToString();
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnEight.Content.ToString();
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnNine.Content.ToString();
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Text = answerDisplay.Text + btnZero.Content.ToString();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            num1 = int.Parse(answerDisplay.Text);
            answerDisplay.Clear();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            num1 = int.Parse(answerDisplay.Text);
            answerDisplay.Clear();
        }

        private void btnMultiplier_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            num1 = int.Parse(answerDisplay.Text);
            answerDisplay.Clear();
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            num1 = int.Parse(answerDisplay.Text);
            answerDisplay.Clear();
        }

        private void btnModulas_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            num1 = int.Parse(answerDisplay.Text);
            answerDisplay.Clear();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            num2 = int.Parse(answerDisplay.Text);
            if (operation.Equals("+"))
                result = num1 + num2;
            if (operation.Equals("-"))
                result = num1 - num2;
            if (operation.Equals("*"))
                result = num1 * num2;
            if (operation.Equals("/"))
                result = num1 / num2;
            if (operation.Equals("%"))
                result = num1 % num2;
            answerDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            answerDisplay.Clear();
            num1 = 0;
            result = 0;
            num2 = 0;
            operation =null;
        }

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            if(operation == null)
            {
                num1 = 0;
                answerDisplay.Clear();
            }
            else
            {
                num2 = 0;
                answerDisplay.Clear();
            }
        }

        private void btnInvers_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                num1 = int.Parse(answerDisplay.Text);
                if ( num1> 0)
                    num1 *= -1;
                else
                    num1 = Math.Abs(num1);

                answerDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = int.Parse(answerDisplay.Text);
                if (num2 > 0)
                    num2 *= -1;
                else
                    num2 = Math.Abs(num2);

                answerDisplay.Text = num2.ToString();
            }
                
        }
    }
}