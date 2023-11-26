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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(TB1.Text);
            int[] mas = new int[a];
            Random rand = new Random();
            string massiv = "";
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 4);
                massiv += mas[i].ToString() + " ";
            }
            TB2.Text = massiv;

            int count = 1;
            //текущее количество 
            int maxcount = 0;
            //максимальное количество
            for(int i =1; i < mas.Length; i++)
            {
                if (mas[i] == mas[i - 1])
                    //проверяем является ли текущее число таким же как и предыдущее в массиве
                {
                    count++;
                    //увеличиваем количество
                }else
                {
                    if (count > maxcount)
                        //если не является числа одинаковыми, то присваиваем 
                    {
                        maxcount = count;
                        //максимальное значение текущем
                    }
                    count = 1;
                    //вовзаращем текущей значение 1
                }
            }
            if(count > maxcount)
                //проверка на то что выходящее текущее число должно быть меньше
                //или же оно становится максимальным
            {
                maxcount = count;
            }
            string s = "";
            s += maxcount;
            TB3.Text = s;
        }
    }
}
