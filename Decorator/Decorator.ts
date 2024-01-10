interface ICoffee {
  getDescription(): string;
  getCost(): number;
}

// Implementação concreta do café simples
class SimpleCoffee implements ICoffee {
  public getDescription(): string {
    return "Café simples";
  }

  public getCost(): number {
    return 1.0; // Preço do café simples
  }
}

// Decorator base
abstract class CoffeeDecorator implements ICoffee {
  protected coffee: ICoffee;

  constructor(coffee: ICoffee) {
    this.coffee = coffee;
  }

  public getDescription(): string {
    return this.coffee.getDescription();
  }

  public getCost(): number {
    return this.coffee.getCost();
  }
}

// Decorator para adicionar leite ao café
class MilkDecorator extends CoffeeDecorator {
  constructor(coffee: ICoffee) {
    super(coffee);
  }

  public getDescription(): string {
    return `${this.coffee.getDescription()}, com leite`;
  }

  public getCost(): number {
    return this.coffee.getCost() + 0.5; // Adiciona o custo do leite
  }
}

// Decorator para adicionar caramelo ao café
class CaramelDecorator extends CoffeeDecorator {
  constructor(coffee: ICoffee) {
    super(coffee);
  }

  public getDescription(): string {
    return `${this.coffee.getDescription()}, com caramelo`;
  }

  public getCost(): number {
    return this.coffee.getCost() + 0.75; // Adiciona o custo do caramelo
  }
}

// Uso do padrão Decorator para criar e manipular cafés decorados
let coffee: ICoffee = new SimpleCoffee();
console.log(coffee.getDescription()); // Saída: Café simples
console.log(`Custo: $${coffee.getCost()}`); // Saída: Custo: $1.0

coffee = new MilkDecorator(coffee);
console.log(coffee.getDescription()); // Saída: Café simples, com leite
console.log(`Custo: $${coffee.getCost()}`); // Saída: Custo: $1.5

coffee = new CaramelDecorator(coffee);
console.log(coffee.getDescription()); // Saída: Café simples, com leite, com caramelo
console.log(`Custo: $${coffee.getCost()}`); // Saída: Custo: $2.25
