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
    /// Логика взаимодействия для VisitorMenuPage.xaml
    /// </summary>
    public partial class VisitorMenuPage : Page
    {
        public VisitorMenuPage()
        {
            InitializeComponent();
        }

        private void BtnTeams_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function will be implemented later");
        }

        private void BtnPlayers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlayersMainPage());
        }

        private void BtnMatchups_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatchupListPage());
        }


        private void BtnPhotos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function will be implemented later");
        }
    }
}
