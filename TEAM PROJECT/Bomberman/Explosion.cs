using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public class Explosion : StaticObject
    {
        private new const char Symbol = '*';
        public Explosion(MatrixCoords topLeft):
            base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }
        public override IEnumerable<GameObject> Update(char[,] matrix)
        {
            return new List<GameObject>();
        }
         
    }
}
