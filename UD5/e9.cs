using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e9
    {
        public static void Array2()
        {
            int i = 6, ii=0;
            int[] array = new int[i];

            Console.WriteLine("El array te una longutud de " + i);
            for (ii = 0; ii < i; ii++)
            {
                Console.WriteLine("Introdueix un num " + (ii + 1));
                array[ii] = Int32.Parse(Console.ReadLine());
            }//pantalla
            for (ii = 0; ii < i; ii++)
            {
                Console.WriteLine(array[ii]);
            }
        }
    } 
}
