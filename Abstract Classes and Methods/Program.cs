using System;

namespace AbstractClassesAndMethods
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes and Methods Demo");
            Console.WriteLine("================================");

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display the areas
            Console.WriteLine($"Circle with radius 5.0: Area = {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle with length 4.0 and width 6.0: Area = {rectangle.GetArea():F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 