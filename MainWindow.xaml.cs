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
        //List to hold all the teams
        private List<Team> teams = new List<Team>();

        public MainWindow()
        {
            InitializeComponent();
            //Initialize and load data when application is started
            GetData();
        }

        //Method which populates teams and players data
        public void GetData()
        {
            //Adding teams and their players
            teams.Add(new Team
            {
                Name = "France",
                Players = new List<Player>
                {
                    new Player() { Name = "Marie", ResultRecord = "WWDDL" },
                    new Player() { Name = "Claude", ResultRecord = "DDDLW" },
                    new Player() { Name = "Antoine", ResultRecord = "LWDLW" }
                }
            });

            teams.Add(new Team
            {
                Name = "Italy",
                Players = new List<Player>
                {
                    new Player() { Name = "Marco", ResultRecord = "WWDLL" },
                    new Player() { Name = "Giovanni", ResultRecord = "LLLLD" },
                    new Player() { Name = "Valentina", ResultRecord = "DLWWW" }
                }
            });

            teams.Add(new Team
            {
                Name = "Spain",
                Players = new List<Player>
                {
                    new Player() { Name = "Maria", ResultRecord = "WWWWW" },
                    new Player() { Name = "Jose", ResultRecord = "LLLLL" },
                    new Player() { Name = "Pablo", ResultRecord = "DDDDD" }
                }
            });

            //Update team listbox with the new data
            UpdateTeamListBox();
        }

        //Method to update team listbox and sort teams
        private void UpdateTeamListBox()
        {
            //Sort teams based on points
            teams.Sort();
            //Clear current item source
            lbxTeams.ItemsSource = null;
            //Set updated list as new item source
            lbxTeams.ItemsSource = teams;
        }

        //Ensures team listbox is updated on application start
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateTeamListBox();
        }

        //Event handler for when a team is selected from list box
        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxTeams.SelectedItem is Team selectedTeam)
            {
                lbxPlayers.ItemsSource = selectedTeam.Players;
            }
        }

        //Event handler for Win button
        private void btnWin_Click(object sender, RoutedEventArgs e)
        {
            UpdatePlayerResult('W');
        }

        //Event handler for Loss button
        private void btnLoss_Click(object sender, RoutedEventArgs e)
        {
            UpdatePlayerResult('L');
        }

        //Event handler for Draw button
        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            UpdatePlayerResult('D');
        }

        //Method to update the result of a player and refresh the star rating
        private void UpdatePlayerResult(char result)
        {
            if (lbxPlayers.SelectedItem is Player selectedPlayer)
            {
                //Update player's result record
                selectedPlayer.RecordResult(result);
                //Refresh the player listbox to show updated results
                lbxPlayers.Items.Refresh();
                //Refresh team list box with any points changes
                UpdateTeamListBox();
                //Update start rating
                UpdateStarRating(selectedPlayer);
            }
        }

        //Method to update the star rating for a player
        private void UpdateStarRating(Player player)
        {
            //Resets all stars to outline
            imgStar1.Source = new BitmapImage(new Uri("staroutline.png", UriKind.Relative));
            imgStar2.Source = new BitmapImage(new Uri("staroutline.png", UriKind.Relative));
            imgStar3.Source = new BitmapImage(new Uri("staroutline.png", UriKind.Relative));

            //Changes respective star to solid based on player points
            if (player.Points >= 5)
            {
                imgStar1.Source = new BitmapImage(new Uri("starsolid.png", UriKind.Relative));
            }
            if (player.Points >= 10)
            {
                imgStar2.Source = new BitmapImage(new Uri("starsolid.png", UriKind.Relative));
            }
            if (player.Points >= 15)
            {
                imgStar3.Source = new BitmapImage(new Uri("starsolid.png", UriKind.Relative));
            }
        }

    }
}
