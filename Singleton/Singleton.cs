using System;

public sealed class Singleton
{
  private static Singleton _instance = null;
  private static readonly object _padlock = new object();

  private Singleton() { }

  public static Singleton Instance
  {
    get
    {
      lock (_padlock)
      {
        return _instance ??= new Singleton();
      }
    }
  }

  public void ShowMessage()
  {
    Console.WriteLine("Exemplo de Singleton em C#");
  }
}
