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



        }
    }
}
