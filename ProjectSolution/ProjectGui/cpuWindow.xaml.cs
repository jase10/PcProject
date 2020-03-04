using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectGui
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Cpu _cpu;
        public Window1()
        {
            InitializeComponent();
            PopulateListBox();
            
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            Close();
            
        }

        private void Account_Click(object sender, RoutedEventArgs e) 
        {
            LoginScreen ls = new LoginScreen();
            ls.Show();
            Close();


        }

        private void PopulateListBox()
        {
            using (var db = new PartDatabaseContext())
            {
                ListBoxCPU.ItemsSource = db.Cpu.ToList();
              

            }
        }


        private void ListBoxCPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PopulateListBox();
        }

        
    }
}
