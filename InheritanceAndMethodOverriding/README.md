# Inheritance and Method Overriding Demo

This C# console application demonstrates the concepts of inheritance and method overriding.

## Project Structure

- `Program.cs` - Contains the main program with:
  - `Animal` base class with a virtual `MakeSound()` method
  - `Dog` derived class that overrides `MakeSound()` to print "Bark"
  - `Cat` derived class that overrides `MakeSound()` to print "Meow"
  - `Main` method that creates instances and demonstrates the functionality

## Features

1. **Base Class**: `Animal` with a virtual `MakeSound()` method that prints "Some generic sound"
2. **Derived Classes**: 
   - `Dog` overrides `MakeSound()` to print "Bark"
   - `Cat` overrides `MakeSound()` to print "Meow"
3. **Demonstration**: Shows both direct method calls and polymorphism

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Open a terminal in the project directory
3. Run the following commands:

```bash
# Build the project
dotnet build

# Run the application
dotnet run
```

## Expected Output

```
Inheritance and Method Overriding Demo
=====================================

Animal says:
Some generic sound

Dog says:
Bark

Cat says:
Meow

Polymorphism Demo:
==================
Animal 1 says: Some generic sound
Animal 2 says: Bark
Animal 3 says: Meow

Press any key to exit...
```

## Learning Objectives

This project demonstrates:
- Class inheritance using the `:` syntax
- Method overriding using `virtual` and `override` keywords
- Polymorphism through base class references
- Console application structure in C# 