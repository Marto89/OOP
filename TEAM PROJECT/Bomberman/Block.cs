using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomberman
{
    public class Block : StaticObject
    {
        public new const string CollisionGroupString = "block";
        private new  const char Symbol = (char)0x2588;
        public Block(MatrixCoords topLeft) :
            base(topLeft)
        {
            this.body[0, 0] =Symbol;
        }
        public override void Update(char[,]matrix)
        {
        }

    }
}
