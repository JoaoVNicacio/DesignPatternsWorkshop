// Uso do Chain of Responsibility para cálculo de impostos
var icmsHandler = new ICMSHandler();
var ipiHandler = new IPIHandler();

icmsHandler.SetNext(ipiHandler);

Console.WriteLine(icmsHandler.CalculateTax(100));

interface ITaxHandler
{
  ITaxHandler SetNext(ITaxHandler handler);
  decimal CalculateTax(decimal price);
}

class ICMSHandler : ITaxHandler
{
  private ITaxHandler _nextHandler = null;

  public ITaxHandler SetNext(ITaxHandler handler)
  {
    _nextHandler = handler;
    return handler;
  }

  public decimal CalculateTax(decimal price)
  {
    return _nextHandler is not null ? price * 0.1m + _nextHandler.CalculateTax(price)
                                    : price * 0.1m;
  }
}

class IPIHandler : ITaxHandler
{
  private ITaxHandler _nextHandler = null;

  public ITaxHandler SetNext(ITaxHandler handler)
  {
    _nextHandler = handler;
    return handler;
  }

  public decimal CalculateTax(decimal price)
  {
    return _nextHandler is not null ? price * 0.05m + _nextHandler.CalculateTax(price)
                                    : price * 0.05m;
  }
}
