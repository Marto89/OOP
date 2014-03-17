using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public abstract class GameObject : IRenderable
    {
        public const string ObjectName = "Default name";
        public const string CollisionGroupString = "object";
        private MatrixCoords topLeft;
        protected char[,] body;
        //public readonly int ObjectsSize=4;
        public bool IsDestroyed { get; protected set; }

        public GameObject(MatrixCoords topLeft,char[,] body)
        {
            this.TopLeft = topLeft;
            this.body = body;
            IsDestroyed = false;
        }


        public MatrixCoords TopLeft
        {
            get
            {
                return this.topLeft;
            }
            protected set
            {
                this.topLeft = value;
            }
        }
        //public char[,] Body
        //{
        //    get
        //    {
        //        return CopyBody(this.body);
        //    }
        //    set
        //    {
        //        this.body = CopyBody(value);
        //    }
        //}
        public abstract void Update(char [,] matrix);
        public virtual char[,] GetImage()
        {
            return this.body;
        }  
      
        public MatrixCoords GetTopLeft()
        {
            return this.TopLeft;
        }

        //private char[,] CopyBody(char[,] arrayToCopy)
        //{
        //    char[,] result = new char[ObjectsSize, ObjectsSize];
        //    for (int row = 0; row < ObjectsSize; row++)
        //    {
        //        for (int col   = 0; col < ObjectsSize; col++)
        //        {
        //            result[row, col] = arrayToCopy[row, col];
        //        }
                
        //    }
        //    return result;
        //}
    }
}
