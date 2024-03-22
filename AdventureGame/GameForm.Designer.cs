namespace AdventureGame
{
    partial class GameForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.storyTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Papyrus", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(393, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Whats your name?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.Wheat;
            this.inputBox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(460, 239);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(222, 33);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "Enter your Name here...";
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerNameLabel.Location = new System.Drawing.Point(311, 168);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playerNameLabel.Size = new System.Drawing.Size(534, 115);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerNameLabel.Visible = false;
            this.playerNameLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // storyTextLabel
            // 
            this.storyTextLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.storyTextLabel.Location = new System.Drawing.Point(142, 24);
            this.storyTextLabel.Name = "storyTextLabel";
            this.storyTextLabel.Size = new System.Drawing.Size(910, 494);
            this.storyTextLabel.TabIndex = 3;
            this.storyTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.storyTextLabel.Visible = false;
            this.storyTextLabel.Click += new System.EventHandler(this.storyTextLabel_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.storyTextLabel);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventureGame";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label storyTextLabel;
    }
}