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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Team> teams = new List<Team>();

        public MainWindow()
        {
            InitializeComponent();

            GetData();
        }

        public void GetData()
        {
            Team france = new Team()
            {
                Name = "France",
                Players = new List<Player>
                {
                    new Player() { Name = "Marie", ResultRecord = "WWDDL" },
                    new Player() { Name = "Claude", ResultRecord = "DDDLW" },
                    new Player() { Name = "Antoine", ResultRecord = "LWDLW" }
                }
            };

            Team italy = new Team()
            {
                Name = "Italy",
                Players = new List<Player>
                {
                    new Player() { Name = "Marco", ResultRecord = "WWDLL" },
                    new Player() { Name = "Giovanni", ResultRecord = "LLLLD" },
                    new Player() { Name = "Valentina", ResultRecord = "DLWWW" }
                }
            };

            Team spain = new Team()
            {
                Name = "Spain",
                Players = new List<Player>
                {
                    new Player() { Name = "Maria", ResultRecord = "WWWWW" },
                    new Player() { Name = "Jose", ResultRecord = "LLLLL" },
                    new Player() { Name = "Pablo", ResultRecord = "DDDDD" }
                }
            };

            teams.Add(france);
            teams.Add(italy);
            teams.Add(spain);

            lbxTeams.ItemsSource = teams;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxTeams.ItemsSource = teams;
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxTeams.SelectedItem is Team selectedTeam)
            {
                lbxPlayers.ItemsSource = selectedTeam.Players;
            }
        }

        private void btnWin_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnLoss_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
