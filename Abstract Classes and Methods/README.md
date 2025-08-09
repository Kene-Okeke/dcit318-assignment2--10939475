# Abstract Classes and Methods Demo

This C# console application demonstrates the use of abstract classes and methods.

## Project Structure

- `Program.cs` - Contains the main program with:
  - `Shape` - Abstract base class with abstract method `GetArea()`
  - `Circle` - Derived class that implements `GetArea()` for circles
  - `Rectangle` - Derived class that implements `GetArea()` for rectangles
  - `Program` - Main class with the entry point

## Features

- Abstract class `Shape` with abstract method `GetArea()`
- Concrete implementation in `Circle` class (area = π × r²)
- Concrete implementation in `Rectangle` class (area = length × width)
- Console output showing calculated areas

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
Abstract Classes and Methods Demo
================================
Circle with radius 5.0: Area = 78.54
Rectangle with length 4.0 and width 6.0: Area = 24.00

Press any key to exit...
```
