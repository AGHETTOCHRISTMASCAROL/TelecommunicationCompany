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
    /// Логика взаимодействия для HardwarePage.xaml
    /// </summary>
    public partial class HardwarePage : Page
    {
        public HardwarePage()
        {
            InitializeComponent();
            dgHardware.ItemsSource = Helper.GetContext().Hardware.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new AddEditHardwarePage((sender as Button).DataContext as Hardware));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new AddEditHardwarePage(null));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var HardwareForRemoving = dgHardware.SelectedItems.Cast<Hardware>().ToList();
            Helper.GetContext().Hardware.RemoveRange(HardwareForRemoving);
            
            try
            {
                Helper.GetContext().SaveChanges();
                dgHardware.ItemsSource = Helper.GetContext().Hardware.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}