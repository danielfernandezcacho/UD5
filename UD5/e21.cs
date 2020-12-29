using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e21
    {
        public static void Ultimoarray()
        {
            Random rnd = new Random();

            Console.WriteLine("Arrayultimo");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            int num, i;

            do
            {
                Console.WriteLine("num entre 0 i 9");
                num = Int32.Parse(Console.ReadLine());
            } while (!(num >= 0 && num <= 9));

            for (i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 301);
            }

            int[] terminados = numt(array, num);

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(terminados[i]);
            }
        }
        public static int[] numt(int[] array, int ultimo_numero)
        {
            int[] terminado = new int[array.Length];

            int final = 0;

            for (int i = 0; i < array.Length; i++)
            {
                final = array[i] - (array[i] / 10 * 10);
                if (final == ultimo_numero)
                {
                    terminado[i] = array[i];
                }
            }

            return terminado;
        }
    }
}
