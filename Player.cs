using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    internal class Player
    {
        public string Name { get; set; }
        public string ResultRecord { get; set; }

        public int Points
        {
            get
            {
                int points = 0;
                int count = 0;

                for (int i = ResultRecord.Length - 1; i >= 0 && count < 5; i--, count++)
                {
                    switch (ResultRecord[i])
                    {
                        case 'W':
                            points += 3;
                            break;
                        case 'D':
                            points += 1;
                            break;
                        case 'L':
                            break;
                    }
                }

                return points;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {ResultRecord} - Points: {Points}";
        }
    }
}
