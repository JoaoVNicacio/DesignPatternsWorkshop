// Café simples
ICoffee coffee = new SimpleCoffee();
Console.WriteLine(coffee.GetDescription()); // Saída: Café simples
Console.WriteLine($"Custo: ${coffee.GetCost()}"); // Saída: Custo: $1.0

// Café com leite
coffee = new MilkDecorator(coffee);
Console.WriteLine(coffee.GetDescription()); // Saída: Café simples, com leite
Console.WriteLine($"Custo: ${coffee.GetCost()}"); // Saída: Custo: $1.5

// Café com leite e caramelo
coffee = new CaramelDecorator(coffee);
Console.WriteLine(coffee.GetDescription()); // Saída: Café simples, com leite, com caramelo
Console.WriteLine($"Custo: ${coffee.GetCost()}"); // Saída: Custo: $2.25

interface ICoffee
{
  string GetDescription();
  decimal GetCost();
}

// Implementação concreta do café simples
class SimpleCoffee : ICoffee
{
  public string GetDescription()
  {
    return "Café simples";
  }

  public decimal GetCost()
  {
    return 1.0m; // Preço do café simples
  }
}

// Decorator base
abstract class CoffeeDecorator : ICoffee
{
  protected ICoffee _coffee;

  public CoffeeDecorator(ICoffee coffee)
  {
    _coffee = coffee;
  }

  public virtual string GetDescription()
  {
    return _coffee.GetDescription();
  }

  public virtual decimal GetCost()
  {
    return _coffee.GetCost();
  }
}

// Decorator para adicionar leite ao café
class MilkDecorator : CoffeeDecorator
{
  public MilkDecorator(ICoffee coffee) : base(coffee) { }

  public override string GetDescription()
  {
    return $"{_coffee.GetDescription()}, com leite";
  }

  public override decimal GetCost()
  {
    return _coffee.GetCost() + 0.5m; // Adiciona o custo do leite
  }
}

// Decorator para adicionar caramelo ao café
class CaramelDecorator : CoffeeDecorator
{
  public CaramelDecorator(ICoffee coffee) : base(coffee) { }

  public override string GetDescription()
  {
    return $"{_coffee.GetDescription()}, com caramelo";
  }

  public override decimal GetCost()
  {
    return _coffee.GetCost() + 0.75m; // Adiciona o custo do caramelo
  }
}
