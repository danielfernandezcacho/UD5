using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e20
    {
        public static void Arrays15()
        {
            Random rnd = new Random();

            int num, i;
            Console.WriteLine("tamany de arrat");
            num = Int32.Parse(Console.ReadLine());

            int[] primerArray = new int[num];
            int[] segundoArray;

            for (i = 0; i < num; i++)
            {
                primerArray[i] = rnd.Next(1, 101);
            }

            segundoArray = primerArray;
            primerArray = new int[num];

            for (i = 0; i < num; i++)
            {
                primerArray[i] = rnd.Next(1, 101);
            }

            int[] tercerArray = Multiplicacion(primerArray, segundoArray);

            Console.WriteLine("Primer Array");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(primerArray[i]);
            }

            Console.WriteLine("Segun Array");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(segundoArray[i]);
            }

            Console.WriteLine("Tercer Array");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(tercerArray[i]);
            }
        }

        public static int[] Multiplicacion(int[] primerArray, int[] segundoArray)
        {
            int[] tercerArray = new int[primerArray.Length];
            for (int i = 0; i < primerArray.Length; i++)
            {
                tercerArray[i] = primerArray[i] * segundoArray[i];
            }
            return tercerArray;
        }

    }
}
