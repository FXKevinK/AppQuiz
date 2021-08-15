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

namespace AppQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int corQues;
        int numQues = 1;
        int ans;
        int nilai;
        int talQues;

        public MainWindow()
        {
            InitializeComponent();

            askQuestion(numQues);

            talQues = 5;
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    Question.Content = "Di mana letak Kota Surabaya?";

                    button1.Content = "Jawa Barat";
                    button2.Content = "Jawa Tengah";
                    button3.Content = "Jawa Timur";
                    button4.Content = "Banten";

                    corQues = 3;

                    break;

                case 2:
                    Question.Content = "1 KM (kilometer) = ... M (meter)";

                    button1.Content = "10000";
                    button2.Content = "1000";
                    button3.Content = "100";
                    button4.Content = "1";

                    corQues = 2;

                    break;

                case 3:
                    Question.Content = "Bagaimana bentuk keping CD?";

                    button1.Content = "Lingkaran";
                    button2.Content = "Persegi";
                    button3.Content = "Segitiga";
                    button4.Content = "Segilima";

                    corQues = 1;

                    break;

                case 4:
                    Question.Content = "Apa mata uang Indonesia?";

                    button1.Content = "Rupee";
                    button2.Content = "Ringgit";
                    button3.Content = "Gulden";
                    button4.Content = "Rupiah";

                    corQues = 4;

                    break;

                case 5:
                    Question.Content = "Galaksi tempat Bumi bernaung?";

                    button1.Content = "Andromeda";
                    button2.Content = "Comet";
                    button3.Content = "Bimasakti";
                    button4.Content = "Butterfly";

                    corQues = 3;

                    break;
            }


        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == corQues)
            {
                ans++;
            }

            if (numQues == talQues)
            {
                nilai = (int)Math.Round((double)(100 * ans) / talQues);

                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "Jawaban benar: " + ans + Environment.NewLine +
                                "Nilai Anda " + nilai + Environment.NewLine);
                ans = 0;
                numQues = 0;
                askQuestion(numQues);
            }

            numQues++;

            askQuestion(numQues);
        }
    }
}
