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
using System.Windows.Shapes;

namespace ПР_2_РПМ
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void TB1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = TB1.Text;
            string[] b = a.Split(' ');
            //разбиение строки для создания массива
            
            for (int i = 0; i < b.Length; i++)
                //работа с каждым словом массива
            {
                if (!string.IsNullOrWhiteSpace(b[i]))
                    //если строка не является пустой или только с пррбелами
                {
                    
                    char c = char.ToUpper(b[i][0]);
                    //переменная отвечающая за преведение к верхнему регистру
                    b[i] = c + b[i].Substring(1);
                    //добавляем первую букву которая теперь стала большая к остальной части слова

                }
            }
            TB2.Text = string.Join(" ", b);
            //выводим слова через пробел из массива
        }
    }
}
