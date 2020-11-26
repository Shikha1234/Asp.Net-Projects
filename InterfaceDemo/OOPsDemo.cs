using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{ 
   public class Institute 
    {
        public virtual void CourseOffered() 
        {
            Console.WriteLine("Course Offered C, C++ , .Net ,JAVA");
        }

        public void Discount() 
        {
            Console.WriteLine("Default discount : Rs 500/-");
        }

        public abstract void Address();
    }


    interface IBanners 
    {
        void Location();
    
    }

    interface IAds 
    {
        void PaperDetails();
    }




    class ShikhaTechnos : Institute, IBanners, IAds
    {
        public override void CourseOffered()
        {
            Console.WriteLine("Course Offered Python , Java ,net , Scirpt ");
        }

        public void Location()
        {
            Console.WriteLine("Banners Pune Maharashtra");

        }

        public void PaperDetails()
        {
            Console.WriteLine("Papers Ads @ TOI, Danik Bhaskar");
        }

        //Selaed class can not be inherited futher 

    // Last class in the hierarchy of inheritance i.e. Sealed cant be inherited further.
    //Selaed can inherited from other other objet can also been created 
        public override void Address()
        {


        }
    }

    class Demo 
    {
        static void main(string[] args) 
        {
            ShikhaTechnos sp = new ShikhaTechnos();
            sp.CourseOffered();
            Institute ins = new Institute();
            ins.Discount();
            sp.Discount();
            sp.Location();
            Console.WriteLine("---------------------------------------------");

            

        
        }
    
    }
}
