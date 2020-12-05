using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetConceptsProject
{
    class ExceptionHandling
    {

        // Main --> arthimatic --> Divide  (Exception in C# are propogated to caller ) Exception Propagates
        //Exception will same but propagation will change.

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Arthimatic(1,0));
            }
            catch (NumDenoEqualException ex) 
            {
                Console.WriteLine(1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by Zero not possible. Correcting it to One");
                Console.WriteLine(Arthimatic(10, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thnak you we are at finally !!");  // If exception occurs than it will called irrespective if you have a error or no error.
            }

            Console.ReadLine();
        }

        // Arthimatic is wrapper on the divide function 

        private static int Arthimatic(int num1, int num2)
        {
            int value = Divide(num1, num2);
            return value;
        }

        private static int Divide(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                throw new Exception("Negative numbers not allowed");  // Negative Numbers 
            }
            if (num1 == num2)
            {
                throw new NumDenoEqualException("Numerator and Denomator are same");
            }
            int num3 = (num1 / num2);  //Divide by zero Thrown 
            return num3;
        }


        public class NumDenoEqualException : Exception
        {
            public NumDenoEqualException(string message ): base(message)
            {

            }


        }
    }
}