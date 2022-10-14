using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     class HelloworldWithWrite
    {

        static void Reading()
        {
            Console.Write("Write a Name");
            string Name = Console.ReadLine();
            Console.WriteLine(Name);
        }

    }

    class HelloworldWithRead
    {

        static void ExtraMain()
        {
            Console.WriteLine("Write a Name completely");
            string Name = Console.ReadLine();
            Console.WriteLine(Name);
        }

    }
}
