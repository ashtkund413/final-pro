using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_pro
{
    internal class bullet
    {
        public int x, y;
        public int size = 20;
        public int Speed = 6;
        public int height = 20;
        public int width = 20;
        public bullet(int _x, int _y)
        {
            x = _x;
            y = _y;




        }
        public void collision()
        {

        }
        public void Move()
        {


            y -= Speed;
        }

    }

}
