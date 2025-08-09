using System;

namespace InheritanceAndMethodOverriding
{
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance and Method Overriding Demo");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() method on each instance
            Console.WriteLine("Animal says:");
            animal.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Dog says:");
            dog.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Cat says:");
            cat.MakeSound();
            Console.WriteLine();

            // Demonstrate polymorphism
            Console.WriteLine("Polymorphism Demo:");
            Console.WriteLine("==================");
            
            Animal[] animals = { animal, dog, cat };
            
            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write($"Animal {i + 1} says: ");
                animals[i].MakeSound();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
} 