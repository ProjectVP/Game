using Laboo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboo
{
    public enum DIRECTION
    {
        left,
        right,
        up,
        down
    };
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        public bool[][] foodWorld;
        public Form1()
        {
            InitializeComponent();
            foodImage = Resources.pic;
            this.DoubleBuffered = true;
            foodWorld = new bool[15][];
            for (int i = 0; i < foodWorld.Length; i++)
            {
                foodWorld[i] = new bool[10];
            }
            
            newGame();
;
        }
        public void newGame()
        {
            pacman = new Pacman();
            this.Width = (int)(Pacman.RADIUS * 2 * (WORLD_WIDTH +0.5));
            this.Height =(int)( Pacman.RADIUS * 2 * (WORLD_HEIGHT + 1));

            // овде кодот за иницијализација на матрицата foodWorld
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    foodWorld[i][j] = true;
                }
            }

            // овде кодот за иницијализација и стартување на тајмерот
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, i * 40+ (40 - foodImage.Height) / 2, j * 40 + (40 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pacman.ChangeDirection(DIRECTION.left);
                    break;
                case Keys.Right:
                    pacman.ChangeDirection(DIRECTION.right);
                    break;
                case Keys.Up:
                    pacman.ChangeDirection(DIRECTION.up);
                    break;
                case Keys.Down:
                    pacman.ChangeDirection(DIRECTION.down);
                    break;
            }
            Invalidate();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int pacmanX = pacman.center.X / (2 * Pacman.RADIUS);
            int pacmanY = pacman.center.Y / (2 * Pacman.RADIUS);
            if(pacmanX<15&& pacmanX >= 0&&pacmanY<10&&pacmanY>=0)
            foodWorld[pacmanX][pacmanY] = false;
            pacman.Move(this.Width,this.Height);
            Invalidate(true);
        }
    }
}
