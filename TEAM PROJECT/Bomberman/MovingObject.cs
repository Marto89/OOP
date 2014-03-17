using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomberman
{

    public abstract class MovingObject : GameObject
    {
        public MatrixCoords Speed { get; protected set; }
        public const char Symbol = 'm';
        public Direction Direction { get; protected set; }
        public MovingObject(MatrixCoords topLeft,Direction direction)
            :base(topLeft,new char[,]{{Symbol}})
        {
            this.Direction = direction;
        }
        public abstract override void Update(char [,]matrix);
    }
}
