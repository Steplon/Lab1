using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Exercise8_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score;
        double answer;
        bool finished = false;
        private string[] maths = new string[4] {"+","-","*","/" };
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameStart();
            
        }
        

        private async void GameStart()
        {
            button.IsEnabled = false;
            buttonSubmit.IsEnabled = true;
            score = 0;

            for (int i = 0; i < 5; i++)
            {
                finished = false;
                answer = NextQuestion();
                int j = 100;
                do
                {
                    progressBar.Value = j--;
                    await Task.Delay(80);
                    if (finished) j=0;
                } while (j > 0);


            }
            tblkQuestions.Text = "Final Score is " + score.ToString();
            button.IsEnabled = true;
            buttonSubmit.IsEnabled = false;
        }

        private double NextQuestion()
        {
            string selection = maths[rand.Next(0, 4)];
            int x = rand.Next(0, 21);
            int y = rand.Next(0, 21);

            switch (selection)
            {
                case "+":
                    tblkQuestions.Text = string.Format($"Add {x} and {y}");
                    return x + y;
                case "-":
                    tblkQuestions.Text = string.Format($"Subtract {x} from {y}");
                    return y - x;
                case "*":
                    tblkQuestions.Text = string.Format($"Multiply {x} by {y}");
                    return x * y;
                case "/":
                    tblkQuestions.Text = string.Format($"Divide {x} by {y}");
                    return x + y;
            }
            return 0;
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {

            double.TryParse(tbkAnswer.Text, out double submittedAnswer);

            if (submittedAnswer == answer)
            {
                score++;
                tblkScore.Text = string.Format($"Score:\t{score}");
            }
            finished = true;
            tbkAnswer.Clear();
        }

        private void TbkAnswer_GotFocus(object sender, RoutedEventArgs e)
        {
            tbkAnswer.Clear();
        }
    }
}
