using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e18
    {
        public static void Array11()
        {
            Console.WriteLine("Array");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            Arrayll(array);
            arraym(array);
        }

        public static void Arrayll(int[] array)
        {
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarRandom(num);
            }

        }
        private static int GenerarRandom(int num)
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }
        public static void arraym(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
                Console.WriteLine("posicio " + (i + 1) + "--> " + array[i]);
            }
            Console.WriteLine("La suma de tot el array es --> " + suma);
        }
    }
}
