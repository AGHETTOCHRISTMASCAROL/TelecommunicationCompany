using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Логика взаимодействия для TempStatementPage.xaml
    /// </summary>
    public partial class TempStatementPage : Page
    {
        private TempStatement _tempStatement = new TempStatement();
        public TempStatementPage()
        {
            InitializeComponent();
            DataContext = _tempStatement;
            _tempStatement.accept = false;
        }

        private void btnSendTempStatement_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_tempStatement.firstName)) { errors.AppendLine("Введите имя");}
            if (string.IsNullOrWhiteSpace(_tempStatement.lastName)) { errors.AppendLine("Введите фамилию"); }
            if (string.IsNullOrWhiteSpace(_tempStatement.phone) | _tempStatement.phone.Length < 10) { errors.AppendLine("Введите 10 значный номер телефона"); }

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }

            Helper.GetContext().TempStatement.Add(_tempStatement);
            try
            {
                Helper.GetContext().SaveChanges();
                MessageBox.Show("Заявка успешно отправлена, с вами свяжется менеджер");
                NavigationManager.Navigation(new LoginPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
