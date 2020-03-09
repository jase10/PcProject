using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace ProjectGui
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        // Login Click 
        private void Login_Click(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
                //var userLogin = username.Text;
                //var userPassword = password.Password;
                ////StoredUserName = UsernameText.Text;
                //using (var db = new PartDatabaseContext())
                //{

                //    var LoginQuery =
                //    from Users in db.Users
                //    where Users.Username == userLogin
                //    where Users.uPassword == userPassword
                //    select account;

                //    foreach (var logins in LoginQuery)
                //    {
                //        if (userLogin == logins.UserName && userPassword == logins.UserPass)
                //        {
                //            MainWindow window = new MainWindow();
                //            window.Show();
                //            Close();

                           
                //        }
                //        else
                //        {
                //            wrongItem.Text = "Wrong Username or/and Password";
                //        }
                //    }
=======


            var userLogin = username.Text;
            var userPassword = password.Password;
            //StoredUserName = UsernameText.Text;
            using (var db = new PartDatabaseContext())
            {

                var LoginQuery =
                from Users in db.Users
                where Users.Username == userLogin
                where Users.UPassword == userPassword
                select Users;

                foreach (var logins in LoginQuery)
                {
                    if (userLogin == logins.Username && userPassword == logins.UPassword)
                    {
                        MainWindow window = new MainWindow();
                        window.Show();
                        Close();
>>>>>>> f39bdaaaf2083900506cdac411ad5fe512694e0b


                    }
                    else
                    {
                        wrongItem.Text = "Wrong Username or/and Password";
                    }
                }




<<<<<<< HEAD
                //}
=======
>>>>>>> f39bdaaaf2083900506cdac411ad5fe512694e0b


            }

            
        }

        // Register Click
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow rn = new RegisterWindow();
            rn.Show();
            Close(); 
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
