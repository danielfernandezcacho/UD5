using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e16
    {
        public static void Array9()
        {
            int[] array = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int cont = 0;

            for (int i = 0, j = array.Length - 1; j > i; i++, j--)
            {
                if (array[i] == array[j])
                {
                    cont++;
                }
            }

            if (cont == (array.Length / 2))
            {
                Console.WriteLine("Es capicua");
            }
            else
            {
                Console.WriteLine("No ho es capicua");
            }
        }
    }
}
