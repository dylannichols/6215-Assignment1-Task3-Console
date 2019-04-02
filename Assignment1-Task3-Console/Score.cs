using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Task3_Console
{
    class Score : IComparable
    {
        public string Name { get; set; }
        public int Count { get; set; }   
        
        public Score () { }

        public Score (string name, int score)
        {
            Name = name;
            SetScore(score);
        }

        public void SetScore(int score)
        {
            switch (score)
            {
                case 1:
                    Count = 10;
                    break;
                case 2:
                    Count = 6;
                    break;
                case 3:
                    Count = 2;
                    break;
            }
        }

        public override string ToString()
        {
            return Name + "\t" + Count;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Score otherScore = obj as Score;

            if (otherScore != null)
                return this.Count.CompareTo(otherScore.Count);
            else
                throw new ArgumentException("Object is not a Score");
        }
    }
}
