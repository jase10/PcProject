﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Shapes;
//using ProjectGui;

//namespace ProjectGui
//{
//    /// <summary>
//    /// Interaction logic for Window1.xaml
//    /// </summary>
//    public partial class Window1 : Window
//    {
//        //private Cpu _cpu; 
//        CodeLayer Cl;
//        public Window1()
//        {
//            InitializeComponent();
//            Cl = new CodeLayer();
//            PopulateListBox();
            
//        }

//        // Button to change to Home window
//        private void Home_Click(object sender, RoutedEventArgs e)
//        {
//            MainWindow win1 = new MainWindow();
//            win1.Show();
//            Close();
            
//        }

//        // Button Click to change to Account
//        private void Account_Click(object sender, RoutedEventArgs e) 
//        {
//            LoginScreen ls = new LoginScreen();
//            ls.Show();
//            Close();


//        }

//        // Method to Populate List box from Database 
//        private void PopulateListBox()
//        {
//            var listForBox = Cl.GetList();
//            ListBoxCPU.ItemsSource = listForBox;
//            //using (var db = new PartDatabaseContext())
//            //{
//            //    ListBoxCPU.ItemsSource = db.Cpu.ToList();
//            //}
//        }

//        // List Box interaction
//        private void ListBoxCPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            if (ListBoxCPU.SelectedItem != null)
//            {
//                _cpu = (Cpu)ListBoxCPU.SelectedItem;
//                PopulateCPUFields();
//            }
//        }

//        // Populate Method to get values when a user clicks a section
//        private void PopulateCPUFields()
//        {
//            if (_cpu != null)
//            {
//                // ask the code layer for the cpu object
//                tbName1.Text = _cpu.CpuName.ToString();
//                tbCoreCount.Text = _cpu.CoreCount.ToString();
//                tbCoreClock.Text = _cpu.CoreClock.ToString();
//                tbBoostClock.Text = _cpu.BoostClock.ToString();
//                tbTDP.Text = _cpu.Tdp.ToString();
//                tbPrice.Text = _cpu.Price.ToString();
//            }
//        }

//        private void btnSettings_Click(object sender, RoutedEventArgs e)
//        {

//        }
//    }
//}
