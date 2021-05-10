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
using System.Windows.Threading;

namespace Klicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        long point = 300;
        int ppc = 1;
        double sol_b1;
        double sol_b2;
        double sol_b3;
        List<ListRab> LR = new List<ListRab>
        {
            new ListRab(){Name = "Раб Боб", Price = 15800000},
            new ListRab(){Name = "Рабыня Сабина", Price = 1300},
            new ListRab(){Name = "Раб Биба", Price = 151552},
            new ListRab(){Name = "Раб Илья", Price = 99999000},
            new ListRab(){Name = "Раб Абоба", Price = 100005}

        };

        List<Tools> Tool = new List<Tools>
        {
            new Tools(){Nameto = "Йоршик", Priceto = 120},
            new Tools(){Nameto = "Почисулкин", Priceto = 18002},
            new Tools(){Nameto = "ВкусноКорм", Priceto = 99999999},
            new Tools(){Nameto = "Мячик", Priceto = 10000},
            new Tools(){Nameto = "Кошачья Мята", Priceto = 1555000}

        };


        private void Update()
        {
            pointlb.Content = $"Point: {point}";
            ppclb.Content = $"Point on click: {ppc}";
            double sol_b1 = 10 + 10 * (30 + ppc * 0.2);
            double sol_b2 = 20 + 20 * (60 + ppc * 0.4);
            double sol_b3 = 30 + 30 * (90 + ppc * 0.6);

            b1.Content = (sol_b1).ToString();
            b2.Content = (sol_b2).ToString();
            b3.Content = (sol_b3).ToString();
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            point += ppc;
            Update();
        }
        public MainWindow()
        {
            InitializeComponent();
            sol_b1 = 10 + 10 * (30 + ppc * 0.2);
            sol_b2 = 20 + 20 * (60 + ppc * 0.4);
            sol_b3 = 30 + 30 * (90 + ppc * 0.6);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            cbr.ItemsSource = LR;
            tooly.ItemsSource = Tool;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += ppc;

            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b1))
            {
                point -=  Convert.ToInt64(Math.Round(sol_b1));
                ppc += 3;
                Update();

            }
            

        }

        private void ex_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b2))
            {
                point -= Convert.ToInt64(Math.Round(sol_b2));
                ppc += 6;
                Update();

            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b3))
            {
                point -= Convert.ToInt64(Math.Round(sol_b3));
                ppc += 9;
                Update();

            }
        }


        private void BBUY_Click(object sender, RoutedEventArgs e)
        {
            ListRab f = cbr.SelectedItem as ListRab;
            if (f is null)
                return;
            if(point >= f.Price)
            {
                tb_purchases.AppendText(f.Name + "\n");
                point -= f.Price;
            }


        }

        private void Baybuy_Click(object sender, RoutedEventArgs e)
        {
            Tools t = tooly.SelectedItem as Tools;
            if (t is null)
                return;
            if(point >= t.Priceto)
            {
                tb_purchases.AppendText(t.Nameto + "\n");
                point -= t.Priceto;
            }
        }

        private void tooly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbr_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class ListRab
    {
         public string Name { get; set;  }
        public int Price { get; set;  }
    }
    public class Tools
    {
        public string Nameto { get; set; }
        public int Priceto { get; set; }
    }
}
