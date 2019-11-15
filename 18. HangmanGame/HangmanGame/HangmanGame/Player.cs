using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Player
    {
        private String name;
        private int score;

        public Player(String theName)
        {
            name = theName;
        }

        public void setName(String theName)
        {
            name = theName;
        }

        public String getname()
        {
            return name;
        }

        public void setScore(int theScore)
        {
            score = theScore;
        }

        public int getScore()
        {
            return score;
        }
    }
}
