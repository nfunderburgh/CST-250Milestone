namespace Minesweeper
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.nameListbox = new System.Windows.Forms.ListBox();
            this.timeListbox = new System.Windows.Forms.ListBox();
            this.scoreListbox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minesweeper HighScores";
            // 
            // nameListbox
            // 
            this.nameListbox.FormattingEnabled = true;
            this.nameListbox.ItemHeight = 15;
            this.nameListbox.Location = new System.Drawing.Point(12, 95);
            this.nameListbox.Name = "nameListbox";
            this.nameListbox.Size = new System.Drawing.Size(120, 94);
            this.nameListbox.TabIndex = 1;
            // 
            // timeListbox
            // 
            this.timeListbox.FormattingEnabled = true;
            this.timeListbox.ItemHeight = 15;
            this.timeListbox.Location = new System.Drawing.Point(157, 95);
            this.timeListbox.Name = "timeListbox";
            this.timeListbox.Size = new System.Drawing.Size(120, 94);
            this.timeListbox.TabIndex = 2;
            // 
            // scoreListbox
            // 
            this.scoreListbox.FormattingEnabled = true;
            this.scoreListbox.ItemHeight = 15;
            this.scoreListbox.Location = new System.Drawing.Point(298, 95);
            this.scoreListbox.Name = "scoreListbox";
            this.scoreListbox.Size = new System.Drawing.Size(120, 94);
            this.scoreListbox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Player Name";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(157, 77);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(37, 15);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(298, 77);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(45, 15);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.SystemColors.Control;
            this.topLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topLabel.Location = new System.Drawing.Point(182, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(79, 30);
            this.topLabel.TabIndex = 7;
            this.topLabel.Text = "Top 5";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(441, 227);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.scoreListbox);
            this.Controls.Add(this.timeListbox);
            this.Controls.Add(this.nameListbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox nameListbox;
        private ListBox timeListbox;
        private ListBox scoreListbox;
        private Label nameLabel;
        private Label timeLabel;
        private Label scoreLabel;
        private Label topLabel;
    }
}