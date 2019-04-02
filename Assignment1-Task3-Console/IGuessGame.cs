using System.Collections.Generic;

namespace Assignment1_Task3_Console
{
    internal interface IGuessGame
    {
        int NumberToGuess { get; set; }
        List<int> Guesses { get; set; }

        bool CheckGuess(int guess);

        string GetGuesses();

    }
}