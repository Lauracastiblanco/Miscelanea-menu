using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Ciclos
    {
        private double a = 0;
        private double b = 0;
        public void ciclos()
        {
            int seleccion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Bienvenido al Menu");
                    Console.WriteLine("1. ");
                    Console.WriteLine("2. ");
                    Console.WriteLine("3. ");
                    Console.WriteLine("4. ");
                    Console.WriteLine("5. ");
                    Console.WriteLine("5. ");

                    seleccion = char.Parse(Console.ReadLine());

                    switch (seleccion)
                    {
                        case '1':
                            SumaCuadrados100(); break;
                        case '2':
                            NumerosNaturales(); break;
                        case '3':
                            SumaMenosCero(); break;
                        case '0': Environment.Exit(0); break;
                        default: Console.WriteLine("Selecciona una opcion"); break;

                    }
                }catch(FormatException ex)
                {
                    Console.WriteLine("No especifico ninguna opcion valida");
                    Ciclos ciclos = new Ciclos();
                    ciclos.ciclos();
                }
            } while (seleccion == 1 || seleccion == 2 || seleccion == 3 || seleccion == 4 || seleccion == 5 || seleccion == 6 || seleccion == 7 || seleccion == 0);
        }
            public double SumaCuadrados100()
            {

                for (double i = 1; i < 101; i++)
                {

                    Console.WriteLine(i * i);

                }
                return 0;
            }
            public double NumerosNaturales()
            {

                Console.WriteLine("Digita el numero menor");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digita el numero mayor");
                b = double.Parse(Console.ReadLine());

                for (double i = a; i < b; i++)
                {
                    Console.WriteLine(i);

                }

                return 0;
            }
            public double SumaMenosCero()

            {
            do
            {
                Console.WriteLine("Digite numeros para al final ver la suma de estos(0 para finalizar");
                a = double.Parse(Console.ReadLine());
                b = b + a;
        
                Console.WriteLine("La suma de los numeros es igual a: " + b);
            }while (a > 0);
            return 0;
            }

        }
    }


