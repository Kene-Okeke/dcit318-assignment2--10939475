using System;

namespace Interfaces
{
    // Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call the Move() method on each instance
            car.Move();
            bicycle.Move();

            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 