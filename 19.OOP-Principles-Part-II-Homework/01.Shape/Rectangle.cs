﻿using System;


namespace _01.Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height) { }
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
        public override string ToString()
        {
            return string.Format("Rectangle surface is: {0:F2}",this.CalculateSurface());
        }
    }
}
