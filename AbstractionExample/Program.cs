using System;

namespace AbstractionExample
{
    #region Laptop Example For Abstraction
    //public class Laptop
    //{

    //    private string brand;

    //    private string model;

    //    public string Brand
    //    {
    //        get { return brand; }

    //        set { brand = value; }
    //    }

    //    public string Model
    //    {
    //        get { return model; }

    //        set { model = value; }
    //    }

    //    public void LaptopDetails()
    //    {
    //        Console.WriteLine("Brand: " + Brand);
    //        Console.WriteLine("Model: " + Model);
    //    }

    //    public void LaptopKeyboard()
    //    {
    //        Console.WriteLine("Type using Keyword");
    //    }

    //    private void MotherBoardInfo()
    //    {
    //        Console.WriteLine("MotheBoard Information");
    //    }

    //    private void InternalProcessor()
    //    {
    //        Console.WriteLine("Processor Information");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Laptop l = new Laptop();
    //        l.Brand = "Dell";
    //        l.Model = "Inspiron 14R";
    //        l.LaptopDetails();
    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    #endregion

    // Below is example of abtract classes and method in C#
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
            Console.WriteLine(myPig);
            Console.ReadKey();
        }
    }

}
