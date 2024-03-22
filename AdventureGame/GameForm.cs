using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdventureGame
{
    public partial class GameForm : Form
    {
        private Timer timer;
        String name;

        public GameForm()
        {
            InitializeComponent();
            inputBox.KeyDown += InputBox_KeyDown;

            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void storyTextLabel_Click(object sender, EventArgs e)
        {

        }


        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            name = inputBox.Text;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                this.Controls.Remove(inputBox);
                this.Controls.Remove(label1);

                playerNameLabel.Visible = true;
                playerNameLabel.Text = "So your name is " + name + " ...";

                timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            this.Controls.Remove(playerNameLabel);

            storyTextLabel.Text = "Once upon a time there was a big dragon " + name + ".\nBut then there was Fire !!!";
            storyTextLabel.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
