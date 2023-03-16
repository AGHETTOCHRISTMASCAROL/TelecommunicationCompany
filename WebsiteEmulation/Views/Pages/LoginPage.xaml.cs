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
using WebsiteEmulation.Core;
using WebsiteEmulation.Models;

namespace WebsiteEmulation.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = pbPassword.Password.ToString();
            Client client;

            if(Helper.GetContext().Client.Any(c => c.login == login && c.password == password))
            {
                client = Helper.GetContext().Client.Where(c => c.login == login && c.password == password).First();
                NavigationManager.Navigation(new AccountPage(client));
            }
            else
            {
                tError.Text = "Неправильный логин или пароль";
            }
        }
    }
}
