using System;


namespace _01.Shape
{
    public class Circle : Shape
    {
        public Circle(double width, double height)
            : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException("Height is not equal to width in circle shape");
            }
        }
        public override double CalculateSurface()
        {
            return 2 * Math.PI * this.Height;
        }
        public override string ToString()
        {
            return string.Format("Circle surface is: {0:F2}", this.CalculateSurface());
        }
    }
}
