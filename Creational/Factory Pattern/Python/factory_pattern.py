from abc import ABC, abstractmethod

# Product interface
class Transport(ABC):
    @abstractmethod
    def deliver(self, cargo: str) -> None:
        pass

# Concrete Products
class Truck(Transport):
    def deliver(self, cargo: str) -> None:
        print(f"Delivering {cargo} by land in a truck")

class Ship(Transport):
    def deliver(self, cargo: str) -> None:
        print(f"Delivering {cargo} by sea in a ship")

# Creator - abstract factory class
class LogisticsFactory(ABC):
    # Factory Method
    @abstractmethod
    def create_transport(self) -> Transport:
        pass

    # Business logic that uses the factory method
    def plan_delivery(self, cargo: str) -> None:
        transport = self.create_transport()
        print("Planning delivery...")
        transport.deliver(cargo)

# Concrete Creators
class RoadLogistics(LogisticsFactory):
    def create_transport(self) -> Transport:
        return Truck()

class SeaLogistics(LogisticsFactory):
    def create_transport(self) -> Transport:
        return Ship()

def client_code(logistics: LogisticsFactory, cargo: str) -> None:
    """
    Client code works with creators through their base interface
    """
    logistics.plan_delivery(cargo)

def main():
    print("Factory Method Pattern Demo\n")

    print("Client: Testing Road Logistics")
    client_code(RoadLogistics(), "Electronics")

    print("\nClient: Testing Sea Logistics")
    client_code(SeaLogistics(), "Cars")

if __name__ == "__main__":
    main() 