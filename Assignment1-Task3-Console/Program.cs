using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Task3_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Scoreboard scoreboard = new Scoreboard();
            string playAgain = "Y";

            do
            {
                if (playAgain.ToUpper() == "Y")
                {
                    Console.WriteLine(Text.Intro);

                    Console.Write(Text.Name);
                    Score score = new Score();
                    score.Name = Console.ReadLine();
                    GuessGameExtended game = new GuessGameExtended();

                    int level = -1;
                    do
                    {
                        Console.WriteLine(Text.Difficulty);
                        string input = Console.ReadLine();
                        bool isNum = int.TryParse(input, out level);

                        if (isNum && level < 4 && level > 0)
                        {
                            game.SetDifficulty(level);
                        }

                    } while (level > 3 || level < 1);

                    Console.WriteLine("\n" + Text.NewGame);

                    do
                    {
                        if (game.Guesses.Count != 0)
                        {
                            Console.WriteLine("Your guesses: " + game.GetGuesses());
                        }

                        string input = Console.ReadLine();
                        bool isNum = int.TryParse(input, out int guess);

                        if (isNum)
                        {
                            string gameResult = game.PlayGame(guess);

                            if (gameResult == Text.Won)
                            {
                                score.SetScore(game.Guesses.Count);
                                scoreboard.Add(score);
                            }

                            Console.WriteLine('\n' + gameResult);
                        }
                        else
                        {
                            Console.WriteLine(Text.Invalid);
                        }

                    } while (game.Guesses.Count < 3 && !game.GameWon);

                    Console.WriteLine("\nScoreboard:");
                    Console.WriteLine(scoreboard.ToString() + '\n');

                    Console.Write(Text.PlayAgain);
                    playAgain = Console.ReadLine();

                }
                else if (playAgain.ToUpper() == "N")
                {
                    Console.WriteLine("Exiting Game. Press any key to close...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(Text.Invalid);
                    playAgain = Console.ReadLine();
                }
            } while (playAgain.ToUpper() != "N");




        }
    }
}
