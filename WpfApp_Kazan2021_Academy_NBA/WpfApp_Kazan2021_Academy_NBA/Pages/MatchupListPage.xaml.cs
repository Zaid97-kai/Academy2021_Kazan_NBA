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
    /// Логика взаимодействия для MatchupListPage.xaml
    /// </summary>
    public partial class MatchupListPage : Page
    {
        public MatchupListPage()
        {
            InitializeComponent();

            NBAShort_15Entities context = new NBAShort_15Entities();
            ListMatchups.ItemsSource = context.Matchups.ToList();
        }

        private void ShowSelectedMatchup(object sender, RoutedEventArgs e)
        {

        }
    }
}
