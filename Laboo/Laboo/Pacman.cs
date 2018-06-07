using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Laboo
{
   
    public class Pacman
    {
        public Point center { get; set; }
        public static readonly int RADIUS = 20;
        public DIRECTION direction { get; set; }
        public int velocity { get; set; }
        public bool isOpen { get; set; }
        int Angle;

        public Pacman()
        {
            velocity = RADIUS;
            center = new Point { X =20, Y = 20};
            direction = DIRECTION.right;
            Angle = 0;
        }
        public void ChangeDirection (DIRECTION direction)
        {
            if(direction==DIRECTION.right)
            {
                Angle = 0;
            }
            if (direction == DIRECTION.up)
            {
                Angle = 1;
            }
            if (direction == DIRECTION.left)
            {
                Angle = 2;
            }
            if (direction == DIRECTION.down)
            {
                Angle = 3;
            }
            
        }
        public void Move(int width, int height)
        {
           
            int nextX = (int)(center.X);
            int nextY = (int)(center.Y);
            int lft = 0;
            int rgt = width;
            int tp = 0;
            int btm = height;
            if (nextX <= lft)
            {
                velocity *= -1;
            }
            if (nextX >= rgt)
            {
                velocity *= -1;
            }
            if (nextY <= tp)
            {
                velocity *= -1;
            }
            if (nextY >= btm)
            {
                velocity *= -1;
            }
            if (Angle == 0)
            {
                nextX = (int)(center.X + velocity);
                nextY = (int)(center.Y);
                center = new Point(nextX, nextY);
            }
            if (Angle == 1)
            {
                nextX = (int)(center.X);
                nextY = (int)(center.Y-velocity);
                center = new Point(nextX, nextY);
            }
            if (Angle == 2)
            {
                nextX = (int)(center.X - velocity);
                nextY = (int)(center.Y);
                center = new Point(nextX, nextY);
            }
            if (Angle == 3)
            {
                nextX = (int)(center.X);
                nextY = (int)(center.Y + velocity);
                center = new Point(nextX, nextY);
            }

        }
    
        public void Draw(Graphics g) 
        {
            Brush b = new SolidBrush(Color.Yellow);
            g.FillEllipse(b, center.X - RADIUS, center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }
    }
}
