using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class Form2 : Form
    {
        private static Board board = new Board(8);
        private bool[,] flags = new bool[8, 8];
        private static Stopwatch watch = new Stopwatch();
        private Button[,] btnGrid = new Button[board.getSize(), board.getSize()];
        Bitmap bombBitmap = new Bitmap(@"..\..\..\Bomb.png");
        String directory = Directory.GetCurrentDirectory();
        //Bitmap bombBitmap = new Bitmap(@"D:\Github\CST-250\Minesweeper\Bomb.png");
        Bitmap flagBitmap = new Bitmap(@"..\..\..\Flag.png");
        private bool firstClick = true;
        PlayerStats ps;
        Image bombImage;
        Image flagImage;
        Form4 form4;


        public Form2(double difficulty, Form4 f4, PlayerStats ps)
        {
            InitializeComponent();
            bombImage = bombBitmap;
            Debug.WriteLine(directory);
            flagImage = flagBitmap;
            board.difficulty = difficulty;
            ps.difficulty = difficulty;
            board.setupLiveNeighbors(difficulty);
            board.calculateLiveNeighbors();
            populateGrid();
            printBoards(board);
            form4 = f4;
            this.ps = ps;
            KeyPreview = true;
        }

        /*
         * Populates the panel with buttons based on the size of the board
         */
        private void populateGrid()
        {
            int buttonSize = minesweeperPanel.Width / board.getSize();
            minesweeperPanel.Height = minesweeperPanel.Width;

            for (int r = 0; r < board.getSize(); r++)
            {
                for (int c = 0; c < board.getSize(); c++)
                {
                    btnGrid[r, c] = new Button();
                    btnGrid[r, c].Font = new Font("Arial", 24, FontStyle.Bold);
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].MouseDown += Grid_Button_MouseDown;
                    minesweeperPanel.Controls.Add(btnGrid[r, c]);
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c);

                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }

        /*
         * Activates the 
         */
        private void Grid_Button_MouseDown(object? sender, MouseEventArgs e)
        {
            if (firstClick == true)
            {
                watch.Start();
                firstClick = false;
            }

            string[] stringArray = (sender as Button).Tag.ToString().Split("|");
            int row = int.Parse(stringArray[0]);
            int col = int.Parse(stringArray[1]);

            Cell currentCell = board.Grid[row, col];

            switch (e.Button)
            {
                case MouseButtons.Left:
                    
                    if (board.Grid[row, col].Live == true)
                    {
                        for (int r = 0; r < board.getSize(); r++)
                        {
                            for (int c = 0; c < board.getSize(); c++)
                            {
                                board.Grid[r, c].Visited = true;
                            }
                        }
                        updateButtonLabels();
                        watch.Stop();
                        MessageBox.Show("You Lost\nYou spent " + timeElapsed() + " just to lose");
                        watch.Reset();
                        firstClick = true;

                        resetGame();
                        return;
                    }
                    else
                    {
                        board.Grid[row, col].Visited = true;
                        board.FloodFill(row, col);
                        updateButtonLabels();
                    }
                    if (board.winner() == true)
                    {
                        watch.Stop();
                        TimeSpan ts = watch.Elapsed;
                        Form3 f3 = new Form3(ts,ps);
                        f3.Show();
                        watch.Reset();
                        firstClick = true;

                        resetGame();
                        return;
                    }
                    break;

                case MouseButtons.Right:

                    if (flags[row, col] == false)
                    {
                        btnGrid[row, col].Image = (Image)(new Bitmap(flagImage, new Size(btnGrid[row, col].Width - 10, btnGrid[row, col].Height - 10)));
                        flags[row,col] = true;
                    }
                    else
                    {
                        btnGrid[row, col].Image = null;
                        flags[row, col] = false;
                    }
                    break;
            }
        }

        /*
         * Updates buttons neighbors count and live site images
         * 
         */
        private void updateButtonLabels()
        {
            for(int r = 0; r < board.getSize(); r++)
            {
                for(int c = 0; c < board.getSize(); c++)
                {
                    if (board.Grid[r, c].Visited == true && board.Grid[r, c].Live == true)
                    {
                        btnGrid[r, c].Text = "";
                        btnGrid[r, c].Image = (Image)(new Bitmap(bombImage, new Size(btnGrid[r, c].Width-10, btnGrid[r, c].Height-10)));
                        btnGrid[r, c].Enabled = false;
                    }
                    if (board.Grid[r, c].Visited == true && btnGrid[r, c].Enabled == true && board.Grid[r,c].Live != true)
                    {
                        btnGrid[r, c].Image = null;
                        btnGrid[r, c].Text = board.Grid[r, c].Neighbors.ToString();
                        btnGrid[r, c].Enabled = false;
                    }
                    if (board.Grid[r, c].Neighbors == 0 && board.Grid[r, c].Visited == true && board.Grid[r,c].Live != true)
                    {
                        btnGrid[r, c].Image = null;
                        btnGrid[r, c].Text = "";
                        btnGrid[r, c].Enabled = false;
                    }
                }
            }
        }


        /*
         * enables buttons. This is used when the game is over and the game restarts
         * 
         */
        private void enableButtons()
        {
            for (int r = 0; r < board.getSize(); r++)
            {
                for (int c = 0; c < board.getSize(); c++)
                {
                    btnGrid[r, c].Enabled = true;
                }
            }
        }

        /*
         * resets buttons text and images to an empty string or null.
         * 
         */
        private void resetButtons()
        {
            for (int r = 0; r < board.getSize(); r++)
            {
                for (int c = 0; c < board.getSize(); c++)
                {
                    btnGrid[r, c].Text = "";
                    btnGrid[r, c].Image = null;
                }
            }
        }

        /*
         * Prints the board to the debug console
         */
        private static void printBoards(Board obj)
        {
            int boardSize = obj.getSize();

            Debug.Write("  ");
            for (int i = 0; i < boardSize; i++)
            {
                Debug.Write((i) + "   ");
            }
            Debug.WriteLine("");
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (col == 0)
                    {
                        line(boardSize);
                        Debug.WriteLine("+");
                    }
                    if (obj.Grid[col, row].Live == true)
                    {
                        Debug.Write("| * ");
                    }
                    else
                    {
                        Debug.Write("| " + obj.Grid[col, row].Neighbors + " ");
                    }
                }
                Debug.Write("|");
                Debug.Write(" " + (row));
                Debug.WriteLine("");
            }
            line(boardSize);
            Debug.WriteLine("+");
        }

       /*
       * Used to format the spacing in print board
       */
        private static void line(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Debug.Write("+---");
            }
        }

        /*
         * abjusts label1 as the time elapsed changes per tick
         * 
         * @return string  clean string of time elapsed
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsedLabel.Text = "Time Elapsed: " + timeElapsed();
        }


        /*
         * returns a cleaned up version of the time elapsed
         * 
         * @return string  clean string of time elapsed
         */
        private string timeElapsed()
        {
            TimeSpan ts = watch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            return elapsedTime;
        }

        /*
         * Call methods to reset values and start a new game
         */
        private void resetGame()
        {
            board.resetBoard();
            resetButtons();
            enableButtons();
            board.setupLiveNeighbors(board.difficulty);
            board.calculateLiveNeighbors();
            printBoards(board);
        }

        /*
        * OPens high score form when the user presses H
        */
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                form4 = new Form4(ps);
                form4.Show();
            }
        }
    }
}
