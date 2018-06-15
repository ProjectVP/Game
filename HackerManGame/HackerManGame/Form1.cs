using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerManGame
{
    public partial class Form1 : Form
    {
        bool goup;
        bool godown;
        bool goleft;
        bool goright;
        int speed = 5;
        int enemy1 = 5;
        int enemy2 = 6;
        int enemy3 = 8;
        int score = 0;
        bool poml = false, pomr = false, pomu = false, pomd = false;
        int desno = 930;
        int dole = 614;
        int gore = 0;
        int levo = 0;
        bool question = true;
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "Score: " + score;
            if (goleft)
            {
                HackerManPic.Left -= speed;

            }
            if (goright)
            {
                HackerManPic.Left += speed;
            }
            if (goup)
            {
                HackerManPic.Top -= speed;

            }
            if (godown)
            {
                HackerManPic.Top += speed;
            }
            Enemy1Pic.Left += enemy1;
            Enemy2Pic.Left += enemy2;
            Enemy3Pic.Left += enemy3;
            if (Enemy1Pic.Bounds.IntersectsWith(Stone1.Bounds))
            {
                Enemy1Pic.Image = Properties.Resources.EnemyRight;
                enemy1 = -enemy1;
            }
            if (Enemy1Pic.Bounds.IntersectsWith(Stone3.Bounds))
            {
                Enemy1Pic.Image = Properties.Resources.EnemyLeft;
                enemy1 = -enemy1;
            }
            if (Enemy2Pic.Bounds.IntersectsWith(Stone2.Bounds))
            {
                Enemy2Pic.Image = Properties.Resources.EnemyRight;
                enemy2 = -enemy2;
            }
            if (Enemy2Pic.Bounds.IntersectsWith(Stone4.Bounds))
            {
                Enemy2Pic.Image = Properties.Resources.EnemyLeft;
                enemy2 = -enemy2;
            }
            if (Enemy3Pic.Bounds.IntersectsWith(Stone3.Bounds))
            {
                Enemy3Pic.Image = Properties.Resources.EnemyRight;
                enemy3 = -enemy3;
            }
            if (Enemy3Pic.Bounds.IntersectsWith(Stone5.Bounds))
            {
                Enemy3Pic.Image = Properties.Resources.EnemyLeft;
                enemy3 = -enemy3;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (x.Bounds.IntersectsWith(HackerManPic.Bounds))
                    {
                        HackerManPic.Left = 0;
                        HackerManPic.Top = 5;
                        score = 0;
                        timer1.Stop();
                        if (MessageBox.Show("Play Again", "End Game", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        {
                            GBStart.Visible = true;
                            GBStart.Enabled = true;
                            godown = false;
                            goleft = false;
                            goright = false;
                            goup = false;
                        }
                        else
                        {
                            GBStart.Visible = false;
                            GBStart.Enabled = false;
                            timer1_Tick(sender, e);
                            timer1.Start();
                            godown = false;
                            goleft = false;
                            goright = false;
                            goup = false;
                        }

                    }
                }
                    if (Stone1.Bounds.IntersectsWith(HackerManPic.Bounds) || Stone2.Bounds.IntersectsWith(HackerManPic.Bounds) || Stone3.Bounds.IntersectsWith(HackerManPic.Bounds) || Stone4.Bounds.IntersectsWith(HackerManPic.Bounds) || Stone5.Bounds.IntersectsWith(HackerManPic.Bounds))
                    {
                        if (poml)
                        {
                            HackerManPic.Left = HackerManPic.Left + 1;
                            speed = 0;
                        }
                        if (pomr)
                        {
                            HackerManPic.Left = HackerManPic.Left - 1;
                            speed = 0;
                        }
                        if (pomu)
                        {
                            HackerManPic.Top = HackerManPic.Top + 1;
                            speed = 0;
                        }
                        if (pomd)
                        {
                            HackerManPic.Top = HackerManPic.Top - 1;
                            speed = 0;
                        }
                    }
                    else
                    {
                        speed = 5;

                    }
            }


            CharacterMove();
        }

        /*if (x is PictureBox && x.Tag == "question")
        {
            if (question == true)
            {
                question = false;
                PBQuestion1.Image = Properties.Resources.qustion1;
                PBQuestion2.Image = Properties.Resources.qustion1;
                PBQuestion3.Image = Properties.Resources.qustion1;
                PBQuestion4.Image = Properties.Resources.qustion1;
            }
            else
            {
                question = true;
                PBQuestion1.Image = Properties.Resources.qustion2;
                PBQuestion2.Image = Properties.Resources.qustion2;
                PBQuestion3.Image = Properties.Resources.qustion2;
                PBQuestion4.Image = Properties.Resources.qustion2;
            }
        }
        */
        public void CharacterMove()
        {
            int desno = 650;
            int dole = 400;
            int gore = 0;
            int levo = 0;
            if (HackerManPic.Location.X < levo)
            {
                HackerManPic.Left = HackerManPic.Left + 1;
                speed = 0;
            }
            else if (HackerManPic.Location.X > desno)
            {
                HackerManPic.Left = HackerManPic.Left - 1;
                speed = 0;
            }
            else if (HackerManPic.Location.Y < gore)
            {
                HackerManPic.Top = HackerManPic.Top + 1;
                speed = 0;
            }
            else if (HackerManPic.Location.Y > dole)
            {
                HackerManPic.Top = HackerManPic.Top - 1;
                speed = 0;
            }
            else
                speed = 5;
        }
        /*public void isBlock(PictureBox S)
        {

                int desno = S.Size.Width-S.Location.X;
                int dole = S.Size.Height-S.Location.Y;
                int gore = S.Location.Y;
                int levo = S.Location.X;
                if (HackerManPic.Location.X > levo)
                {
                    HackerManPic.Left = HackerManPic.Left - 1;
                    speed = 0;
                }
                else if (HackerManPic.Location.X < desno)
                {
                    HackerManPic.Left = HackerManPic.Left + 1;
                    speed = 0;
                }
                else if (HackerManPic.Location.Y > gore)
                {
                    HackerManPic.Top = HackerManPic.Top - 1;
                    speed = 0;
                }
                else if (HackerManPic.Location.Y < dole)
                {
                    HackerManPic.Top = HackerManPic.Top + 1;
                    speed = 0;
                }
                else
                    speed = 5;

        }*/

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                HackerManPic.Image = Properties.Resources.HackermanPicLeft;
                poml = true; pomd = false; pomr = false;pomu = false;

            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
                HackerManPic.Image = Properties.Resources.HackermanPicRight;
                poml = false; pomd = false; pomr = true; pomu = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                HackerManPic.Image = Properties.Resources.HackermanPicLeft;
                poml = false; pomd = true; pomr = false; pomu = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                HackerManPic.Image = Properties.Resources.HackermanPicRight;
                poml = false; pomd = false; pomr = false; pomu = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
           }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }

        }

        private void BStart_Click(object sender, EventArgs e)
        {
            GBStart.Visible = false;
            GBStart.Enabled = false;
            timer1.Start();
        }
    }
}
