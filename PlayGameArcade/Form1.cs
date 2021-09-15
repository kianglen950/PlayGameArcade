using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGameArcade
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.download);
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.PowerUp);

            startButton.Hide();

            outputLabel.Show();
            outputLabel.Text = "Game starting in: ";

            outputLabel.Text = "Game starting in: 3";
            Thread.Sleep(1000);
            Refresh();
            
            alertPlayer.Play();
            
            outputLabel.Text = "Game starting in: 2";
            Thread.Sleep(1000);
            Refresh();
            
            alertPlayer.Play();

            outputLabel.Text = "Game starting in: 1";
            Thread.Sleep(1000);
            Refresh();

            alertPlayer.Play();
           
            outputLabel.Text = "Go!!";
            Thread.Sleep(1000);
            Refresh();

            soundPlayer.Play();
            outputLabel.BackColor = Color.LawnGreen;

           this.BackColor = Color.LawnGreen;
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
