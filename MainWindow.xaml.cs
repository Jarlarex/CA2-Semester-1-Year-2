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
            Team t1 = new Team()
            {
                Name = "France",
                Players = new List<Player>
                {
                    new Player() { Name = "Marie", ResultRecord = "WWDDL" },
                    new Player() { Name = "Claude", ResultRecord = "DDDLW" },
                    new Player() { Name = "Antoine", ResultRecord = "LWDLW" }
                }
            };

            Team t2 = new Team()
            {
                Name = "Italy",
                Players = new List<Player>
                {
                    new Player() { Name = "Marco", ResultRecord = "WWDLL" },
                    new Player() { Name = "Giovanni", ResultRecord = "LLLLD" },
                    new Player() { Name = "Valentina", ResultRecord = "DLWWW" }
                }
            };

            Team t3 = new Team()
            {
                Name = "Spain",
                Players = new List<Player>
                {
                    new Player() { Name = "Maria", ResultRecord = "WWWWW" },
                    new Player() { Name = "Jose", ResultRecord = "LLLLL" },
                    new Player() { Name = "Pablo", ResultRecord = "DDDDD" }
                }
            };

            teams.Add(t1);
            teams.Add(t2);
            teams.Add(t3);
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

        ////French players
        //Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
        //Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
        //Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

        ////Italian players
        //Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
        //Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
        //Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

        ////Spanish players
        //Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
        //Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
        //Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };


        //Team t1 = new Team() { Name = "France" };
        //Team t2 = new Team() { Name = "Italy" };
        //Team t3 = new Team() { Name = "Spain" };
    }
}
