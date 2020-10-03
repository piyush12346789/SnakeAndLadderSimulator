using System;
using System.Collections.Generic;
using System.Text;
namespace SnakeAndLadderSimulator
{
    class SL
    {
        public const int STARTING_POSITION = 0;
        public const int WINNING_POSITION = 100;
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
        public int currentPosition = STARTING_POSITION, nextPosition, throws = 0;
        public int RollTheDie()
        {
            Random random = new Random();
            int numOnDie = random.Next(1, 7);
            return numOnDie;
        }
        public int NewPosition(int numOnDie)
        {
            int toAdd = 0;
            Random random = new Random();
            int toDo = random.Next(1, 4);
            switch (toDo)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    toAdd = numOnDie;
                    break;
                case SNAKE:
                    toAdd = -numOnDie;
                    break;
            }
            return toAdd;
        }
        public void PlayATurn()
        {
            int numOnDie = this.RollTheDie();
            this.throws++;
            int toAdd = this.NewPosition(numOnDie);
            //checking if player got ladder, so he rolls the dice again
            if (toAdd > 0)
            {
                this.PlayATurn();
            }
            //checking if next position will exceed 100
            if (this.currentPosition + toAdd > WINNING_POSITION)
            {
                this.nextPosition = this.currentPosition;
            }
            else
            {
                this.nextPosition = this.currentPosition + toAdd;
            }
            //checking if player has moved below starting position
            if (this.nextPosition < STARTING_POSITION)
            {
                this.currentPosition = STARTING_POSITION;
            }
            else
            {
                this.currentPosition = this.nextPosition;
            }
        }
    }
}