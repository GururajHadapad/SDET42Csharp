using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
   public  class Specifires
    {
        public string Test1() 
        {

            Console.WriteLine("am Test1 public method");
            String  value= Console.ReadLine();
            return value;
        }

        private void Test2()
        {
            Console.WriteLine("am Test2 Private method");
        }

        protected void Test3()
        {
            Console.WriteLine("am Test3 protected method");
        }

        internal void Test4()
        {
            Console.WriteLine("am Test4 internal method");
        }
        protected internal void Test5()
        {
            Console.WriteLine("am Test5 protected internal method");
        }
    }
}
