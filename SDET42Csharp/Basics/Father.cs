using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
    public  interface IFather
    {       
        public void Money();


          void Money(double amount) { 
        
        }
    }

    public interface IMather
    {  
      public void Money();
    }
    class Kids : IFather, IMather
    {
         void IFather.Money()
        {
            Console.WriteLine("am from father");
        }

        void IMather.Money()
        {
            Console.WriteLine("am from mother");
        }

        
       
    }

    class Nephew : Kids, IMather, IFather
    {
        static void Max() {
            Console.BackgroundColor = ConsoleColor.Green;
          

        }
    }

}
