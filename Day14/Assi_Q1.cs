// Define an abstract class called Shape with an abstract method Area(). 
//Create two derived classes Circle and Rectangle that implement the Area() method for calculating the area of the respective shapes.


using System;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return  3.14 * Radius * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c= new Circle(5);
            var r = new Rectangle(4, 6);
            Console.WriteLine($"Area of Circle: {c.Area()}");
            Console.WriteLine($"Area of Rectangle: {r.Area()}");
        }
    }
}
