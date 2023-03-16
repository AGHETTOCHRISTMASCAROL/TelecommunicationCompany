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
using WebsiteEmulation.Views.Pages;

namespace WebsiteEmulation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationManager.CurrentFrame = websiteFrame;
            NavigationManager.Navigation(new TempStatementPage());
        }

        private void btnGoToStatement_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new TempStatementPage());
        }

        private void btnGoToLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new LoginPage());

        }
    }
}
