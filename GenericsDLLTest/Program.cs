using System;
using GenericHelloWorld;

class Program
{
    static void Main(string[] args)
    {
        foreach (IGenericHelloWorld aHelloWorldImpl in GenericHelloWorld.GenericHelloWorldLoader.GetHelloWorldImplementations())
        {
            aHelloWorldImpl.SayHello("Mr. Smith");
        }

        Console.ReadKey();
    }
}