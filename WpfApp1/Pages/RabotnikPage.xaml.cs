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

namespace WpfApp1.Page
{
    /// <summary>
    /// Логика взаимодействия для RabotnikPage.xaml
    /// </summary>
    public partial class RabotnikPage
    {
        private int i = 0; 
        public RabotnikPage()
        {
            InitializeComponent();
            InkrementLb.Content = i.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i += 1;
            InkrementLb.Content = i.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
