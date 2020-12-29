using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e7
    {
        public static void Cambidemonedes()
        {
            String eleccio;
            double valor;

            Console.WriteLine("Quina moneda vols converit --> Dolar Yen Libra");
            eleccio = Console.ReadLine().ToLower();
            Console.WriteLine("digues la cuantitat que vols compartir");
            valor = Double.Parse(Console.ReadLine());
            canvi(valor, eleccio);
        }

        public static void canvi(double valor, String eleccion)
        {
            double cambio = 0;
            bool error = true;

            switch (eleccion)
            {
                case ("dolar"):
                    cambio = valor * 1.28611;
                    break;
                case ("yen"):
                    cambio = valor * 129.852;
                    break;
                case ("libra"):
                    cambio = valor * 0.86;
                    break;
                default:
                    Console.WriteLine("no puc combertir a mes menedes");
                    error = false;
                    break;
            }

            if (error)
            {
                Console.WriteLine(cambio);
            }
        }
    }
}
