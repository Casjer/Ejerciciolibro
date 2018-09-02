using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejerciciolibro
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            for (; ; )
            {
                Console.WriteLine("Aqui tenemos todos los ejercicios del capitulo 1 hastas el capitulo 4");
                Console.WriteLine("Escoge una opcion: ");
                Console.WriteLine("1- Capitulo1 ");
                Console.WriteLine("2- Capitulo2 ");
                Console.WriteLine("3- Capitulo3 ");
                Console.WriteLine("4- Capitulo4 ");
                linea = Console.ReadLine();
                Console.Clear();
                switch (linea)
                {
                    case "1":
                        Console.WriteLine("1- nombre en pantalla de consola");
                        Console.WriteLine("2- mas texto en pantalla de consola");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Ejerciciolibro.capitulo1_5 C = new Ejerciciolibro.capitulo1_5();
                            C.Print();

                        }
                        else
                            if (linea == "2")
                        {
                            Ejerciciolibro.capitulo1_5 C = new Ejerciciolibro.capitulo1_5();
                            C.Printv();
                        }
                        Console.Clear();

                        break;

                    case "2":
                        Console.WriteLine("1- perimetro poligono regular");
                        Console.WriteLine("2- conversion de grados radianes");
                        Console.WriteLine("3- conversion de celcio a fahreinhgt");
                        Console.WriteLine("4- cambio de dolar y euro");

                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Ejerciciolibro.capitulo2_1_3_5 C = new Ejerciciolibro.capitulo2_1_3_5();
                            C.CalPerim();

                        }
                        else
                            if (linea == "2")
                        {
                            Ejerciciolibro.capitulo2_1_3_5 C = new Ejerciciolibro.capitulo2_1_3_5();
                            C.GradRad();
                        }
                        else
                            if (linea == "3")
                        {
                            Ejerciciolibro.capitulo2_1_3_5 C = new Ejerciciolibro.capitulo2_1_3_5();
                            C.DolEur();
                        }
                         Console.Clear();

                        break;

                    case "3":
                        Console.WriteLine("1- numero par e impar");
                        Console.WriteLine("2- los dias de la semana");
                        Console.WriteLine("3- area y perimetro de poligono regular");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Ejerciciolibro.capitulo3_1_4_5 C = new Ejerciciolibro.capitulo3_1_4_5();
                            C.nump();

                        }
                        else
                            if (linea == "2")
                        {
                            Ejerciciolibro.capitulo3_1_4_5 C= new Ejerciciolibro.capitulo3_1_4_5();
                            C.Dias();
                        }
                        else
                            if (linea == "3")
                        {
                            Ejerciciolibro.capitulo3_1_4_5 C = new Ejerciciolibro.capitulo3_1_4_5 ();
                            C.CalArPer();
                        }
                        Console.Clear();

                        break;

                    case "4":
                        Console.WriteLine("1- tabla de multiplicacion");
                        Console.WriteLine("2- potencia de un numero");
                        Console.WriteLine("3- numeros primos");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Ejerciciolibro.capitulo4_1_2_5 C = new Ejerciciolibro.capitulo4_1_2_5();
                            C.Multi();

                        }
                        else
                            if (linea == "2")
                        {
                            Ejerciciolibro.capitulo4_1_2_5 C = new Ejerciciolibro.capitulo4_1_2_5();
                            C.numel();
                                 
                        }
                        else
                           if (linea == "3")
                        {
                            Ejerciciolibro.capitulo4_1_2_5 C = new Ejerciciolibro.capitulo4_1_2_5();
                            C.edad();
                                
                        }
                        Console.Clear();

                        break;

                    default:
                        Console.WriteLine("lamentablemente esa opción no es valida\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
    

