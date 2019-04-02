using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Task3_Console
{
    class Scoreboard
    {
        public List<Score> Board { get; set; }

        public Scoreboard()
        {
            Board = new List<Score>();
        }

        public void Add(Score score)
        {
            Board.Add(score);
        }

        public override string ToString()
        {
            string output = "";
            Board.Sort();
            Board.Reverse();
            foreach (Score s in Board)
            {
                output += s.ToString() + "\n";
            }
            return output;
        }

    }
}
