using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public class MatrixCoords
    {
        public int Row { get;  set; }
        public int Col { get;  set; }

        public MatrixCoords(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        public static MatrixCoords operator +(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row + b.Row, a.Col + b.Col);
        }
        public static MatrixCoords operator -(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row - b.Row, a.Col - b.Col);
        }
        public override bool Equals(object obj)
        {
            MatrixCoords obj2 = (MatrixCoords)obj;
            return obj2.Row==this.Row && obj2.Col==this.Col;
        }
        public override int GetHashCode()
        {
            return this.Row.GetHashCode()+this.Col.GetHashCode();
        }
    }
}
