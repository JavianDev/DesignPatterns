# Factory Method Pattern

## Intent
Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

## Problem
Imagine you're creating a logistics management application. The first version of your app can only handle transportation by trucks, so the bulk of your code lives inside the `Truck` class.

After a while, your app becomes popular and you receive requests to incorporate sea logistics into the app. Adding a new transportation class isn't simple if the rest of the code is already coupled to the existing `Truck` class.

### Issues:
1. Code is tightly coupled to concrete classes
2. Adding new types requires changing existing code
3. Conditional logic scattered throughout the codebase

## Solution
The Factory Method pattern suggests replacing direct object construction calls with calls to a special factory method. Objects are still created using the `new` operator, but it's called from within the factory method.

### Benefits:
1. Loose coupling between creator and concrete products
2. Single Responsibility Principle - object creation code moved to one place
3. Open/Closed Principle - new types can be introduced without breaking existing code

## Structure
- `ITransport` (Interface)
  - Declares the interface common to all objects that can be produced
  - Example: `deliver()` method

- `Truck`, `Ship` (Concrete Products)
  - Implement the `ITransport` interface
  - Specific implementations for different transport types

- `LogisticsFactory` (Creator)
  - Declares the factory method that returns objects of type `ITransport`
  - May include some core business logic that relies on `ITransport` objects

- `RoadLogistics`, `SeaLogistics` (Concrete Creators)
  - Override the factory method to return specific types of transport

## Example Implementation
The example demonstrates a logistics management system that can handle different types of transportation (road and sea). Each transport type has its own way of delivering cargo.

### Usage
Check the C# and Python implementations in their respective folders for detailed examples.

## Running the Code

### C#
1. Navigate to the C# project directory:
   ```bash
   cd C:\Projects\DesignPatterns\DesignPatterns\Creational\Factory\ Pattern\CSharp\FactoryPattern
   ```
2. Run the project using .NET CLI:
   ```bash
   dotnet run
   ```

### Python
1. Navigate to the Python script directory:
   ```bash
   cd C:\Projects\DesignPatterns\DesignPatterns\Creational\Factory\ Pattern\Python
   ```
2. Run the script using Python:
   ```bash
   python factory_pattern.py
   ``` 