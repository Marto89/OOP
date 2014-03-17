using System;
using System.Collections.Generic;
using System.Text;


namespace Point3D
{
    public class Path
    {
        private List<Point> list;

        public Path()
        {
            this.list=new List<Point>();
        }
        public void AddPoint()
        {
            this.list.Add(Point.StandartPoint);
            this.list.TrimExcess();
        }
        public void AddPoint(Point point)
        {
            this.list.Add(point);
            this.list.TrimExcess();
        }
        public void AddPoint(int x, int y, int z)
        {
            this.list.Add(new Point(x, y, z));
            this.list.TrimExcess();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int indexer = 1;
            foreach (Point point in this.list)
            {
                sb.AppendFormat("Point {0}--->", indexer);
                sb.AppendFormat("{0} : {1} : {2} ", point.X, point.Y, point.Z);
                sb.AppendLine();
                indexer++;
            }
            return sb.ToString();
        }
    }
}
