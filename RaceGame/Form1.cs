using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOverLabel.Visible = false;
        }
        int _GameSpeed = 0;


        Random rnd = new Random();
        int x;

        void Enemy(int speed)
        {

            if (enemy1.Top >= 550)
            {
                x = rnd.Next(10, 180);

                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }


            if (enemy2.Top >= 500)
            {
                x = rnd.Next(10, 180);

                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }


            if (enemy3.Top >= 500)
            {
                x = rnd.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }


            if (enemy4.Top >= 500)
            {
                x = rnd.Next(200, 350);

                enemy4.Location = new Point(x, 0);
            }
            else
            {
                enemy4.Top += speed;
            }


        }

        void Coin(int speed)
        {

            if (Coin1.Top >= 500)
            {
                x = rnd.Next(30, 370);

                Coin1.Location = new Point(x, 0);
            }
            else
            {
                Coin1.Top += speed;
            }


            if (Coin2.Top >= 500)
            {
                x = rnd.Next(30, 370);

                Coin2.Location = new Point(x, 0);
            }
            else
            {
                Coin2.Top += speed;
            }




            if (Coin3.Top >= 500)
            {
                x = rnd.Next(30, 370);

                Coin3.Location = new Point(x, 0);
            }
            else
            {
                Coin3.Top += speed;
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(_GameSpeed);
            Enemy(_GameSpeed / 2);
            Coin(_GameSpeed);
            CoinCollection();
            GameOver();

        }

        void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else
            { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else
            { pictureBox5.Top += speed; }


            if (pictureBox6.Top >= 500)
            { pictureBox6.Top = 0; }
            else
            { pictureBox6.Top += speed; }
        }

        int collectedCoins = 0;
        void CoinCollection()
        {




            if (MyCar.Bounds.IntersectsWith(Coin1.Bounds))
            {
                x = rnd.Next(10, 180);
                collectedCoins++;
                CoinsLabel.Text = "Coins=" + collectedCoins.ToString();
                Coin1.Location = new Point(x, 0);
            }


            if (MyCar.Bounds.IntersectsWith(Coin2.Bounds))
            {
                x = rnd.Next(10, 180);
                collectedCoins++;
                CoinsLabel.Text = "Coins=" + collectedCoins.ToString();
                Coin2.Location = new Point(x, 0);
            }


            if (MyCar.Bounds.IntersectsWith(Coin3.Bounds))
            {
                x = rnd.Next(10, 180);
                collectedCoins++;
                CoinsLabel.Text = "Coins=" + collectedCoins.ToString();
                Coin3.Location = new Point(x, 0);
            }




        }


        void GameOver()
        {

            if (MyCar.Bounds.IntersectsWith(enemy1.Bounds) || MyCar.Bounds.IntersectsWith(enemy2.Bounds) || MyCar.Bounds.IntersectsWith(enemy3.Bounds) || MyCar.Bounds.IntersectsWith(enemy4.Bounds))
            {

                timer1.Enabled = false;
                GameOverLabel.Visible = true;


            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (MyCar.Left > 0)
                    MyCar.Left -= 8;

            }

            if (e.KeyCode == Keys.Right)
            {
                if (MyCar.Left < 340)
                    MyCar.Left += 8;

            }

            if (e.KeyCode == Keys.Up)
            {
                if (_GameSpeed < 26)
                {
                    _GameSpeed++;
                    _GameSpeed++;
                }
            }


            if (e.KeyCode == Keys.Down)
            {
                if (_GameSpeed > 0)
                {
                    _GameSpeed--;
                    _GameSpeed--;
                }
            }





        }
    }
}
