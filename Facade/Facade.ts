class Engine {
  public start(): void {
    console.log("Motor ligado");
  }

  public stop(): void {
    console.log("Motor desligado");
  }
}

class Lights {
  public turnOn(): void {
    console.log("Faróis ligados");
  }

  public turnOff(): void {
    console.log("Faróis desligados");
  }
}

class FuelSystem {
  public pumpFuel(): void {
    console.log("Bomba de combustível ligada");
  }

  public stopPumpingFuel(): void {
    console.log("Bomba de combustível desligada");
  }
}

class CarFacade {
  private readonly _engine: Engine;
  private readonly _lights: Lights;
  private readonly _fuelSystem: FuelSystem;

  constructor() {
    this._engine = new Engine();
    this._lights = new Lights();
    this._fuelSystem = new FuelSystem();
  }

  public startCar(): void {
    this._engine.start();
    this._lights.turnOn();
    this._fuelSystem.pumpFuel();
    console.log("Carro pronto para uso");
  }

  public stopCar(): void {
    this._fuelSystem.stopPumpingFuel();
    this._lights.turnOff();
    this._engine.stop();
    console.log("Carro desligado");
  }
}
