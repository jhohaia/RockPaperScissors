using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] RockPaperScissors = { "Rock", "Paper", "Scissors" };

            bool win = false;

            do
            {
                Random r = new Random();

                int Selection = r.Next(RockPaperScissors.Length);
                Console.Write("Type Rock, Paper, or Scissors: ");
                string s = Console.ReadLine();

                if (s == RockPaperScissors[Selection])
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("We'll get em' next time!");
                    Console.WriteLine();
                    win = false;
                }
                else if (s == "Rock" || s == "rock" && RockPaperScissors[Selection] == "Scissors")
                {
                    Console.WriteLine("Winner! You Rock!");
                    win = true;
                }
                else if (s == "Paper" || s == "paper" && RockPaperScissors[Selection] == "Rock")
                {
                    Console.WriteLine("Winner! Enemy Folded!");
                    win = true;
                }
                else if (s == "Scissors" || s == "scissors" && RockPaperScissors[Selection] == "Paper")
                {
                    Console.WriteLine("Winner! You're a cut above the rest!");
                    win = true;
                }
                else
                {
                    Console.WriteLine("You Lose! Try Again");
                    Console.WriteLine();
                    win = false;
                }
                if (win == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to finish, or R to restart the program...");
                    string restar = Console.ReadLine();
                    if (restar.ToUpper() == "R")
                    {
                        win = false;
                    }

                }

            } while (win == false);

        }
    }
}
