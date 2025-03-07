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
using WpfApp1.Classes;


namespace WpfApp1.Page
{
    /// <summary>
    /// Логика взаимодействия для MenagerPage.xaml
    /// </summary>
    public partial class MenagerPage
    {
        public MenagerPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            MenagerDG.ItemsSource = Help.MD.Users.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
    }
}
