using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     class ConditionStatements
    {


        // conditional statements
        // if()
        //if and else
        //Nested if and else
        //ladder if and else
        // switch case


        public static void IfNelse() {

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
         int  age = Console.Read();
          

            Console.WriteLine(name + " " + age);




            while (true) { }

            do
            {

            } while (true);

            for (int i = 0; i < age; i++) { }

            int[] a = { 1, 2, 3, 4 };

            foreach (int i in a) { }  

        }


        class B  : ConditionStatements
        { 
        
        
        }

    }
}
