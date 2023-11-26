using System;
using System.Collections.Generic;
using System.ComponentModel;
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


namespace ПР_2_РПМ
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
       

        public Window1()
        {
            InitializeComponent();
            NavigationService nav = NavigationService.GetNavigationService(this);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string d = TB1.Text;
            int c = Convert.ToInt32(d);

            if (c <= 1000)
            {
                int q = (int)Math.Pow(c, c);
              
                var numberCounter = new int[10];
                while (q > 0)
                {
                    int index = q % 10;
                    numberCounter[index]++;
                    q /= 10; 

                }
                string w = "Количество повторений каждой цифры: ";
                for (var i = 0; i < numberCounter.Count(); i++)
                {
                   w += $"Цифра {i}: {numberCounter[i]}\r\n";

                }
               
                 

            }
            else 
            {
                MessageBox.Show("Число должно быть <= 1000");
            }
        }
    }
}
