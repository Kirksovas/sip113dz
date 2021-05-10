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

namespace Zadanie_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pass = "kukuha";
        public MainWindow()
        {
            InitializeComponent();
            lb3.Visibility = Visibility.Hidden;
            lb4.Visibility = Visibility.Hidden;
            lb5.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            date.Visibility = Visibility.Hidden;
            lib1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
            tb1.Visibility = Visibility.Hidden;
            bt2.Visibility = Visibility.Hidden;
            bt3.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Hidden;
      
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            lb1.IsEnabled = true;
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            

            if (tb_password.Text == pass)

            {

                lb1.Visibility = Visibility.Hidden;
                tb_password.Visibility = Visibility.Hidden;
                bt.Visibility = Visibility.Hidden;
                lb3.Visibility = Visibility.Visible;
                lb4.Visibility = Visibility.Visible;
                lb5.Visibility = Visibility.Visible;
                lb2.Visibility = Visibility.Visible;
                date.Visibility = Visibility.Visible;
                lib1.Visibility = Visibility.Visible;
                tb2.Visibility = Visibility.Visible;
                tb1.Visibility = Visibility.Visible;
                bt2.Visibility = Visibility.Visible;
                bt3.Visibility = Visibility.Visible;
                bt4.Visibility = Visibility.Visible;
                bt5.Visibility = Visibility.Visible;

            }
            else
            {
                tb_password.BorderBrush = Brushes.Red;
                MessageBox.Show("Не верный пароль!");
            }
        }

        private void lib1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            tb1.AppendText(tb2.Text + Environment.NewLine);
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            date_ValueChanged();
        }

        private void date_ValueChanged()
        {
            lb_date.Content =  date.DisplayDate;
            date.Visibility = Visibility.Hidden;

        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ListBoxItem)lib1.SelectedItem).Content.ToString();

            tb1.AppendText(text + Environment.NewLine);
        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void date_ValueChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
