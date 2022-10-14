using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
    abstract class DemoAbstract
    {


        public  abstract void MeThooood();

        String s ;

       public  DemoAbstract(string s)
        {
            this.s = s;
        }

       

    }

    class ConCreate : DemoAbstract
    {
        public override void MeThooood()
        {
            
        }

       public ConCreate() :base("c Sharp") { 
        
        
        }
    }
}
