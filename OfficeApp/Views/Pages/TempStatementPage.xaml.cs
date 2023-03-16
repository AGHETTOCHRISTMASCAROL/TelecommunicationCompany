using OfficeApp.Core;
using OfficeApp.Models;
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

namespace OfficeApp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для TempStatementPage.xaml
    /// </summary>
    public partial class TempStatementPage : Page
    {
        public TempStatementPage()
        {
            InitializeComponent();
            dgTempStatement.ItemsSource = Helper.GetContext().TempStatement.ToList();
        }

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new ExecuteStatementPage((sender as Button).DataContext as TempStatement));
        }
    }
}
