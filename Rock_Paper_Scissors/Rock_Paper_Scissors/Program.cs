using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer1, inputPlayer2;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer1 = 0;
                int scorePlayer2 = 0;

                while (scorePlayer1 < 1 && scorePlayer2 < 1)
                {
                    Console.Write("Player 1, choose between ROCK, PAPER, and SCISSORS: ");
                    inputPlayer1 = Console.ReadLine();
                    Console.WriteLine("Player 1 Chose " + inputPlayer1);
                    inputPlayer1 = inputPlayer1.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputPlayer2 = "ROCK";
                            Console.WriteLine("Player 2 chose ROCK");
                            if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("Player 1 WINS!!\n\n");
                                scorePlayer1++;
                            }
                            else if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("Player 2 WINS!!\n\n");
                                scorePlayer2++;
                            }
                            break;
                        case 2:
                            inputPlayer2 = "PAPER";
                            Console.WriteLine("Player 2 chose PAPER");
                            if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("Player 2 WINS!!\n\n");
                                scorePlayer2++;
                            }
                            else if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("Player 1 WINS!!\n\n");
                                scorePlayer1++;
                            }
                            break;
                        case 3:
                            inputPlayer2 = "SCISSORS";
                            Console.WriteLine("Player 2 chose SCISSORS");
                            if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("Player 1 WINS!!\n\n");
                                scorePlayer1++;
                            }
                            else if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("Player 2 WINS!!\n\n");
                                scorePlayer2++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                    Console.WriteLine("\n\nSCORES:\tPlayer 1:\t{0}\tPlayer 2:\t{1}", scorePlayer1, scorePlayer2);
                }

                if (scorePlayer1 == 3)
                {
                    Console.WriteLine("Player 1 WON!");
                }
                else if (scorePlayer2 == 3)
                {
                    Console.WriteLine("Player 2 WON!");
                }
                else
                {
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine().ToLower(); ;
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                }
            }
        }
    }
}
