using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IFather 
    {
        void Loan();
    }

    interface IMother
    {
        void Loan();
    }

    class Child2 : IFather, IMother
    {
        void IFather.Loan() 
        {
            Console.WriteLine("Child2 fathers 20% loan will be clear...");
        }

        void IMother.Loan()
        {
            Console.WriteLine("Child2 Mothers 5 0% loan will be clear...");
        }
    }

    class Child1 : IMother, IFather
    {
        public void Loan()
        {
            Console.WriteLine("Child1 remaining father and mother loan will be cleared...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child1 c1 = new Child1();
            Child2 c2 = new Child2();

            //When ever we have defined interface explicilty we need to create variable to use that interface.

            IFather father = c2 as IFather;
            IMother mother = c2 as IMother;

            father.Loan();
            mother.Loan();

            Console.WriteLine("------------------------------------");

            //Wheneve we use public method  to provide thre implementations for the interface method 
            // then we can directly invoke using  objec tnam e

            c1.Loan();
            Console.ReadLine();
        }
    }
}
