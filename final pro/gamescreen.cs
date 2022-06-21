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
    {
        List<ball> balls = new List<ball>();
        List<bullet> bullets = new List<bullet>();
        player1 player;
        public int bullettimer = 5;
        public int astroid = 10;
        Random randGen = new Random();
        int health1 = 3;
        int score1 = 0;


        public static Boolean leftArrowDown, rightArrowDown, upArrowDown;
        public int playerWidth;
        public gamescreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            leftArrowDown = rightArrowDown = upArrowDown = false;


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
                case Keys.Up:
                    upArrowDown = false;
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
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }

      

        private void gametimer_Tick(object sender, EventArgs e)
        {
            health.Text = $" {health1}";
            score.Text = $"{score1}";
            bullettimer--;
            astroid--;
            if (astroid == 0)
            {
                int x = randGen.Next(0, 400);
                balls.Add(new ball(x, 1));


                astroid = 50;
            }
            foreach (ball b in balls)
            {
                b.Move();
            }

            foreach (ball b in balls)
            {
                if (b.BottomCollision(this))
                { 
                    balls.Remove(b);
                    health1--;
                    break;
                }
                //if (b.Collision( this))
                //{
                //    balls.Remove((ball)b);
                //    break;
                //}
            }
            foreach (bullet b in bullets)
            {
                b.Move();
            }


            if (upArrowDown && bullettimer < 0)
            {
                bullets.Add(new bullet(player.x + 30, player.y));
                bullettimer = 10;
            }

            if (leftArrowDown && player.x > 0)
            {
                player.Move("left");
            }
            if (rightArrowDown && player.x < (this.Width - player.width))
            {
                player.Move("right");
            }

            //foreach loop that looks at each bullet in your list
            //foreach loop that looks at each ball(asteroid in your list)
            //if (ball.Collision(bullet)
            // remove ball from list
            // remove bullet from list
            //return

            foreach (bullet bull in bullets)
            {
                foreach (ball b in balls)
                {
                    if (b.Collision(bull))
                    {
                        balls.Remove(b);
                        bullets.Remove(bull);
                        score1++;
                        return;
                    }
                }
               
            }
            if(health1 == 0)
            {
                gametimer.Enabled = false;
                Form form = this.FindForm();
                mainmenu go = new mainmenu();
                form.Controls.Add(go);
                form.Controls.Remove(this);
            }
            Refresh();



        }



        private void gamescreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, player.x, player.y, player.width, player.height);

            foreach (bullet b in bullets)
            {
                e.Graphics.FillRectangle(Brushes.Blue, b.x, b.y, b.size, b.size);
            }
            foreach (ball b in balls)
            {
                e.Graphics.FillRectangle(Brushes.DarkRed, b.x, b.y, b.size, b.size);

            }

        }


    }
}
