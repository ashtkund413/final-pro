using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_pro
{
    internal class player1
    {   public int x, y;
        public int width;
        public int height;
        public int speed;
        public player1(int _x, int _y, int _width, int _height, int _speed)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
        }
    }
}
