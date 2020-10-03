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
            int currentPosition = STARTING_POSITION;
            //Rolling Die
            int numOnDie = RollTheDie();
            //Opting for an option out of three
            int toAdd = NewPosition(numOnDie);
        }
    }
}