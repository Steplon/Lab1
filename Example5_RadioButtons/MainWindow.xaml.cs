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

namespace Example5_RadioButtons
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

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            //check what radio button was selected
            bool biggerSelected = rbBigger.IsChecked.Equals(true);
            bool smallerSlected = rbSmaller.IsChecked.Equals(true);

            //display message
            if (biggerSelected)
                MessageBox.Show("Bigger selected");
                else
                MessageBox.Show("Smaller selected");

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //read text box
            string number = textBox.Text;

            //check if num
            bool isNum = int.TryParse(number, out int x);

            //check even/odd if num
            if (isNum)
            {
                if (x % 2 > 0)
                {
                    textBlock.Text = "The number is odd";
                }
                else
                {
                    textBlock.Text = "The number is even";
                }
            }
            else
            {
                textBlock.Text = "Invalid entry, not a number.";
            }

            //display result


        }
    }
}
