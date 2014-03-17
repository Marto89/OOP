using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class Explose : Bomb
    {
        private const char detonationSymbol = '*';
        public Explose(MatrixCoords topLeft) :
            base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }
        public override void Update(char[,] matrix)
        {
        }
    }
}
