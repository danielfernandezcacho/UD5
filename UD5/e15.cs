using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e15
    {
        public static void Array8()
        {
            Random rnd = new Random();

            int longitud, i, num;
            bool ran = false;

            Console.WriteLine("longitud de el arrray");
            longitud = Int32.Parse(Console.ReadLine());
            int[] array = new int[longitud];

            for (i = 0; i < longitud; i++)
            {
                array[i] = rnd.Next(1, 11);
            }

            Console.WriteLine("duguen un numemro");
            num = Int32.Parse(Console.ReadLine());

            try
            {
                for (i = 0; i < longitud || ran; i++)
                {
                    if (num == array[i])
                    {
                        ran= true;
                    }
                }
            }
            catch (Exception) { }
            if (ran)
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
