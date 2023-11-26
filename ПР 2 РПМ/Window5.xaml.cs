using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int m = Convert.ToInt32(TB1.Text);
            int n = Convert.ToInt32(TB2.Text);
            int[,] mas = new int[m,n];
            Random rnd = new Random();
            string c = "";
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++) { 
                    mas[i, j] = rnd.Next(-10, 10);
                    c += mas[i,j].ToString() + " ";
                }
              c += "\r\n";

            }  TB3.Text = c;

            //нахождение минимума и максимума
            int max = mas[0, 0];
            int min = mas[0, 0];
            string max1 = "";
            string min1 = "";
            for (int i = 0;i<m;i++)
            {
                for (int j = 0;j < n;j++)
                {
                    if (mas[i, j] > max)
                    {
                        max= mas[i, j];
                    
                    } else if (mas[i, j] < min)
                    {
                        min= mas[i, j];
                    }
                }
            }
            max1 += max;
            min1 += min;
            TB6.Text = max1;
            TB7.Text = min1;

            //сортировка по возрастанию
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            // Сравниваем элементы и меняем их местами, если нужно
                            if (mas[i, j] < mas[x, y])
                            {
                                int temp = mas[i, j];
                                mas[i, j] = mas[x, y];
                                mas[x, y] = temp;
                            }
                        }
                    }
                }
            }
            string f = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    f += mas[i, j].ToString() + " ";
                }
                f += "\r\n";

            }
            TB4.Text = f;

            //сортировка по убыванию
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            // Сравниваем элементы и меняем их местами, если нужно
                            if (mas[i, j] > mas[x, y])
                            {
                                int temp = mas[i, j];
                                mas[i, j] = mas[x, y];
                                mas[x, y] = temp;
                            }
                        }
                    }
                }
            }
            string ff = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    ff += mas[i, j].ToString() + " ";
                }
                ff += "\r\n";

            }
            TB5.Text = ff;

        }
    }
}
