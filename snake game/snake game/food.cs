using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace snake_game
{
    public class food
    {
        private int x, y, width, height; //position
        private SolidBrush brush; // draw the food
        public Rectangle foodrec; // food


        public food(Random ranFood) //creation of the begining of food
        {
            x = ranFood.Next(0, 29) * 10; // position left or right
            y = ranFood.Next(0, 29) * 10; // position up or down
            brush = new SolidBrush(Color.Red); //color of food
            width = 10;
            height = 10;
            foodrec = new Rectangle(x, y, width, height); // food parameters

            public void foodLocation(Random ranFood) // position of food
        {
            x = ranFood.Next(0, 29) * 10; // position left or right
            y = ranFood.Next(0, 29) * 10; // position up or down
        }


    
    
        
    }
}
