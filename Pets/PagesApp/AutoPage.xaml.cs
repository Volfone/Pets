using Pets.ClassApp;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace Pets.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((LoginTB.Text != "") && (PasswordTB.Password != ""))
            {
                var DataLogin = DBConnection.Connection.Logins.Where
                    (x => x.Login == LoginTB.Text && x.Password == PasswordTB.Password).FirstOrDefault();
                if (DataLogin != null)
                {

                }
            }

            else
            {
                MessageBox.Show("Incorrect password or login");
            }
        }
    }
}
