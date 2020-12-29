using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e2
    {
            public static void NumRand()
            {
                int limit, num1, num2, i;

                Console.WriteLine("Introdueix en nuemero de cuantitat de nuemeros que vulguis");
                limit = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Quine es el teu primer numero");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Quin es el numero final");
                num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");

                for (i = 0; i < limit; i++)
                {
                    Console.WriteLine(generarRandom(num1, num2));
                }
            }
            public static int generarRandom(int num1, int num2)
            {
                Random rnd = new Random();
                return rnd.Next(num1, num2 + 1);
            }
        }
    }

