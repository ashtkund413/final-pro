using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace final_pro
{
    internal class ball
    {
        public int x, y  ;
        public int size = 60;
        public int Speed = 4;
        public ball(int _x, int _y)
        {
            x = _x;
            y = _y;
            
           
           

        }
        public bool Collision(bullet p )
        {
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(size), Convert.ToInt32(size));
            Rectangle bulletRec = new Rectangle(p.x, p.y, p.width, p.height);
            if (ballRec.IntersectsWith(bulletRec))
            {
                return true;
            }
            return false;
        }
        public bool BottomCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y >= UC.Height)
            {
                didCollide = true;
            }

            return didCollide;
        }

        public void Move()
        {
         
           
            y += Speed;
        }


    }
}
