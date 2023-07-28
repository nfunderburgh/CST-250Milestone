using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Noah Funderburgh
// Date: 12/15/2022
// Class: CST-250
// Teacher: Brandon Bass

namespace Minesweeper
{
    public class PlayerStats : IComparable<PlayerStats>
    {
        public List<PlayerStats> PlayerHighScores = new List<PlayerStats>();
        public string name { get; set; }
        public string time { get; set; }
        public double score { get; set; }
        public double difficulty { get; set; }

        /*
         * Default Constructor
         */
        public PlayerStats()
        {
            this.name = "";
            this.time = "";
            this.score = 0;
        }

        /*
         * Parameterized Constructor
         */
        public PlayerStats(string name, string time, double score)
        {
            this.name = name;
            this.time = time;
            this.score = score;
        }

        /*
         * Calculates the users score based off difficulty
         * 
         * @param int the amount of seconds the user wins the game in
         * 
         * @return double the users score
         */
        public double calculateScore(int secondsToFinish)
        {
            switch(difficulty){
                case 0.2:
                    return secondsToFinish * 0.2;
                    break;
                case 0.5:
                    return secondsToFinish * 0.5;
                    break;
                case 0.8:
                    return secondsToFinish * 0.8;
                    break;
                default:
                    return 0;
            }
        }

        /*
       * Compares players names and scores
       * 
       * @Param PlayerStats
       */
        public int CompareTo(PlayerStats player)
        {
            if(this.name == player.name)
            {
                return this.score.CompareTo(player.score);
            }
            return player.name.CompareTo(this.name);
        }

        /*
        * Turns a PlayerStats into a string
        * 
        * @return string returns name, time and score in a string
        */
        public string toString()
        {
            return this.name + " " + this.time + " " + this.score;
        }
    }
}
