using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    internal class Team : IComparable<Team>
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        //Property to calculate the total team points
        public int Points
        {
            get
            {
                int totalPoints = 0;
                foreach (var player in Players)
                {
                    totalPoints += player.Points;
                }
                return totalPoints;
            }
        }

        //Override ToString for UI display
        public override string ToString()
        {
            return $"{Name} - {Points}";
        }

        //CompareTo for sorting teams based on points
        public int CompareTo(Team other)
        {
            return other.Points.CompareTo(this.Points);
        }
    }
}
