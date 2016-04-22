using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace snake_game
{
    public class snake
    {
        private Rectangle[] snakeRec; // the snake
        private SolidBrush brush; // brush to paint
        private int x, y, width, height; // position

        public Rectangle[] SnakeRec // return the snake
        {
            get { return snakeRec; }
        }

        public snake()
        {
            snakeRec = new Rectangle[3]; // starting size of snake
            brush = new SolidBrush(Color.Black); // snake color

            x = 20; // position left or right
            y = 0; // position up n down
            width = 10;
            height = 10;
            for (int i = 0; i < snakeRec.Length; i++) // new rectangle 
            {
                snakeRec[i] = new Rectangle(x, y, width, height); // saves every rectangle
                x -= 10;
            }
        }

        public void drawSnake(Graphics papel) //draw the snake on  base of the game
        {
            foreach (Rectangle rec in snakeRec)
            {
                papel.FillRectangle(brush, rec); // draw the snake 
            }
        }

        public void drawSnake() // draw the snake on base of game reposition
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];  // draw the snake reposotion
            }
        }

        //snake movement

        public void positionabajo() //position of head down
        {
            drawSnake();
            snakeRec[0].Y += 10; // add 10 to Y down
        }

        public void positionUp() //position of head up
        {
            drawSnake();
            snakeRec[0].Y -= 10; // minus 10 to Y up
        }

        public void positionLeft() //position of head left
        {
            drawSnake(); 
            snakeRec[0].X -= 10;
        }

        public void positionRight() //position of head right
        {
            drawSnake();
            snakeRec[0].X += 10; // add 10 to position X right 
        }


        public void addSnake() //add rectangle more to snake
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();

        }
    }
}