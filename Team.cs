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


        public override string ToString()
        {
            return $"{Name} - Points: {Points}";
        }

        public int CompareTo(Team other)
        {
            return other.Points.CompareTo(this.Points);
        }
    }
}
