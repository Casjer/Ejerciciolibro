using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejerciciolibro
{
    class capitulo2_1_3_5
    {
        public void CalPerim()
        {
            double nLados, vLados;

            Console.WriteLine("Digite el numero de lados del poligono: ");
            nLados = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el valor de los lados: ");
            vLados = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El perimetro del poligono es: " + nLados * vLados);
        }

        public void GradRad()
        {
            int grados = 0, cons = 180;

            Console.WriteLine("Digite los grados: ");
            grados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Conversion: " + grados + "." + "PI.rad / " + cons);
        }

        public void DolEur()
        {
            float tasa = 0, cantidad = 0;
            int opcion = 0;

            while (opcion != 3)
            {
                Console.Clear();
                Console.WriteLine("elige una opcion");
                Console.WriteLine("1-Convertir de dolares a euros");
                Console.WriteLine("2-Convertir de euros a dolares");
                Console.WriteLine("3-salir");
              
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite la tasa de cambio: ");
                        tasa = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Digite la cantidad a cambiar: ");
                        cantidad = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + cantidad * tasa);

                        Console.ReadKey();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite la tasa de cambio: ");
                        tasa = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Digite la cantidad a cambiar: ");
                        cantidad = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + cantidad * tasa);

                        Console.ReadKey();

                        break;
                }
            }
        }

    }
}
