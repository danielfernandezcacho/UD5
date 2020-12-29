using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e4
    {
        class Ex04
        {

            public static void Factorial()
            {
                int num;

                Console.WriteLine("Quin numero vols");
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine(factordelnum(num));
            }
            public static int factordelnum(int num)
            {
                int res = num, i;
                for (i = num - 1; i > 0; i--)
                {
                    res *= i;
                }
                return res;
            }
        }
    }
}
