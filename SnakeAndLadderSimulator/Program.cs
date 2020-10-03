using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int STARTING_POSITION = 0;
        public const int WINNING_POSITION = 100;
        //Returns Output Of Die Roll
        public static int RollTheDie()
        {
            Random random = new Random();
            int numOnDie = random.Next(1, 7);
            return numOnDie;
        }
        static void Main(string[] args)
        {
            int currentPosition = STARTING_POSITION;
            int numOnDie = RollTheDie();
        }
    }
}