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

namespace WpfAppN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Q> test = new List<Q>();
        int c = 0;
        int res = 0;
        public MainWindow()
        {

            InitializeComponent();

            Q q1 = new Q();
            q1.q = "1. 33 * 3221";
            q1.a1 = "a. 106293 ";
            q1.a2 = "b. 107866";
            q1.a3 = "c. 233122";
            q1.v = 'a';

            Q q2 = new Q();
            q2.q = "2. 32 / 2";
            q2.a1 = "a. 15";
            q2.a2 = "b. 16";
            q2.a3 = "c. 11";
            q2.v = 'b';

            Q q3 = new Q();
            q3.q = "3. 3232 + 1265";
            q3.a1 = "a. 4497";
            q3.a2 = "b. 5432";
            q3.a3 = "c. 4567";
            q3.v = 'a';

            Q q4 = new Q();
            q4.q = "4. 6555 - 3223";
            q4.a1 = "a. 3332";
            q4.a2 = "b. 3422";
            q4.a3 = "c. 3212";
            q4.v = 'a';

            Q q5 = new Q();
            q5.q = "5. 6555432 + 2435654";
            q5.a1 = "a. 8 992 086";
            q5.a2 = "b. 8 898 888";
            q5.a3 = "c. 8 991 086";
            q5.v = 'c';

            test.Add(q1);
            test.Add(q2);
            test.Add(q3);
            test.Add(q4);
            test.Add(q5);

            NextQ();
        }

        void NextQ()
        {
            Label_Q.Content = test[c].q;
            RadioButton1.Content = test[c].a1;
            RadioButton2.Content = test[c].a2;
            RadioButton3.Content = test[c].a3;
        }

        void Check()
        {
            if (RadioButton1.IsChecked == true)
            {
                if (test[c].v == 'a')
                {
                    res++;
                }
            }
            else
            if (RadioButton2.IsChecked == true)
            {
                if (test[c].v == 'b')
                {
                    res++;
                }
            }
            else
            if (RadioButton3.IsChecked == true)
            {
                if (test[c].v == 'c')
                {
                    res++;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (c < test.Count)
            {
                Check();
                c++;
                if (c < test.Count) NextQ();
                else
                {
                    Label_Q.Content = "Результат: " + res.ToString() + "/" + test.Count.ToString();
                    RadioButton1.Visibility = Visibility.Hidden;
                    RadioButton2.Visibility = Visibility.Hidden;
                    RadioButton3.Visibility = Visibility.Hidden;

                    Btn.Visibility = Visibility.Hidden;
                }
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }



    class Q
    {
        public string q;
        public string a1;
        public string a2;
        public string a3;
        public string a4;

        public char v;
    }
}
