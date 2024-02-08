using System;

public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();

    private Singleton() { }

    public static Singleton Instance
    {
        get { return instance; }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton.Instance.PrintMessage("Hello, Singleton!");

        Singleton anotherInstance = Singleton.Instance;
        anotherInstance.PrintMessage("Trying to create another instance...");

        Console.ReadLine();
    }
}