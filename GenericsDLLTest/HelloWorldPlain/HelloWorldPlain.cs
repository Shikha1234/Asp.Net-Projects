using System;

public class HelloWorldPlain : IGenericHelloWorld
{
    #region IGenericHelloWorld Members

    public void SayHello(string strText)
    {
        Console.WriteLine("Hello World!");
    }

    #endregion
}