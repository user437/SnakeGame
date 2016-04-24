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
             
        

        }
    }
}
