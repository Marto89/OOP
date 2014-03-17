using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public class IndestructibleBlock : StaticObject
    {
        public new const string CollisionGroupString = "indestructibleBlock";
        private new const char Symbol = (char)0x2588;
        public IndestructibleBlock(MatrixCoords topLeft)
             :base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override void Update(char [,] matrix)
        {
        }

    }
}
