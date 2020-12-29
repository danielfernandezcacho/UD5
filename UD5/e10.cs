using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e10
    {
        public static void Taulademultiplicar()
        {
            int num, i;
            int[] tabla = new int[11];

            Console.WriteLine("Quin numero vols multiplicar");
            num = Int32.Parse(Console.ReadLine());
            for (i = 0; i < tabla.Length; i++)
            {
                tabla[i] = num * i;
            }

            Console.WriteLine("");

            for (i = 0; i < tabla.Length; i++)
            {
                Console.WriteLine(tabla[i]);
            }
        }
    }
}
