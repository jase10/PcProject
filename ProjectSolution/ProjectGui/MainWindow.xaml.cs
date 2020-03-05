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

namespace ProjectGui
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

       

        private void btnHomeClick(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Close();

        }

        private void btnSearchClick(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();


        }

        private void btnAccountClick(object sender, RoutedEventArgs e)
        {

        }


    }
}
