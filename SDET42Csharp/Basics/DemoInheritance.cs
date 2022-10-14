using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     class DemoInheritance
    {
       
        public DemoInheritance() 
        {
           
            Console.WriteLine("Am a DemoInheritance constructor 0 param");
                   }

    }

    class DemoInheritanceSub : DemoInheritance
    {
        public DemoInheritanceSub() :base()
        {   

        }

        static void mee() {



            DemoInheritanceSub ds=new DemoInheritanceSub();
        }


    }
}
