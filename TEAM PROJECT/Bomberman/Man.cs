using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomberman
{
    public class Man : GameObject
    {
        public new const string CollisionGroupString = "man";
        private int counter = 0;
        public const char Symbol = (char)0x263A;
        public Man(MatrixCoords topLeft) :
            base(topLeft,new char[,]{{Symbol}})
        {
        }
        public void MoveLeft()
        {
            this.TopLeft.Col--;
        }
        public void MoveRight()
        {
            this.TopLeft.Col++;
        }
        public void MoveUp()
        {
            this.TopLeft.Row--;
        }
        public void MoveDown()
        {
            this.TopLeft.Row++;
        }
        public override void Update(char[,] matrix)
        {
        }
          
        public void SetBomb()
        {
            counter = 1;
        }
    }
}
