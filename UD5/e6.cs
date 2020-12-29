using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e6
    {
        public static void Xifres()
        {
            int num = 100;
            do
            {
                Console.WriteLine("Quin numero vols");
                num = Int32.Parse(Console.ReadLine());
            } while (num < 0);

            Console.WriteLine("Cifras: " + calcularxifres(num));
        }
        public static int calcularxifres(int num)
        {
            int cont = 0, i;

            for (i = num; i > 0; i /= 10)
            {
                cont++;
            }
            return cont;
        }
    }
}
