using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class E3
    {
        public static void NumerosPrimos()
        {
            int num;

            Console.WriteLine("Quin numero Vols");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(numeroprim(num));
        }

        public static bool numeroprim(int num)
        {
            
            if (num <= 1)
            {
                return false;
            }
            int cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) 
                {
                    cont++;
                }
            }
            if (cont > 2) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
