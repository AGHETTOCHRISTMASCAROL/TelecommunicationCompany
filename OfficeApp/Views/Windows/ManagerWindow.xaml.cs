﻿using OfficeApp.Core;
using OfficeApp.Views.Pages;
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
using System.Windows.Shapes;

namespace OfficeApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            NavigationManager.CurrentFrame = frameManager;
        }

        private void btnGoToStatement_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigation(new ExecuteStatementPage());
        }
    }
}
