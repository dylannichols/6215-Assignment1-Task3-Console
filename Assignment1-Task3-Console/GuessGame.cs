using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Task3_Console
{
    class GuessGame : IGame, IGuessGame
    {
        public int NumberToGuess { get; set; }
        public List<int> Guesses { get; set; }
        public bool GameWon { get; set; }

        public GuessGame()
        {
            Random rand = new Random();
            NumberToGuess = rand.Next(1, 5);
            Guesses = new List<int>();
            GameWon = false;
        }

        public bool CheckGuess(int guess)
        {
            Guesses.Add(guess);
            if (guess == NumberToGuess)
            {
                GameWon = true;
                return true;
            }
            else
                return false;
            
        }

        public string GetGuesses()
        {
            return String.Join("  ", Guesses);
        }

        public string PlayGame(int input)
        {
            if (CheckGuess(input))
                return Text.Won;
            else if (Guesses.Count < 3)
                return Text.Wrong;
            else
                return Text.Loss;
        }
    }
}
