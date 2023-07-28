using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;

// Author: Noah Funderburgh
// Date: 12/15/2022
// Class: CST-250
// Teacher: Brandon Bass

namespace Minesweeper
{
    public partial class Form4 : Form
    {
        PlayerStats ps;
        List<string> outputLines = new List<string>();

        public Form4(PlayerStats ps)
        {
            InitializeComponent();
            this.ps = ps;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string outPath = @"..\..\..\Highscores.txt";

            List<String> words = File.ReadAllLines(outPath).ToList();
            ps.PlayerHighScores.Clear();
            foreach (string word in words)
            {
                string[] entries = word.Split(' ');
                ps.PlayerHighScores.Add(new PlayerStats(entries[0], entries[1], Convert.ToDouble(entries[2])));
            }

            foreach (PlayerStats p in ps.PlayerHighScores)
            {
                outputLines.Add(p.toString());
            }
            File.WriteAllLines(outPath, outputLines);


            var sortScores =(
               from player in ps.PlayerHighScores
               orderby player.score descending
               select player).Take(5);


            foreach (var player in sortScores)
            {
                nameListbox.Items.Add(player.name);
                timeListbox.Items.Add(player.time);
                scoreListbox.Items.Add(player.score);
            }
        }
    }
}
