using Microsoft.VisualBasic.Devices;
using System.Numerics;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinForms_Lp3
{
    public partial class Form1 : Form
    {
        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int Computer_speed_change = 50;
        int SpielerPunkte = 0;
        int ComputerPunkte = 0;
        int SpielerSpeed = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            ball.Top -= ballYspeed;
            ball.Left -= ballXspeed;
            this.Text = "Spieler Punkte: " + SpielerPunkte + " -- Computer Punkte: " + ComputerPunkte;
            if (ball.Top < 0 || ball.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;
            }
            if (ball.Left < -2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                ComputerPunkte++;
            }
            if (ball.Right > this.ClientSize.Width + 2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                SpielerPunkte++;
            }
            if (Computer.Top <= 1)
            {
                Computer.Top = 0;
            }
            else if (Computer.Bottom >= this.ClientSize.Height)
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }
            if (ball.Top < Computer.Top + (Computer.Height / 2) && ball.Left > 300)
            {
                Computer.Top -= speed;
            }
            if (ball.Top > Computer.Top +   (Computer.Height / 2) && ball.Left > 300)
            {
                Computer.Top += speed;
            }
            Computer_speed_change -= 1;
            if (Computer_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)];
                Computer_speed_change = 50;
            }
            if (goDown && Spieler.Top + Spieler.Height < this.ClientSize.Height)
            {
                Spieler.Top += SpielerSpeed;
            }
            if (goUp && Spieler.Top > 0)
            {
                Spieler.Top -= SpielerSpeed;
            }
            KollisionÜberprüfen(ball, Spieler, Spieler.Right + 5);
            KollisionÜberprüfen(ball, Computer, Computer.Left - 35);
            if (ComputerPunkte > 5)
            {
                GameOver("Sorry you lost the game");
            }
            else if (SpielerPunkte > 5)
            {
                GameOver("You Won this game");
            }
        }
        private void SpielTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyisUp (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void KollisionÜberprüfen(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;
                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];
                if (ballXspeed < 0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed = -x;
                }
                if (ballYspeed < 0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed = y;
                }
            }
        }

        private void GameOver(string message)
        {
            SpielTimer.Stop();
            MessageBox.Show(message, "Says: ");
            ComputerPunkte = 0;
            SpielerPunkte = 0;
            ballXspeed = ballYspeed = 4;
            Computer_speed_change = 50;
            SpielTimer.Start();
        }
    }
}
