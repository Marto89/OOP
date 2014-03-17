using System;

namespace _01.Shape
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height) { }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
        public override string ToString()
        {
            return string.Format("Triangle surface is: {0:F2}",this.CalculateSurface());
        }
    }
}
