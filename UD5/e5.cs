using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e5
    {
        class Ex05
        {
            public static void BinariDecimal()
            {
                int num;

                Console.WriteLine("Diges un numero decimal");
                num = Int32.Parse(Console.ReadLine());

                Console.WriteLine(conversordeBinaris(num));
            }
            public static String conversordeBinaris(int num)
            {
                String binariFinal = "", binari;


                for (int i = num; i > 0; i /= 2)
                {
                    if (i % 2 == 0)
                    {
                        binari = "0";
                    }
                    else
                    {
                        binari = "1";
                    }
                    binariFinal = binari + binariFinal;
                }

                return binariFinal;
            }
        }
    }
}
