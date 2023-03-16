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
    /// Логика взаимодействия для AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Page
    {
        private Client _client;
        private ClientPayerCodes _clientPayerCodes;
        private PayerCode _payerCode;
        public AccountPage(Client client)
        {
            InitializeComponent();
            _client = client;
            //tHello.Text = $"Привет, {client.firstName}";
            _clientPayerCodes = _client.ClientPayerCodes.First();
            _payerCode = _clientPayerCodes.PayerCode1;

            List<PayerCodeServices> listOfServices = new List<PayerCodeServices>();
            listOfServices.AddRange(_payerCode.PayerCodeServices);

            dgServices.ItemsSource = listOfServices;

            tBalance.Text = $"Здравствуйте, {_client.firstName},\nВаш баланс: {_payerCode.balanse}";
        }
    }
}
