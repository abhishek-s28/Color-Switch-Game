using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colour_Switch
{
    public partial class Form1 : Form
    {
        List<Color> colours;
        Random rnd = new Random();
        Random blockPosition = new Random();
        int i;
        int speed = 5;
        int score = 0;
        bool gameOver = false;
        int blockColour;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            btnExit.Enabled = true;
            block1.Top += speed;
            block2.Top += speed;
            lblScore.Text = "Score: " + score;

            if (block1.Top > 500)
            {
                blockColour = rnd.Next(colours.Count);
                block1.BackColor = colours[blockColour];
                block1.Top = blockPosition.Next(200, 300) * -1;
                score++;
            }
            if (block2.Top > 500)
            {
                if (block1.Top > 100)
                {
                    blockColour = rnd.Next(colours.Count);
                    block2.BackColor = colours[blockColour];
                    block2.Top = (block1.Top * 8) * -1;
                    score++;
                }
            }
            if (player.Bounds.IntersectsWith(block1.Bounds))
            {
                if (player.BackColor != block1.BackColor)
                {
                    gameTimer.Stop();

                    scoreList.Items.Insert(0, "Scored: " + score + "@" + string.Format("{0:HH:MM}", DateTime.Now));

                    gameOver = true;
                }
            }
            if (player.Bounds.IntersectsWith(block2.Bounds))
            {
                if (player.BackColor != block2.BackColor)
                {
                    gameTimer.Stop();

                    scoreList.Items.Insert(0, "Scored: " + score + "@" + string.Format("{0:HH:mm: ss tt}", DateTime.Now));

                    gameOver = true;
                }
            }
            if (score > 5)
            {
                speed = 6;
            }
            if (score > 10)
            {
                speed = 8;
            }
            if (score > 15)
            {
                speed = 10;
            }
            if (score > 20)
            {
                speed = 12;
            }
            if (score > 25)
            {
                speed = 14;
            }
            if (score > 30)
            {
                speed = 16;
            }
            if (score > 35)
            {
                speed = 18;
            }
            if (score > 40)
            {
                speed = 20;
            }
            if (score > 45)
            {
                speed = 22;
            }
            if (score > 50)
            {
                speed = 24;
            }


            block1.Refresh();
            block2.Refresh();
        }

        private void keyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && gameOver == false)
            {
               i++;

                if (i > colours.Count - 1)
                {
                    i = 0;
                }
                player.BackColor = colours[i];
            }
            if (e.KeyChar == (char)Keys.R && gameOver == true || e.KeyChar == char.ToLower((char)Keys.R) && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
           block1.Top = -80;

           block2.Top = -300;

           gameOver = false;

           colours = new List<Color> { Color.Aqua, Color.Red, Color.Purple, Color.Yellow,};

            i = 0;

            speed = 5;

            score = 0;

            lblScore.Text = "Score: " + score;

            gameTimer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }
    }
}
