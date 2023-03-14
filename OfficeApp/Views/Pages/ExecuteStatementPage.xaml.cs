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
    /// Логика взаимодействия для ExecuteStatementPage.xaml
    /// </summary>
    public partial class ExecuteStatementPage : Page
    {
        private Client _client = new Client();
        private PayerCode _payerCode = new PayerCode();
        private ClientPayerCodes _clientPayerCodes = new ClientPayerCodes();
        private List<PayerCodeServices> listOfPayerCodeServices = new List<PayerCodeServices>();
        public ExecuteStatementPage()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            _client.firstName = tbFName.Text;
            _client.lastName = tbLName.Text;
            _client.middleName = tbMName.Text;
            _client.phone = tbPhone.Text;
            _client.login = StringGenerator.RandomString(10); //Не корректно
            _client.password = StringGenerator.RandomString(8);

            _payerCode.payerCode1 = tbPayerCode.Text;
            try
            {
                _payerCode.Building = StaticContainer.StatementBuilding;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            _payerCode.apartment = tbApartment.Text;
            _payerCode.balanse = 0;

            _clientPayerCodes.Client = _client;
            _clientPayerCodes.PayerCode1 = _payerCode;

            StringBuilder errors = new StringBuilder();

            if(string.IsNullOrWhiteSpace(_client.firstName) == true)
            {
                errors.AppendLine("Заполните имя");
            }

            if (string.IsNullOrWhiteSpace(_client.lastName) == true)
            {
                errors.AppendLine("Заполните фамилию");
            }

            if (string.IsNullOrWhiteSpace(_client.phone) == true)
            {
                errors.AppendLine("Заполните телефон");
            }

            if (string.IsNullOrWhiteSpace(_payerCode.apartment) == true)
            {
                errors.AppendLine("Заполните квартиру");
            }

            if (string.IsNullOrWhiteSpace(_payerCode.payerCode1) == true)
            {
                errors.AppendLine("Заполните лицевой счет");
            }

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                foreach (var service in StaticContainer.StatementListOfServices)
                {
                    var payerCodeService = new PayerCodeServices();
                    payerCodeService.PayerCode1 = _payerCode;
                    payerCodeService.Service = service;
                    listOfPayerCodeServices.Add(payerCodeService);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            Helper.GetContext().Client.Add(_client);
            Helper.GetContext().PayerCode.Add(_payerCode);
            Helper.GetContext().ClientPayerCodes.Add(_clientPayerCodes);
            Helper.GetContext().PayerCodeServices.AddRange(listOfPayerCodeServices);

            try
            {
                Helper.GetContext().SaveChanges();
                MessageBox.Show("Успешно");
                //переход
                StaticContainer.StatementBuilding = null;
                StaticContainer.StatementListOfServices.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnSelectBuilding_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new SelectBuildingPage());
        }

        private void btnSelectServices_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new SelectServicesPage());
        }
    }
}
