using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReferenceDemo
{
    class Institute 
    {
        private string _CourseName;
        private decimal _Fees;

        public void SetCourse(string cname , decimal fees) 
        {
            this._CourseName = cname;
            this._Fees = fees;
        }

        public string GetCourseName() 
        {
            return this._CourseName;
        }
        public decimal GetFees()
        {
            return this._Fees;
        }

        //Here we are returning discount argment hende it has bee assigned as our argument
        // Difference between out and return 
        //Return only returns a single value 
        //but out can return multiple values by just defining multiple argument in the method 
        //with "out"keyword

        public void SetDiscount(decimal percentage, out decimal discount ) 
        {
            discount = percentage * 10;
        }

        // Here we are passing fees as call by reference so once this fees variable updated it will update the caller vale
        //Fees = Call by Reference Argument


        public void UpdateCourseFess(ref decimal fees , decimal discount) 
        {
            fees -= discount;
        }
    }

    class MethodsDemo
    {
        static void Main(string[] args) 
        {
            Institute ins = new Institute();
            ins.SetCourse(".Net", 200000);
            string cname = ins.GetCourseName();
            decimal fees = ins.GetFees();
            Console.WriteLine("Course name : {0} \n Fees: Rs.{1}", cname, fees);
            decimal percentage;
            Console.WriteLine("ENter your Percentage : ");
            percentage = decimal.Parse(Console.ReadLine());
            decimal discount;
            ins.SetDiscount(percentage, out discount);
            Console.WriteLine("Congrats !! you have receive {0} rupees of discount", discount);
            ins.UpdateCourseFess(ref fees, discount);
            Console.WriteLine("Final course Fees is : {0} ", fees);
            Console.ReadLine();
        }
    }
}
