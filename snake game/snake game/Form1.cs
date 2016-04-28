using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace snake_game
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(); // object for sound
        Random randfood = new Random(); // object to determine position of food

        Graphics paper; // add game
        snake snakes = new snake(); // add snake
        Food food; // Add food
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        int score = 0;     
            
            
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawFood(paper);
            snakes.drawSnake(paper);
        }    
             private void Form1_1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                

        player.SoundLocation = 
        player.Play();

            timer1.Enabled = true;
            tutosymasLabel.Text = "";
            spaceBarLabel.Text = "";
            down = false;
            up = false;
            left = false;
            right = true;

            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }

            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }

            if (e.KeyData== Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }

            if (e.KeyData == Keys.Right && left == false)

private void timer1_Tick(object sender, EventArgs e)
        {
            snakeScoreLabel.Text = Convert.ToString(score);

            if (down) {
                snakes.movementDown();
            }
            if (up) {
                snakes.movementRight();
            }
            if (right) {
                snakes.movementLeft();
            }
            if (left) {
                snakes.movementLeft();
            }

            this.Invalidate();

            colision();


            for (int i = 0; i < snakes.SnakesRec.Length; i++)
            {

                if (snakes.SnakeRec[i].IntersectsWith(food.foodrec))
                {
                    player.SoundLocation = ""
                    player.Play();

                    score += 1;
                    snakes.growSnake();
                    food.locationOfFood(randFood);
                }
            }
        }

        public void colision()
        {
            for (int i = 1; i < snakes.SnakeRec.Length; i++)
            {
                if (snakes.SnakeRec[0].IntersectstWith(snakes.SnakeRec[i]))
                {
                    player.SoundLocation = ""
                    player.Play();
                    restar();
                }
            }
            if (snakes.SnakeRec[0].Y < 0 || snakes.SnakeRec[0].Y > 290)
            {
                player.SoundLocation = ""
                player.Play();
                restart();
            }
            if (snakes.SnakeRec[0].Y < 0 || snakes.SnakeRec[0].Y > 290)
            {
                player.SoundLocation = ""
                player.Play();
                restart();
            }

            }

        private void restart()
        {
            timer1.Enabled = false;
            snakes = new snake();
            MessageBox.Show("Game Over \n Score : " + score.ToString());
            snakeScore.Text = "0";
            LastScore.Text = score.ToString();
            score = 0;
            spaceBarLabel,Text = "Press space bar to begin";

        }

        private void Form1_Lad(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            spaceBarLabel.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            player.SoundLocation = ""
            player.Play();
        }


        }
    }

