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
    /// Логика взаимодействия для SelectServicesPage.xaml
    /// </summary>
    public partial class SelectServicesPage : Page
    {
        public List<Service> payerCodeServicesList = new List<Service>();
        public SelectServicesPage()
        {
            InitializeComponent();
            dgService.ItemsSource = Helper.GetContext().Service.ToList();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            StaticContainer.StatementListOfServices = payerCodeServicesList;
            NavigationManager.CurrentFrame.GoBack();
        }

        private void chbSelect_Checked(object sender, RoutedEventArgs e)
        {
            Service service = (sender as CheckBox).DataContext as Service;
            payerCodeServicesList.Add(service);
        }

        private void chbSelect_Unchecked(object sender, RoutedEventArgs e)
        {
            Service service = (sender as CheckBox).DataContext as Service;
            payerCodeServicesList.Remove(service);
        }
    }
}
