using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace final_pro
{
    public partial class gamescreen : UserControl
    { List<ball> balls = new List<ball>();
        player1 player;
        public int astroid = 10;
        Random randGen = new Random();
        

        public static Boolean leftArrowDown, rightArrowDown;
        public int playerWidth;
        public gamescreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            leftArrowDown = rightArrowDown = false;

            
            playerWidth = 80;
            int playerHeight = 20;
            int playerX = ((this.Width / 2) - (playerWidth / 2));
            int playerY = (this.Height - playerHeight) - 60;
            int playerSpeed = 8;
            player = new player1(playerX, playerY, playerWidth, playerHeight, playerSpeed);
        }
        private void gamescreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void gamescreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }
        private void gametimer_Tick(object sender, EventArgs e)
        {
           
            astroid--;
            if (astroid == 0)
            {
                int x = randGen.Next(0, 480);
                balls.Add(new ball(x, 1));
                

                astroid = 50;
            }
            foreach(ball b in balls )
            {
                b.Move();
            }

            foreach (ball b in balls)
            {
                if (b.BottomCollision(this))
                {
                    balls.Remove(b);
                    break;
                }
            }

            if (leftArrowDown && player.x > 0)
            {
                player.Move("left");
            }
            if (rightArrowDown && player.x < (this.Width - player.width))
            {
                player.Move("right");
            }

            Refresh();
        }



        private void gamescreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, player.x, player.y, player.width, player.height);

            foreach (ball b in balls)
            {
                e.Graphics.FillRectangle(Brushes.DarkRed, b.x, b.y, b.size,b.size);
               
            }

        }

        
    }
}
