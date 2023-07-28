using System.Diagnostics;

// Author: Noah Funderburgh
// Date: 12/15/2022
// Class: CST-250
// Teacher: Brandon Bass

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        double difficulty = 0;
        PlayerStats ps = new PlayerStats();
        Form4 f4;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            bool buttonChecked = false;

            foreach (RadioButton r in panel1.Controls.OfType<RadioButton>())
            {
                if (r.Text == "Easy" && r.Checked == true)
                {
                    difficulty = 0.2;
                    buttonChecked = true;
                }
                else if (r.Text == "Medium" && r.Checked == true)
                {
                    difficulty = 0.5;
                    buttonChecked = true;
                }
                else if (r.Text == "Hard" && r.Checked == true)
                {
                    //Hard
                    difficulty = 0.8;
                    buttonChecked = true;
                }
            }
            if (buttonChecked == false)
            {
                MessageBox.Show("A radio button wasn't selected");
                return;
            }

            Form2 f2 = new Form2(difficulty, f4, ps);
            this.Hide();
            f2.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                f4 = new Form4(ps);
                f4.Show();
            }
        }
    }
}