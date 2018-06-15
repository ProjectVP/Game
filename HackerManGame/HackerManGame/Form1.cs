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
        int qu= 20;
        string[] Question = new string[5];
       



        bool question = true;
        public Form1()
        {
            InitializeComponent();
            Question[0] = "Question 1";
            Question[1] = "Question 2";
            Question[2] = "Question 3";
            
            
           
        }
        public void HackerManMoves()
        {
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
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "Score: " + score;
            HackerManMoves();
            Enemy1Pic.Left += enemy1;
            Enemy2Pic.Left += enemy2;
            Enemy3Pic.Left += enemy3;
            
            timer1.Start();
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
                        System.Windows.Forms.DialogResult  BYesNo = MessageBox.Show("You lost ", "Game Over", MessageBoxButtons.OK);
                        if (BYesNo == System.Windows.Forms.DialogResult.Yes)
                        {
                            GBStart.Visible = false;
                            GBStart.Enabled = false;
                        }
                    }
                }
                if(x is PictureBox && x.Tag == "question")
                {
                   
                    if (((PictureBox)x).Bounds.IntersectsWith(HackerManPic.Bounds))
                    {
                        timer1.Stop();
                        Random r = new Random();
                        int number = r.Next(0, 2);
                        string str = Question[number];
                       
                        if (number == 0)
                        {
                            if (MessageBox.Show("Question 1", str, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                            {
                                score += 10;
                                this.Controls.Remove(x);
                            }
                            else
                            {
                                score -= 5;
                                this.Controls.Remove(x);
                            }
                          //timer1.Start();

                        }
                        if (number == 1)
                        {
                            if (MessageBox.Show("Question 2", str, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                score += 10;
                                this.Controls.Remove(x);
                            }
                            else
                            {
                                score -= 5;
                                this.Controls.Remove(x);
                            }
                          ///  timer1.Start();

                        }
                        if (number == 2)
                        {
                            if (MessageBox.Show("Question 3", str, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                            {
                                score += 10;
                                this.Controls.Remove(x);
                            }
                            else
                            {
                                score -= 5;
                                this.Controls.Remove(x);
                            }

                           

                        }
                       // timer1.Start();



                    }
                                            
                }
                if (x is PictureBox && x.Tag == "computer")
                {
                  
                    if (((PictureBox)x).Bounds.IntersectsWith(HackerManPic.Bounds))
                    {
                        timer1.Stop();

                        ///TUKA TREBA DA TI SE OTVARA NOV LEVEL 
                        if (score >= 0)
                        {
                            System.Windows.Forms.DialogResult YesNo = MessageBox.Show("Play next level", "You win", MessageBoxButtons.OK);
                            if (YesNo == System.Windows.Forms.DialogResult.Yes)
                            {
                                GBStart.Visible = true;
                                GBStart.Enabled = true;
                            }
                        }
                        else
                        {
                            System.Windows.Forms.DialogResult BYesNo = MessageBox.Show("You lost ", "Game Over", MessageBoxButtons.OK);
                            if (BYesNo == System.Windows.Forms.DialogResult.Yes)
                            {
                                GBStart.Visible = true;
                                GBStart.Enabled = true;
                            }
                        }
                       
                    }
                }

            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                HackerManPic.Image = Properties.Resources.HackermanPicLeft;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                HackerManPic.Image = Properties.Resources.HackermanPicRight;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                HackerManPic.Image = Properties.Resources.HackermanPicLeft;

            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                HackerManPic.Image = Properties.Resources.HackermanPicRight;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Start();
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                GBStart.Visible = false;
                GBStart.Enabled = false;
                
                timer1.Stop();
            }
        }
    }
}
