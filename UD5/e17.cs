using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e17
    {
        public static void Array10()
        {
            int[] array = new int[10];
            nump(array);
            numm(array);

        }
        public static void nump(int[] array)
        {
            int i;

            Console.WriteLine("fica 10 nums");
            for (i = 0; i < 10; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
        }
        public static void numm(int[] array)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("El valor " + (i + 1) + " es " + array[i]);
            }
        }
    }
}
