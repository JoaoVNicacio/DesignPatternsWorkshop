interface ITaxHandler {
  setNext(handler: ITaxHandler): ITaxHandler;
  calculateTax(price: number): number;
}

class ICMSHandler implements ITaxHandler {
  private _nextHandler: ITaxHandler | null = null;

  public setNext(handler: ITaxHandler): ITaxHandler {
    this._nextHandler = handler;
    return handler;
  }

  public calculateTax(price: number): number {
    if (this._nextHandler) {
      return price * 0.1 + this._nextHandler.calculateTax(price);
    }
    return price * 0.1;
  }
}

class IPIHandler implements ITaxHandler {
  private nextHandler: ITaxHandler | null = null;

  public setNext(handler: ITaxHandler): ITaxHandler {
    this.nextHandler = handler;
    return handler;
  }

  public calculateTax(price: number): number {
    if (this.nextHandler) {
      return price * 0.05 + this.nextHandler.calculateTax(price);
    }
    return price * 0.05;
  }
}

// Uso do Chain of Responsibility para cálculo de impostos
const icmsHandler = new ICMSHandler();
const issHandler = new IPIHandler();

icmsHandler.setNext(issHandler);

icmsHandler.calculateTax(100);
