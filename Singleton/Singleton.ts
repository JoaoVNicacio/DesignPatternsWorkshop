class Singleton {
  private static _instance: Singleton | null = null;

  private constructor() { }

  public static getInstance(): Singleton {
    if (!Singleton._instance) {
      Singleton._instance = new Singleton();
    }
    return Singleton._instance;
  }

  public showMessage(): void {
    console.log("Exemplo de Singleton em TypeScript");
  }
}
