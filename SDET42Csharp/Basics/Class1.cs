using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     struct Demo
    {
        int a=11;
        static int b;
        const int c=11;
        readonly int d=0;
        private int e=10;
       public  Demo() { 
        
        
        
        }

        public void m1() { 
        }
        public static void M2() { 
        
        }
        private static void M2(int i)
        {

        }
        static void Main() {

            // Struct can created object or no need of creating object by using new but if u want use field
            // without create obj then u hv to initialize even if its initialized globally

            // if u declare variable inside struct it should not be initialized
            // if u want to initilize then declare explicit constructor


            // here if u declare method Static then u should call them by creating object(vice/versa of class)
            // if u declare Non static method u hv to call them with struct name dot method


            //A C# struct can declare constrcutor, but they must take parameters.
            //A default constructor (constructor without any parameters) are always provided to initialize the struct fields to
            //their default values. The parameterized constructors inside a struct can also be overloaded.             

        }

    }

    
}
