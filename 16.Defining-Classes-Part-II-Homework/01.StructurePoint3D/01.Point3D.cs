using System;

namespace Point3D
{
    public struct Point
    {
        private static readonly Point standartPoint = new Point(0, 0, 0);
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x, int y, int z)
            : this()
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }
        public static Point StandartPoint
        {
            get { return standartPoint;}
        }
    }
}
