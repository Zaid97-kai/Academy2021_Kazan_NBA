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
    /// Логика взаимодействия для PlayersMainPage.xaml
    /// </summary>
    public partial class PlayersMainPage : Page
    {
        private NBAShort_15Entities _context;
        private int _currentPage = 1;
        private int _countPlayers = 5;
        private int _maxPages;

        public PlayersMainPage()
        {
            InitializeComponent();

            _context = new NBAShort_15Entities();
            //GridPlayers.ItemsSource = context.PlayerInTeams.ToList();

            CmbSeasons.ItemsSource = _context.Seasons.OrderByDescending(season => season.Name).ToList();
            CmbTeams.ItemsSource = _context.Teams.OrderBy(team => team.TeamName).ToList();
            CmbSeasons.SelectedIndex = 0;
            CmbTeams.SelectedIndex = 0;

            RefreshPlayers();
        }

        private void UpdatePlayersDataGrid(object sender, SelectionChangedEventArgs e)
        {
            RefreshPlayers();
        }

        private void RefreshPlayers()
        {
            Team selectedTeam = CmbTeams.SelectedItem as Team;
            Season selectedSeason = CmbSeasons.SelectedItem as Season;
            string searchText = TxtPlayerName.Text;

            List<PlayerInTeam> listPlayers = _context.PlayerInTeams.ToList();
            listPlayers = listPlayers.Where(player => player.Season == selectedSeason).ToList();
            listPlayers = listPlayers.Where(player => player.Team == selectedTeam).ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                listPlayers = listPlayers.Where(player => player.Player.Name.ToLower().Contains(searchText.ToLower())).ToList();
            }

            listPlayers = listPlayers.OrderBy(x => x.ShirtNumber).ToList();

            _maxPages = (int)Math.Ceiling(listPlayers.Count * 1.0 / _countPlayers);

            var listPlayersInPage = listPlayers.Skip((_currentPage - 1) * _countPlayers).Take(_countPlayers).ToList();
            //var listPlayersInPage = listPlayers.GetRange((_currentPage - 1) * _countPlayers, _countPlayers);

            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "of " + _maxPages;
            LblSummaryInfo.Content = $"Total {listPlayers.Count} records, {_countPlayers} records in one page";

            GridPlayers.ItemsSource = listPlayersInPage;
        }

        private void TxtPlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshPlayers();
        }

        private void GoToFirstPage(object sender, RoutedEventArgs e)
        {
            _currentPage = 1;
            RefreshPlayers();
        }

        private void GoToPreviousPage(object sender, RoutedEventArgs e)
        {
            _currentPage--;
            RefreshPlayers();
        }

        private void GoToNextPage(object sender, RoutedEventArgs e)
        {
            _currentPage++;
            RefreshPlayers();
        }

        private void GoToLastPage(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPages;
            RefreshPlayers();
        }
    }
}
