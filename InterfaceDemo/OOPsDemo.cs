using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
    class Institute 
    {
        public virtual void CourseOffered() 
        {
            Console.WriteLine("Course Offered C, C++ , .Net ,JAVA");
        }

        public void Discount() 
        {
            Console.WriteLine("Default discount : Rs 500/-");
        }
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
