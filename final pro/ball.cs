using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void collision()
        {
        
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
