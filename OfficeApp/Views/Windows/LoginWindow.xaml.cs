using OfficeApp.Core;
using OfficeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OfficeApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            cbRole.ItemsSource = Helper.GetContext().PostLogin.ToList();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var pl = cbRole.SelectedItem as PostLogin;
                if (pl.password == pbPassword.Password)
                {
                    if (pl.Post.title == "Модератор")
                    {
                        var w = new ModeratorWindow();
                        w.Show();
                        this.Close();
                    }

                    if (pl.Post.title == "Менеджер")
                    {
                        var w = new ManagerWindow();
                        w.Show();
                        this.Close();
                    }
                }
                else
                {
                    tError.Text = "Неверный пароль";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите роль");
            }
        }
    }
}
