interface IVehicle {
  drive(): void;
}

class Car implements IVehicle {
  public drive() {
    console.log("Dirigindo um carro");
  }
}

class Bicycle implements IVehicle {
  public drive() {
    console.log("Pedalando uma bicicleta");
  }
}

class VehicleFactory {
  public static createVehicle(type: string): IVehicle {
    switch (type.toLowerCase()) {
      case 'car':
        return new Car();
      case 'bicycle':
        return new Bicycle();
      default:
        throw new Error('Tipo de veículo não suportado');
    }
  }
}
