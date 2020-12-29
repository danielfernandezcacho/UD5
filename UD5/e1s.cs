using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e1s
    {
        public class Ej1
        {
            public static void calculoArea()
            {
                String eleccio;
                double resultat;

                Console.WriteLine("que vols escollir --> Circulo Triangulo Cuadrado");
                eleccio = Console.ReadLine().ToLower();

                switch (eleccio)
                {
                    case "circulo":
                        Console.WriteLine("Radi");
                        int radio = Int32.Parse(Console.ReadLine());
                        resultat = areaC(radio);
                        break;
                    case "triangulo":
                        Console.WriteLine("Base");
                        int ba = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Altura");
                        int altura = Int32.Parse(Console.ReadLine());
                        resultat = areaT(ba, altura);
                        break;
                    case "cuadrado":
                        Console.WriteLine("Costat");
                        int lado = Int32.Parse(Console.ReadLine());
                        resultat = areaCua(lado);
                        break;
                    default:
                        Console.WriteLine("No existeix la figura");
                        break;
                }

            }
            public static double areaC(int radio)
            {
                return Math.Pow(radio, 2) * Math.PI;
            }
            public static double areaT(int ba, int altura)
            {
                return ba * altura / 2;
            }
            public static double areaCua(int lado)
            {
                return lado * lado;
            }
        }
    }
}

