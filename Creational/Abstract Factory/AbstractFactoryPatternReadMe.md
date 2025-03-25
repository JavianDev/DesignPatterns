# Abstract Factory Pattern

## Intent
Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

## Problem
Imagine that you're creating a furniture shop simulator. Your code consists of classes that represent:

A family of related products, say: Chair + Sofa + CoffeeTable.

Several variants of this family. For example, products Chair + Sofa + CoffeeTable are available in these variants: Modern, Victorian, ArtDeco.

### Issues:
1. Customers get quite mad when they receive non-matching furniture
2. A Modern-style sofa doesn't match Victorian-style chairs
3. You don't want to change existing code when adding new products or families of products

## Solution
The Abstract Factory pattern suggests:
1. Explicitly declare interfaces for each distinct product of the product family
2. Make all variants of products follow those interfaces
3. Declare the Abstract Factory—an interface with a list of creation methods for all products
4. Create separate factory classes for each variant of a product family

### Benefits:
1. Products from the same factory are compatible
2. Avoid tight coupling between concrete products and client code
3. Single Responsibility Principle - product creation code is isolated
4. Open/Closed Principle - new product variants can be introduced without breaking existing code

## Structure
- `IChair`, `ISofa`, `ICoffeeTable` (Abstract Products)
  - Declare interfaces for a set of distinct but related products

- `ModernChair`, `VictorianChair`, `ArtDecoChair` (Concrete Products)
  - Various implementations of abstract products

- `IFurnitureFactory` (Abstract Factory)
  - Declares a set of methods for creating each of the abstract products

- `ModernFurnitureFactory`, `VictorianFurnitureFactory`, `ArtDecoFurnitureFactory` (Concrete Factories)
  - Implement the creation methods of the abstract factory

## Example Implementation
The example demonstrates a furniture shop system that can create different styles of furniture (Modern, Victorian, ArtDeco) ensuring that all pieces match within each style.

### Running the Code

#### C#
1. Navigate to the C# project directory:
   ```powershell
   cd DesignPatterns/Creational/Abstract\ Factory/CSharp/AbstractFactory
   ```
2. Run the project using .NET CLI:
   ```powershell
   dotnet run
   ```

#### Python
1. Navigate to the Python script directory:
   ```powershell
   cd DesignPatterns/Creational/Abstract\ Factory/Python
   ```
2. Run the script using Python:
   ```powershell
   python abstract_factory.py
   ```

### Expected Output
When you run either the C# or Python code, you should see output similar to this:

```
Client: Testing Modern furniture
Modern Chair has been created
Modern Sofa has been created
Modern Coffee Table has been created

Client: Testing Victorian furniture
Victorian Chair has been created
Victorian Sofa has been created
Victorian Coffee Table has been created

Client: Testing ArtDeco furniture
ArtDeco Chair has been created
ArtDeco Sofa has been created
ArtDeco Coffee Table has been created
```

This output demonstrates how the Abstract Factory pattern ensures that all furniture pieces created by a specific factory match in style. 