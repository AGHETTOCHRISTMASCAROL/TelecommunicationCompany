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
    /// Логика взаимодействия для SelectBuildingPage.xaml
    /// </summary>
    public partial class SelectBuildingPage : Page
    {
        public SelectBuildingPage()
        {
            InitializeComponent();
            dgBulding.ItemsSource = Helper.GetContext().Building.ToList();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.CurrentFrame.GoBack();
        }

        public void SearchBulding()
        {
            dgBulding.ItemsSource = Helper.GetContext().Building.ToList()
                .Where(b => 
                b.City.title.Contains(tbSearchCity.Text) && 
                b.Street.title.Contains(tbSearchStreet.Text) && 
                b.houseNumber.Contains(tbSearchHouse.Text));
        }

        private void tbSearchCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBulding();
        }

        private void tbSearchStreet_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBulding();
        }

        private void tbSearchHouse_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBulding();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            Building building = (sender as Button).DataContext as Building;
            StaticContainer.StatementBuilding = building;

            NavigationManager.CurrentFrame.GoBack();
        }
    }
}
