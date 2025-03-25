using System;

namespace FactoryPattern
{
    // Product interface
    public interface ITransport
    {
        void Deliver(string cargo);
    }

    // Concrete Products
    public class Truck : ITransport
    {
        public void Deliver(string cargo)
        {
            Console.WriteLine($"Delivering {cargo} by land in a truck");
        }
    }

    public class Ship : ITransport
    {
        public void Deliver(string cargo)
        {
            Console.WriteLine($"Delivering {cargo} by sea in a ship");
        }
    }

    // Creator - abstract factory class
    public abstract class LogisticsFactory
    {
        // Factory Method
        public abstract ITransport CreateTransport();

        // Business logic that uses the factory method
        public void PlanDelivery(string cargo)
        {
            var transport = CreateTransport();
            Console.WriteLine("Planning delivery...");
            transport.Deliver(cargo);
        }
    }

    // Concrete Creators
    public class RoadLogistics : LogisticsFactory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }

    public class SeaLogistics : LogisticsFactory
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Pattern Demo\n");

            // Client code
            Console.WriteLine("Client: Testing Road Logistics");
            ClientCode(new RoadLogistics(), "Electronics");

            Console.WriteLine("\nClient: Testing Sea Logistics");
            ClientCode(new SeaLogistics(), "Cars");
        }

        // Client code works with creators through their base interface
        static void ClientCode(LogisticsFactory logistics, string cargo)
        {
            logistics.PlanDelivery(cargo);
        }
    }
} 