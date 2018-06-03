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

namespace Save_Earth
{
    public partial class Form1 : Form
    {
        public static int spd = 4;
        public int Speed_left = 4;
        public int Speed_top = 4;
        public int point = 0;
        public Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            racket.Top = playground.Bottom - (playground.Bottom / 4);
            pictureBox3.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 4);
            ball.Left += Speed_left;
            ball.Top += Speed_top;

            if (label2.Text == "5")
            {
                Speed_left = 5;
                Speed_top = 5;
                spd = 5;
            }

            if (label2.Text == "10")
            {
                Speed_left = 6;
                Speed_top = 6;
                spd = 6;
            }

            if (label2.Text == "20")
            {
                Speed_left = 7;
                Speed_top = 7;
                spd = 7;
            }

            if (label2.Text == "40")
            {
                Speed_left = 8;
                Speed_top = 8;
                spd = 8;
            }

            if (label2.Text == "60")
            {
                Speed_left = 9;
                Speed_top = 9;
                spd = 9;
            }

            if (label2.Text == "80")
            {
                Speed_left = 10;
                Speed_top = 10;
                spd = 10;
            }

            if (label2.Text == "120")
            {
                Speed_left = 11;
                Speed_top = 11;
                spd = 11;
            }

            if (label2.Text == "170")
            {
                Speed_left = 12;
                Speed_top = 12;
                spd = 12;
            }

            if (label2.Text == "220")
            {
                Speed_left = 13;
                Speed_top = 13;
                spd = 13;
            }

            if (label2.Text == "300")
            {
                Speed_left = 15;
                Speed_top = 15;
                spd = 15;
            }

            if (label2.Text == "400")
            {
                Speed_left = 17;
                Speed_top = 17;
                spd = 17;
            }

            if (label2.Text == "500")
            {
                Speed_left = 19;
                Speed_top = 19;
                spd = 19;
            }

            if (label2.Text == "600")
            {
                Speed_left = 22;
                Speed_top = 22;
                spd = 22;
            }

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                Speed_top += 0;
                Speed_left += 0;
                Speed_top = -Speed_top;
                point += 1;
                ball.Location = new Point(297, 30);
                label2.Text = point.ToString();
            }

            if (ball.Left <= playground.Left)
            {
                Speed_left = -Speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                Speed_left = -Speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                int rInt = r.Next(0, 500); //for ints
                int range = 500;
                int x = r.Next(range);
                ball.Left = x;
                Speed_top = -Speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
            }
            if (timer1.Enabled == false)
            {
                Cursor.Show();
                axWindowsMediaPlayer1.settings.volume = 100;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                DialogResult GameOver = MessageBox.Show("Oh! Earth has been destroyed. Would you like to try again?", "Game Over", MessageBoxButtons.YesNo);
                if (GameOver == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (GameOver == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                if (Speed_top != 0 && Speed_left != 0)
                {
                    Speed_top = 0;
                    Speed_left = 0;
                }
                else if (Speed_top == 0 && Speed_left == 0)
                {
                    Speed_top = spd;
                    Speed_left = spd;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Speed_top != 0 && Speed_left != 0)
            {
                Speed_top = 0;
                Speed_left = 0;
            }
            else if (Speed_top == 0 && Speed_left == 0)
            {
                Speed_top = spd;
                Speed_left = spd;
            }
        }
    }
}
