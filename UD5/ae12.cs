    using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class ae12
    { 
        public static void Array4()
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,10 };
            double suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
              suma += array[i];
            }

            Console.WriteLine("La mitjana es: " + (double)(suma / array.Length));
        }
     } 
}
