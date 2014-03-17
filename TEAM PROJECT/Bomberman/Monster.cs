using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public class Monster : MovingObject
    {
        public new const string CollisionGroupString = "monster";
        private new const char Symbol = '&';

        public Monster(MatrixCoords topLeft,Direction direction):
            base(topLeft,direction)
        {
            this.body[0,0] =Symbol;
            this.Direction = direction;
        }
        public override void Update(char[,] matrix)
        {
            if(this.Direction==Direction.UpDown)
            {
                if (matrix[this.TopLeft.Row + 1, this.TopLeft.Col] != ' ')
                {
                    this.TopLeft.Row--;
                }
                else if (matrix[this.TopLeft.Row - 1, this.TopLeft.Col] != ' ')
                {
                    this.TopLeft.Row++;
                }
                else
                {
                    Random randomNumber = new Random();
                    switch (randomNumber.Next(1, 3))
                    {
                        case 1:
                            this.TopLeft.Row++;
                            break;
                        case 2:
                            this.TopLeft.Row--;
                            break;
                    }

                }
            }
            else
            {
                if (matrix[this.TopLeft.Row, this.TopLeft.Col+1] != ' ')
                {
                    this.TopLeft.Col--;
                }
                else if (matrix[this.TopLeft.Row , this.TopLeft.Col-1] != ' ')
                {
                    this.TopLeft.Col++;
                }
                else
                {
                    Random randomNumber = new Random();
                    switch (randomNumber.Next(1, 3))
                    {
                        case 1:
                            this.TopLeft.Col++;
                            break;
                        case 2:
                            this.TopLeft.Col--;
                            break;
                    }

                }
            }
            
        }

    }
}
