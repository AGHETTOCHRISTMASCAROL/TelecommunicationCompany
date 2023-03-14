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
    /// Логика взаимодействия для AddEditHardwarePage.xaml
    /// </summary>
    public partial class AddEditHardwarePage : Page
    {
        private Hardware _currenHardware = new Hardware();
        public AddEditHardwarePage(Hardware selectHardware)
        {
            InitializeComponent();

            if (selectHardware != null) _currenHardware = selectHardware;

            this.DataContext = _currenHardware;
            cbManufaturer.ItemsSource = Helper.GetContext().Manufacturer.ToList();
            cbType.ItemsSource = Helper.GetContext().TypeOfHardware.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currenHardware.title)) { errors.AppendLine("Укажите название оборудования"); }
            if (_currenHardware.Manufacturer == null) { errors.AppendLine("Укажите производителя"); }
            if (_currenHardware.TypeOfHardware == null) { errors.AppendLine("Укажите тип оборудование"); }

            if(int.TryParse(tbAvailable.Text, out int availableCount) == false | availableCount < 0) { errors.AppendLine("Доступно единиц - целое, неотрицательное число"); }
            if (int.TryParse(tbUsed.Text, out int usedCount) == false | usedCount < 0) { errors.AppendLine("используется единиц - целое, неотрицательное число"); }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if(_currenHardware.idHardware == 0)
            {
                Helper.GetContext().Hardware.Add(_currenHardware);
            }

            try
            {
                Helper.GetContext().SaveChanges();
                MessageBox.Show("Успешно");
                NavigationManager.Navigation(new HardwarePage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
