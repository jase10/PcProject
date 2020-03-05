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
using ProjectGui;

namespace ProjectGui
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Cpu _cpu;
        Method m;
        public Window1()
        {
            InitializeComponent();
            m = new Method();
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
            var listForBox = m.GetList();
            ListBoxCPU.ItemsSource = listForBox;
            //using (var db = new PartDatabaseContext())
            //{
            //    ListBoxCPU.ItemsSource = db.Cpu.ToList();
            //}
        }


        private void ListBoxCPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxCPU.SelectedItem != null)
            {
                _cpu = (Cpu)ListBoxCPU.SelectedItem;
                PopulateCPUFields();
            }
        }

        private void PopulateCPUFields()
        {
            if (_cpu != null)
            {
                tbName1.Text = _cpu.CpuName.ToString();
                tbCoreCount.Text = _cpu.CoreCount.ToString();
                tbCoreClock.Text = _cpu.CoreClock.ToString();
                tbBoostClock.Text = _cpu.BoostClock.ToString();
                tbTDP.Text = _cpu.Tdp.ToString();
                tbPrice.Text = _cpu.Price.ToString();
            }
        }

    }
}
