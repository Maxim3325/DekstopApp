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
    /// Логика взаимодействия для DirectorPage.xaml
    /// </summary>
    public partial class DirectorPage
    {
        public DirectorPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

            DirectorDG.ItemsSource = Help.MD.Queries.ToList();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        

        private void NeOkBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
