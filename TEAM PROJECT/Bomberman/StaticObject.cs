using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public abstract class StaticObject : GameObject
    {
        public const char Symbol='.';
        public StaticObject(MatrixCoords topLeft):
            base(topLeft,new char[,]{{Symbol}})
        {
        }
        public override void Update(char[,]matrix)
        {
        }

        
    }
}
