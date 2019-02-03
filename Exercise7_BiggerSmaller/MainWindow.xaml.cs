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

namespace Exercise7_BiggerSmaller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x, y;
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            //get first random number
            x = rand.Next(1, 21);
            textBlockInitialNumber.Text = "Initial Number:\t" + x.ToString();
        }

        private void BtnGuess_Click(object sender, RoutedEventArgs e)
        {
            //get second random number which is different to x
            do
            {
                y = rand.Next(1, 21);
            } while (y == x);
            
            textBlockSecondNumber.Text = "Second Number:\t" + y.ToString();

            //check which radio selected
            bool biggerSelected = rbBigger.IsChecked.Equals(true);
            bool smallerSelected = rbSmaller.IsChecked.Equals(true);

            //result
            if (biggerSelected && y > x)
            {
                textBlockResult.Text = "You Win!!";
            }
            else if (smallerSelected && x > y)
            {
                textBlockResult.Text = "You Win!!";
            }
            else
            {
                textBlockResult.Text = "You Lose!!";
            }

        }
    }
}
