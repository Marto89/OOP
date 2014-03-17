using System;
using System.Linq;

namespace Bomberman
{
    public class Player
    {
        private string name;
        private uint highScores;

        public uint HighScores
        {
            get
            {
                return this.highScores;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("Please, enter a valid player name!");
                }
            }

        }
        public Player()
        {
        }
        public Player(string name)
        {
            this.Name = name;
        }


    }

}
