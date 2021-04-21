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
        }
        int _GameSpeed = 0;

        void Enemy(int speed)
        {

            if (enemy) { }
        
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(_GameSpeed);
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
                if (_GameSpeed < 25)
                {
                    _GameSpeed++;
                }
            }


            if (e.KeyCode == Keys.Down)
            {
                if (_GameSpeed > 0)
                {
                    _GameSpeed--;
                }
            }



        }
    }
}
