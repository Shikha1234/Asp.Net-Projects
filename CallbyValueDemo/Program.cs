using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbyValueDemo
{
    class Name
    {
        private string _firstName, _lastName;
        public void SetName(string fname , string lname) 
        {
            this._firstName = fname;
            this._lastName = lname;
        }
        public string GetName() 
        {
            return String.Format("{0} {1}", _firstName, _lastName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();
           
            //Call by value 
            //name.SetName("shikha", "pandey");

            //Named paramter passing
            name.SetName(fname: "Shikha", lname: "Pandey");

            Console.WriteLine("Name :{0}", name.GetName());
            Console.ReadLine();

        }
    }
}
