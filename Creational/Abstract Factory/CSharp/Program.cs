using System;

namespace AbstractFactory
{
    // Abstract Products
    public interface IChair
    {
        void SitOn();
    }

    public interface ISofa
    {
        void LieOn();
    }

    public interface ICoffeeTable
    {
        void PutCoffee();
    }

    // Concrete Products - Modern
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Modern Chair has been created");
        }
    }

    public class ModernSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Modern Sofa has been created");
        }
    }

    public class ModernCoffeeTable : ICoffeeTable
    {
        public void PutCoffee()
        {
            Console.WriteLine("Modern Coffee Table has been created");
        }
    }

    // Concrete Products - Victorian
    public class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Victorian Chair has been created");
        }
    }

    public class VictorianSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Victorian Sofa has been created");
        }
    }

    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void PutCoffee()
        {
            Console.WriteLine("Victorian Coffee Table has been created");
        }
    }

    // Concrete Products - ArtDeco
    public class ArtDecoChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("ArtDeco Chair has been created");
        }
    }

    public class ArtDecoSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("ArtDeco Sofa has been created");
        }
    }

    public class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void PutCoffee()
        {
            Console.WriteLine("ArtDeco Coffee Table has been created");
        }
    }

    // Abstract Factory
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }

    // Concrete Factories
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }

    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }

    // Client code
    public class Client
    {
        public void ClientCode(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();
            var coffeeTable = factory.CreateCoffeeTable();

            chair.SitOn();
            sofa.LieOn();
            coffeeTable.PutCoffee();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Console.WriteLine("Client: Testing Modern furniture");
            client.ClientCode(new ModernFurnitureFactory());

            Console.WriteLine("\nClient: Testing Victorian furniture");
            client.ClientCode(new VictorianFurnitureFactory());

            Console.WriteLine("\nClient: Testing ArtDeco furniture");
            client.ClientCode(new ArtDecoFurnitureFactory());
        }
    }
} 