using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int STARTING_POSITION = 0;
        public const int WINNING_POSITION = 100;
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
        //Returns Output Of Die Roll
        public static int RollTheDie()
        {
            Random random = new Random();
            int numOnDie = random.Next(1, 7);
            return numOnDie;
        }
        //Returns Increment Or Decrement to be Made with Current Position
        public static int NewPosition(int numOnDie)
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
        static void Main(string[] args)
        {
            int currentPosition = STARTING_POSITION, nextPosition;
            int throws = 0;
            while (currentPosition < WINNING_POSITION)
            {
                int numOnDie = RollTheDie();
                throws++;
                int toAdd = NewPosition(numOnDie);
                //checking if next position will exceed 100
                if (currentPosition + toAdd > WINNING_POSITION)
                    nextPosition = currentPosition;
                else
                    nextPosition = currentPosition + toAdd;
                //checking if player has moved below position 0
                if (nextPosition < STARTING_POSITION)
                    currentPosition = STARTING_POSITION;
                else
                    currentPosition = nextPosition;
            }
            Console.WriteLine("No. Of Total Die Rolls : " + throws);
            Console.WriteLine("Final Position of Player : " + currentPosition);
        }
    }
}