namespace Minesweeper
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.winLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabelForm3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winLabel.Location = new System.Drawing.Point(33, 9);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(230, 27);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "Congrats you won!\r\n";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directionLabel.Location = new System.Drawing.Point(33, 48);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(201, 30);
            this.directionLabel.TabIndex = 1;
            this.directionLabel.Text = "Please enter you name to \r\npossibly join the high scores";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(103, 92);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(129, 23);
            this.nameTextbox.TabIndex = 2;
            // 
            // nameLabelForm3
            // 
            this.nameLabelForm3.AutoSize = true;
            this.nameLabelForm3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabelForm3.Location = new System.Drawing.Point(33, 94);
            this.nameLabelForm3.Name = "nameLabelForm3";
            this.nameLabelForm3.Size = new System.Drawing.Size(45, 15);
            this.nameLabelForm3.TabIndex = 3;
            this.nameLabelForm3.Text = "Name:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(91, 140);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 175);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nameLabelForm3);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.winLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label winLabel;
        private Label directionLabel;
        private TextBox nameTextbox;
        private Label nameLabelForm3;
        private Button submitButton;
    }
}