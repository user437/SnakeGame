﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

using System.Media; //for sounds

namespace snake_game
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(); // object for sound
        Random randfood = new Random(); // object to determine position of food

        Graphics paper; // add game
        snake snakes = new snake(); // add snake
        food food; // Add food
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        int score = 0;     //score
            
            
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawfood(paper);
            snakes.drawSnake(paper);
        }    
             private void Form1_1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                
                        // how to play
        player.SoundLocation = 
        player.Play(); //play sound

            timer1.Enabled = true;
            tutosymaslabel.Text = "";
            spaceBarLabel.Text = "";
            down = false;
            up = false;
            left = false;
            right = true;   //snake is gonna go to the right

            if (e.KeyData == Keys.Down && up == false)          //press space to begin 
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }

            if (e.KeyData == Keys.Up && down == false) //only going up
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

private void timer1_Tick(object sender, EventArgs e) //whats going to happen when timer begins
        {
            snakeScoreLabel.Text = Convert.ToString(score); //actual score

            if (down) {
                snakes.movementDown(); //checking wich ones are true from above 
            }
            if (up) {
                snakes.movementRight(); //method from snake.cs to where the snake is going
            }
            if (right) {
                snakes.movementLeft();
            }
            if (left) {
                snakes.movementLeft();
            }

            this.Invalidate();  //drawing the snake again

            colision(); //if snake crashes if not it grows


            for (int i = 0; i < snakes.SnakesRec.Length; i++) //actual size of snake
            {

                if (snakes.SnakeRec[i].IntersectsWith(food.foodrec)) //if snake touch food
                {
                    player.SoundLocation = ""
                    player.Play();

                    score += 1;     //score 1 plus 1
                    snakes.growSnake();
                    food.locationOfFood(randFood);  //random food position
                }
            }
        }

        public void colision()
        {
            for (int i = 1; i < snakes.SnakeRec.Length; i++)    //snake lenght
            {
                if (snakes.SnakeRec[0].IntersectstWith(snakes.SnakeRec[i])) //is the snakes crashes with the tail
                {
                    player.SoundLocation = ""
                    player.Play();
                    restar();
                }
            }
            if (snakes.SnakeRec[0].Y < 0 || snakes.SnakeRec[0].Y > 290) //if it crashes up or down
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

        private void restart()      //method to restart
        {
            timer1.Enabled = false; //timer off
            snakes = new snake(); //add new snake
            MessageBox.Show("Game Over \n Score : " + score.ToString()); // final message of game
            snakeScoreLabel.Text = "0";  //restart score
            LastScore.Text = score.ToString(); //last score
            score = 0; //restart score variable
            spaceBarLabel,Text = "Press space bar to begin";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start(); //pause the game
            spaceBarLabel.Text = " Pause";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Start(); // continue to play
            spaceBarLabel.Text = "";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            player.SoundLocation = ""
            player.Play();      
        }   


        }
    }

