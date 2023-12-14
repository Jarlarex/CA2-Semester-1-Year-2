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
        //Property to calculate the points based on last five matches
        public int Points
        {
            get
            {
                int points = 0;
                int count = 0;

                //Loop through the last five results and calculate points
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

        //Method to update the player's result record
        public void RecordResult(char result)
        {
            ResultRecord = ResultRecord.Substring(1);

            ResultRecord += result;
        }

        //Override ToString for better UI display
        public override string ToString()
        {
            return $"{Name} - {ResultRecord} - {Points}";
        }

    }
}
