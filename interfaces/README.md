# C# Interfaces Console Application

This is a simple C# console application that demonstrates the use of interfaces.

## Features

- `IMovable` interface with a `Move()` method
- `Car` class implementing `IMovable`
- `Bicycle` class implementing `IMovable`
- Main program that creates instances and calls the `Move()` method

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Open a terminal in the project directory
3. Run the following commands:

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

## Expected Output

When you run the application, you should see:

```
Car is moving
Bicycle is moving

Press any key to exit...
```

## Project Structure

- `Program.cs` - Contains the interface, classes, and main program
- `Interfaces.csproj` - Project file for the C# console application
- `README.md` - This file 