using System;
namespace CallByReferenceDemo
{
    class CBRClass 
    { 
        public void Swap(ref int no1 , ref int no2) 
        {
            // When we are calling value by reference if any changes has made in the varible it beenre
            //reflected to called also
            int temp = no1;
            no1 = no2;
            no2 = temp;
        }
     }
    class Program
    {
        static void Main(string[] args)
        {
            int no1, no2;
            Console.WriteLine("Enter two numbers");
            no1 = int.Parse(Console.ReadLine());
            no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swapping values are :{0} {1} ",no1,no2);
            CBRClass cb = new CBRClass();
            cb.Swap(ref no1, ref no2);
            Console.WriteLine("After swap method called {0} {1}",no1,no2);
            Console.ReadLine();
        }
    }
}
 