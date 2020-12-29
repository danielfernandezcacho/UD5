using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e14
    {
        public static void Array7()
        {
            Random rnd = new Random();

            int longitud, i, numero;
            bool ran = false;

            Console.WriteLine("longitus de el array");
            longitud = Int32.Parse(Console.ReadLine());
            int[] array = new int[longitud];

            for (i = 0; i < longitud; i++)
            {
                array[i] = rnd.Next(1, 11);
            }

            Console.WriteLine("longitud de el array");
            numero = Int32.Parse(Console.ReadLine());

            try
            {
                for (i = 0; i < longitud || ran; i++)
                {
                    if (numero == array[i])
                    {
                        ran = true;
                    }
                }
            }
            catch (Exception) { }
            if (ran)
            {
                Console.WriteLine("Si que esta");
            }
            else
            {
                Console.WriteLine("No esta");
            }
        }
    }
}
