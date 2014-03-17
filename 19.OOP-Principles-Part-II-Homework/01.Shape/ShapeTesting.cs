/*
 * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
 */

using System;

namespace _01.Shape
{
    public class ShapeTesting
    {
        static void Main()
        {
            Shape[] shape =
            {
                new Circle(10,10),
                new Triangle(10,10),
                new Rectangle(10,10)
            };
            foreach (var n in shape)
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}
