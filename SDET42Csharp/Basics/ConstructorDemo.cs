using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
    class ConstructorDemo
    {

        int i;
        public ConstructorDemo(int x)
        {
           this.i= x;
            

        }

        public ConstructorDemo(ConstructorDemo obj) {

           i= obj.i;
        }

        public void Display() {


            Console.WriteLine("am implemented inside construtor :" + i);
        }

       

        
    }
}
