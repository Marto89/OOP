using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public class Bomb : StaticObject
    {
        public new const string CollisionGroupString = "bomb";
        private new const char Symbol = '@';
        private const char detonationSymbol = '*';
        private int counter = 0;
        public Bomb(MatrixCoords topLeft) :
            base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override void Update(char[,] matrix)
        {
            counter++;
            //if (counter == 5)
            //{
            //    counter = 0;
            //   // allObjects.Add(bomb);
            //}
            if (counter == 20)
            {
                this.body = new char[,] { { detonationSymbol }, { detonationSymbol }, { detonationSymbol }, { detonationSymbol }, { detonationSymbol } };
                counter = 0;
            }
            //if (counter == 6)
            //{
            //    this.body = new char[,] { { ' ' } };
            //    counter = 0;
            //}
            //if (counter == 10)
            //{
            //    this.body = new char[,] { { ' ' } };
            //    counter = 0;
            //}
        }
    }
}
