using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejerciciolibro
{
    class capitulo3_1_4_5
    {
        public void nump()
        {
            int n = 0;

            Console.WriteLine("Digite un numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("El numero es par.");
            else
                Console.WriteLine("El numero es impar.");
        }

        public void Dias()
        {
            int dia = 0;

            Console.WriteLine("Digite un numero del 1 al 7: ");
            dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Lunes.");
            }
            if (dia == 2)
            {
                Console.WriteLine("Martes.");
            }
            if (dia == 3)
            {
                Console.WriteLine("Miercoles.");
            }
            if (dia == 4)
            {
                Console.WriteLine("Jueves.");
            }
            if (dia == 5)
            {
                Console.WriteLine("Viernes.");
            }
            if (dia == 6)
            {
                Console.WriteLine("Sabado.");
            }
            if (dia == 7)
            {
                Console.WriteLine("Domingo.");
            }
        }

        public void CalArPer()
        {
            float cantLados = 0.0f, valorLados = 0.0f, altura = 0.0f;
            int opcion = 0;

            while (opcion != 3)
            {
                Console.Clear();
                Console.WriteLine("elija una opcion:");
                Console.WriteLine("1-Area de un poligono.");
                Console.WriteLine("perimetro de un poligono,");
                Console.WriteLine("salir.");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite el numero de lados del poligono: ");
                        cantLados = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Digite el valor de los lados: ");
                        valorLados = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Digite la altura: ");
                        altura = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("El area del poligono es: " + cantLados * valorLados * altura / 2);

                        Console.ReadKey();

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite el numero de lados del poligono: ");
                        cantLados = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Digite el valor de los lados: ");
                        valorLados = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("El perimetro del poligono es: " + cantLados * valorLados);

                        Console.ReadKey();

                        break;

                }
            }
        }
    }
}
