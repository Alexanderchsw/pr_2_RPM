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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //создание массива и вывод в текстбокс
            int [] mas = { 2, 3, 4, 1, 7, 9, 12, 8, 9, 10 };
            string c = " ";
            for (int i = 0; i < mas.Length; i++)
            {
                c += mas[i] + " ";

            } TB2.Text = c;
            //подсчет общей суммы и деление её на 2
            int sum = 0;
            foreach (int number in mas)
            {
                sum += number;
            }

            int Sum = sum / 2;
            //промежуточная сумма


            //создаем два списка для цифр с правой и левой части
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            foreach (int number in mas)
                //работаем с каждым числом из массива
            {
                if (left.Sum() + number <= Sum)
                    //если сумма спика с числами левой стороны в сумме с числом с которым происходит работа, дает меньше промежуточной суммы

                {
                    left.Add(number);
                    //то добавляем это число в список левый чисел
                }
                else
                {
                    right.Add(number);
                    //если сумма левого списка с числом дает больше промежуточнй суммы,то это число уходит в список правый
                }
            }
            double leftSum = left.Sum();
            //переменный отвечающие за окончательную сумму левого списка
            double rightSum = right.Sum();
            //переменная отвечающая за окончательную сумму правого списка

            //переменный для вывода информации
            string a = "";
            string b = "";
            string q = "";
            if(Math.Abs(leftSum - rightSum) / Math.Max(leftSum, rightSum) <= 1.5)
            //проверка на условие что разницу сумм двух частей массива не превышает 1,5 раза
            //разница левого и правого списка делится на максимальное значение одного из списков сумм и сравнивается с 1,5
            //Math.Max возвращает большее из двух чисел, т.е из двух сумм списков
            {
                a += string.Join(" ", left);
                b += string.Join(" ", right);
            }else
            {
                TB3.Text = "Невозможно сделать такую операцию";
            }
            q += "Левая часть " + a + "\r\n" + "Правая часть " + b;
            TB3.Text = q;

        }
    }
}
