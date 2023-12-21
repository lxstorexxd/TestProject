﻿using System;
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
using TestProject.ViewModels;

namespace TestProject.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeShiftListView.xaml
    /// </summary>
    public partial class EmployeeShiftListView : Page
    {
        public EmployeeShiftListView()
        {
            InitializeComponent();
            DataContext = new EmployeeShiftListViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
