using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int WINNING_POSITION = 100;
        static void Main(string[] args)
        {
            SL player1 = new SL();
            SL player2 = new SL();
            while (player1.currentPosition < WINNING_POSITION && player2.currentPosition < WINNING_POSITION)
            {
                player1.PlayATurn();
                player2.PlayATurn();
            }
            if (player1.currentPosition == WINNING_POSITION)
            {
                Console.WriteLine("Player 1 Won");
            }
            else
            {
                Console.WriteLine("Player 2 Won");
            }
            Console.WriteLine("Final Position of Player 1 :" + player1.currentPosition);
            Console.WriteLine("Final Position of Player 2 :" + player2.currentPosition);
        }
    }
}