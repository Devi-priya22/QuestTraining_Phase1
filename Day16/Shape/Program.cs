using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shape
{
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public double GetPerimeter() => 2 * Math.PI * Radius;
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea() => Length * Width;

        public double GetPerimeter() => 2 * (Length + Width);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // List of IShape to store different types of shapes
            var shapes = new List<IShape>
            {
                new Circle(5),         
                new Rectangle(4, 6)    
            };

            // Iterate through each shape and display area and perimeter
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.GetArea()}");
                Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
                Console.WriteLine();
            }
        }
    }


}