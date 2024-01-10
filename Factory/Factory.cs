namespace Factory;

interface IVehicle
{
  void Drive();
}

class Car : IVehicle
{
  public void Drive() => Console.WriteLine("Dirigindo um carro");
}

class Bicycle : IVehicle
{
  public void Drive() => Console.WriteLine("Pedalando uma bicicleta");
}

class VehicleFactory
{
  public static IVehicle CreateVehicle(string type) =>
    type.ToLower() switch
    {
      "car" => new Car(),
      "bicycle" => new Bicycle(),
      _ => throw new ArgumentException("Tipo de veículo não suportado")
    };
}
