using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     class PropDemo
    {
        

        static void Main122()
        {

            String s1 = "java program";
            char[] vh = s1.ToCharArray();

            foreach (Char c in vh)
            {
                Console.WriteLine(c);

            }
            
            for (int i = 0; i < vh.Length; i++) {

                Console.WriteLine(s1[i]);
            }

            string[] str = s1.Split(' ');
            foreach (String c in str) {
                Console.WriteLine(c);
            
            }
            for (int i = 0; i < vh.Length; i++)
            {

                Console.WriteLine(str[i]);
            }

        }

    }
}
