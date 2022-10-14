using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     class Occurance
    {


        public static void Mainyufgfd()
        {
            String s = "hello world"; // h,e,l,o,w,r,,d
            char[] charoFstr = s.ToCharArray();

            HashSet<Char> hs = new HashSet<Char>();
            for (int i = 0; i < s.Length; i++)
            {
                hs.Add(s[i]);
            }

            foreach (char ch in hs)
            {

                int count = 0;
                foreach (char w in charoFstr)
                {
                    if (ch.Equals(w))
                    {
                        count++;

                    }

                }
                Console.WriteLine(ch + " is repeted " + count);
            }
        }
    }
}

