namespace AdventureGame
{
    partial class AdventureGame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GamenameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // GamenameLabel
            // 
            this.GamenameLabel.BackColor = System.Drawing.Color.Red;
            this.GamenameLabel.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamenameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GamenameLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GamenameLabel.Location = new System.Drawing.Point(350, 10);
            this.GamenameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GamenameLabel.Name = "GamenameLabel";
            this.GamenameLabel.Size = new System.Drawing.Size(500, 80);
            this.GamenameLabel.TabIndex = 4;
            this.GamenameLabel.Text = "Starte das Spiel du Bastard";
            this.GamenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GamenameLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(510, 165);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 50);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start now";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(510, 240);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(180, 50);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settingos";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // creditsButton
            // 
            this.creditsButton.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.Location = new System.Drawing.Point(510, 315);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(180, 50);
            this.creditsButton.TabIndex = 7;
            this.creditsButton.Text = "Creditare";
            this.creditsButton.UseVisualStyleBackColor = true;
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.GamenameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdventureGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventureGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GamenameLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Button button1;
    }
}

