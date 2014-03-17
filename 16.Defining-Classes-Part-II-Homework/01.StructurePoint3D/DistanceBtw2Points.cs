using System;

namespace Point3D
{
    public static class DistanceBtw2Points
    {
        public static double CalculateDistance(Point first ,Point second)
        {
            return Math.Sqrt((second.X-first.X)*(second.X-first.X)+
                             (second.Y-first.Y)*(second.Y-first.Y)+
                             (second.Z-first.Z)*(second.Z-first.Z));
        }
    }
}
