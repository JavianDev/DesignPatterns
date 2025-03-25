from abc import ABC, abstractmethod

# Abstract Products
class Chair(ABC):
    @abstractmethod
    def sit_on(self):
        pass

class Sofa(ABC):
    @abstractmethod
    def lie_on(self):
        pass

class CoffeeTable(ABC):
    @abstractmethod
    def put_coffee(self):
        pass

# Concrete Products - Modern
class ModernChair(Chair):
    def sit_on(self):
        print("Modern Chair has been created")

class ModernSofa(Sofa):
    def lie_on(self):
        print("Modern Sofa has been created")

class ModernCoffeeTable(CoffeeTable):
    def put_coffee(self):
        print("Modern Coffee Table has been created")

# Concrete Products - Victorian
class VictorianChair(Chair):
    def sit_on(self):
        print("Victorian Chair has been created")

class VictorianSofa(Sofa):
    def lie_on(self):
        print("Victorian Sofa has been created")

class VictorianCoffeeTable(CoffeeTable):
    def put_coffee(self):
        print("Victorian Coffee Table has been created")

# Concrete Products - ArtDeco
class ArtDecoChair(Chair):
    def sit_on(self):
        print("ArtDeco Chair has been created")

class ArtDecoSofa(Sofa):
    def lie_on(self):
        print("ArtDeco Sofa has been created")

class ArtDecoCoffeeTable(CoffeeTable):
    def put_coffee(self):
        print("ArtDeco Coffee Table has been created")

# Abstract Factory
class FurnitureFactory(ABC):
    @abstractmethod
    def create_chair(self) -> Chair:
        pass

    @abstractmethod
    def create_sofa(self) -> Sofa:
        pass

    @abstractmethod
    def create_coffee_table(self) -> CoffeeTable:
        pass

# Concrete Factories
class ModernFurnitureFactory(FurnitureFactory):
    def create_chair(self) -> Chair:
        return ModernChair()

    def create_sofa(self) -> Sofa:
        return ModernSofa()

    def create_coffee_table(self) -> CoffeeTable:
        return ModernCoffeeTable()

class VictorianFurnitureFactory(FurnitureFactory):
    def create_chair(self) -> Chair:
        return VictorianChair()

    def create_sofa(self) -> Sofa:
        return VictorianSofa()

    def create_coffee_table(self) -> CoffeeTable:
        return VictorianCoffeeTable()

class ArtDecoFurnitureFactory(FurnitureFactory):
    def create_chair(self) -> Chair:
        return ArtDecoChair()

    def create_sofa(self) -> Sofa:
        return ArtDecoSofa()

    def create_coffee_table(self) -> CoffeeTable:
        return ArtDecoCoffeeTable()

# Client code
def client_code(factory: FurnitureFactory) -> None:
    chair = factory.create_chair()
    sofa = factory.create_sofa()
    coffee_table = factory.create_coffee_table()

    chair.sit_on()
    sofa.lie_on()
    coffee_table.put_coffee()

def main():
    print("Client: Testing Modern furniture")
    client_code(ModernFurnitureFactory())

    print("\nClient: Testing Victorian furniture")
    client_code(VictorianFurnitureFactory())

    print("\nClient: Testing ArtDeco furniture")
    client_code(ArtDecoFurnitureFactory())

if __name__ == "__main__":
    main() 