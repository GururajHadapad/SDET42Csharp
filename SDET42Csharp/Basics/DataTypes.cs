using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42Csharp.Basics
{
     class DataTypes
    {

        static void segregate()
        {

            String s = "We@3l$co*m4%e";


            String specialChar = "";
            String num = "";
            String alpha = "";
            for (int i = 0; i < s.Length; i++)
            {

                char ch = s[i];
                if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch >= 'z')
                {
                    alpha = ch + alpha;

                }
                else if (ch >= '0' && ch <= '9')
                {
                    num = ch + num;
                }
                else
                {

                    specialChar = ch + specialChar;
                }

            }

            Console.WriteLine(specialChar);





        }


            
    }
}
