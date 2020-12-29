using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e13
    {
        public static void Array5()
        {
            Random rnd = new Random();

            int longitud, i;

            Console.WriteLine("longitud de array");
            longitud = Int32.Parse(Console.ReadLine());
            int[] array = new int[longitud];

            for (i = 0; i < longitud; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
            for (i = 0; i < longitud; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
