using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejerciciolibro
{
    class capitulo4_1_2_5
    {
        public void Multi()
        {
            int N;
            string linea;

            Console.WriteLine("ingrese un numero");
            linea = Console.ReadLine();
            N = int.Parse(linea);

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "x" + N + "=" + i * N + "\n");
            }
            Console.ReadKey();

        }
        public void numel()
        {
            try
            {
                Console.Write("digite un numero: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("digite a que potencia se va a elevar: ");
                int pot = Convert.ToInt32(Console.ReadLine());

                int res = n;

                for (int i = 1; i < pot; i++)
                {
                    res = (res * n);
                }

                Console.Write("el resultado es: " + res);
            }
            catch (Exception)
            {
                Console.Write("digite solo numeros enteros");
            }

            Console.ReadLine();
            Console.ReadKey();
        }


        public void edad()
        {
            string l, c; 
            float lectura, cantidad, menor, mayor, acu = 0; ;

            Console.WriteLine("Digite la cantidad de personas: ");
            c = Console.ReadLine();
            cantidad = Convert.ToSingle(c);


            Console.WriteLine("Digite una edad:");
            l = Console.ReadLine();
            lectura = Convert.ToSingle(l);
            cantidad--;
            menor = mayor = lectura;
            acu += lectura;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Digite una edad:");
                l = Console.ReadLine();
                lectura = Convert.ToSingle(l);

                if (lectura < menor)
                    menor = lectura;

                if (lectura > mayor)
                    mayor = lectura;

                acu += lectura;
            }

            Console.WriteLine("la edad menor es:" + menor + "\n" + "la edad mayor es:" + mayor + "\n" + "el promedio es: " + acu / (cantidad + 1));
            Console.ReadKey();
        }
    }
}
