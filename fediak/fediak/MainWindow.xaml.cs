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

namespace fediak
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVkl_click(object sender, RoutedEventArgs e)
        {
            if (cb1.IsChecked == true && cb2.IsChecked == true && cb3.IsChecked == true)
            {
                tbLamp.Text = "Включена :)";
            }
            else if (cb1.IsChecked == true && cb2.IsChecked == true && cb3.IsChecked == false)
            {
                tbLamp.Text = "Включена :)";
            }
            else if (cb1.IsChecked == true && cb3.IsChecked == true && cb2.IsChecked == false)
            {
                tbLamp.Text = "Включена :)";
            }
            else if (cb2.IsChecked == true && cb3.IsChecked == true && cb1.IsChecked == false)
            {
                tbLamp.Text = "Включена :)";
            }
            else
            {
                tbLamp.Text = "Выключена :(";
            }

        }
    }
}
