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

namespace ПР_2_РПМ
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 z1 = new Window1();
            z1.Owner = this;
            this.Hide();
            z1.ShowDialog();
            this.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 z1 = new Window2();
            z1.Owner = this;
            this.Hide();
            z1.ShowDialog();
            this.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 z1 = new Window3();
            z1.Owner = this;
            this.Hide();
            z1.ShowDialog();
            this.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 z1 = new Window4();
            z1.Owner = this;
            this.Hide();
            z1.ShowDialog();
            this.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 z1 = new Window5();
            z1.Owner = this;
            this.Hide();
            z1.ShowDialog();
            this.Show();
        }
    }
}
