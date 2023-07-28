using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Noah Funderburgh
// Date: 12/15/2022
// Class: CST-250
// Teacher: Brandon Bass

namespace Minesweeper
{
    public partial class Form3 : Form
    {
        private TimeSpan timeToFinsh;
        PlayerStats stats;
        public Form3(TimeSpan ts, PlayerStats ps)
        {
            InitializeComponent();
            timeToFinsh = ts;
            stats = ps;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Time
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeToFinsh.Hours, timeToFinsh.Minutes, timeToFinsh.Seconds,
            timeToFinsh.Milliseconds / 10);

            //Score
            int totalSeconds = Convert.ToInt32(timeToFinsh.TotalSeconds);
            double score = stats.calculateScore(totalSeconds);

            stats.PlayerHighScores.Add(new PlayerStats(nameTextbox.Text, elapsedTime, score));

            string outPath = @"..\..\..\Highscores.txt";
            List<String> words = File.ReadAllLines(outPath).ToList();

            words.Add(nameTextbox.Text + " " + elapsedTime + " " + score);

            File.WriteAllLines(outPath, words);
           
            this.Close();
        }
    }
}
