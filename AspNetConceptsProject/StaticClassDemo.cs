using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetConceptsProject
{
    public class StopWatch
    {
        // static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }

        public static void Main(string[] args)
        {
            StopWatch.DisplayInfo();
            StopWatch.DisplayInfo();
            Console.ReadLine();
        }
    }

    
}
