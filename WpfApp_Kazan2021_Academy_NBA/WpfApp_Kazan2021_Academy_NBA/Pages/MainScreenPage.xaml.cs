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

namespace WpfApp_Kazan2021_Academy_NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainScreenPage.xaml
    /// </summary>
    public partial class MainScreenPage : Page
    {
        public MainScreenPage()
        {
            InitializeComponent();
        }

        private void BtnVisitor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitorMenuPage());
        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function will be implemented later");
        }
    }
}
