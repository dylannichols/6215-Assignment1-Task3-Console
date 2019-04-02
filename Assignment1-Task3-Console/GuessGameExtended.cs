using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Task3_Console
{
    class GuessGameExtended : GuessGame, IDifficulty
    {
        public void SetDifficulty(int level)
        {
            Random rand = new Random();
            int upper = -1;
            switch (level)
            {
                case 1:
                    upper = 5;
                    break;
                case 2:
                    upper = 10;
                    break;
                case 3:
                    upper = 20;
                    break;

            }
            NumberToGuess = rand.Next(1, upper);
        }
    }
}
