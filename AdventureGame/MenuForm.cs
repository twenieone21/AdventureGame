using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class AdventureGame : Form
    {
        public AdventureGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingsForm sWindow = new SettingsForm();

            sWindow.Show();
        }

        private void creditsButton_Click(object sender, EventArgs e)
        {
            CreditsForm cWindow = new CreditsForm();

            cWindow.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
