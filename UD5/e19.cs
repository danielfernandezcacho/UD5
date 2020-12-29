using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e19
    {
        public static void Array14()
        {
            Console.WriteLine("array");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            LlenarArray(array);
            Console.WriteLine("El numero mas grnade es: " + Mayor(array));
        }
        public static void LlenarArray(int[] array)
        {
            int num = 0, i = 0, numAux = 0;
            while (i < array.Length)
            {
                numAux = GenerarRandom(num);
                if (numAux != 0)
                {
                    array[i] = numAux;
                    i++;
                }
            }

        }
        public static int GenerarRandom(int num)
        {
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 101); 

            if (numero <= 1)
            {
                return 0;
            }
            int cont = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0) 
                {
                    cont++;
                }
            }

            if (cont > 2) 
            {
                return 0; 
            }
            else
            {
                return numero;
            }

        }
        public static int Mayor(int[] array)
        {
            int mayor = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mayor)
                {
                    mayor = array[i];
                }
            }
            return mayor;
        }
    }
}
