class Engine
{
  public void Start()
  {
    Console.WriteLine("Motor ligado");
  }

  public void Stop()
  {
    Console.WriteLine("Motor desligado");
  }
}

class Lights
{
  public void TurnOn()
  {
    Console.WriteLine("Faróis ligados");
  }

  public void TurnOff()
  {
    Console.WriteLine("Faróis desligados");
  }
}

class FuelSystem
{
  public void PumpFuel()
  {
    Console.WriteLine("Bomba de combustível ligada");
  }

  public void StopPumpingFuel()
  {
    Console.WriteLine("Bomba de combustível desligada");
  }
}

class CarFacade
{
  private readonly Engine _engine;
  private readonly Lights _lights;
  private readonly FuelSystem _fuelSystem;

  public CarFacade()
  {
    _engine = new Engine();
    _lights = new Lights();
    _fuelSystem = new FuelSystem();
  }

  public void StartCar()
  {
    _engine.Start();
    _lights.TurnOn();
    _fuelSystem.PumpFuel();
    Console.WriteLine("Carro pronto para uso");
  }

  public void StopCar()
  {
    _fuelSystem.StopPumpingFuel();
    _lights.TurnOff();
    _engine.Stop();
    Console.WriteLine("Carro desligado");
  }
}
