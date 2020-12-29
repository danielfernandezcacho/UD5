using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e11
    {
        public static void Array3()
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,10 };
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            Console.WriteLine("resultat de la suna " + suma);
        }
    }
}
