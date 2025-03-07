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
    /// Логика взаимодействия для AutchPage.xaml
    /// </summary>
    public partial class AutchPage
    {
        public AutchPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = Help.MD.Users.First(el => el.Login == LoginTb.Text && el.Password == PasswordTb.Text);
            if(user != null && user.Role == "Работник")
            {
                NavigationService.Navigate(new RabotnikPage());
            }

            if (user != null && user.Role == "Менеджер")
            {
                NavigationService.Navigate(new MenagerPage());
            }

            if (user != null && user.Role == "Директор")
            {
                NavigationService.Navigate(new DirectorPage());
            }
        }
    }
}
