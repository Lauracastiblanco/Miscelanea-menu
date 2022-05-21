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
                            multiplos(); break;
                        case '2':
                            impares(); break;
                        case '3':
                            pares(); break;
                            case '4':
                            cuadrados30(); break;
                            case '5':
                            sumacuadrados(); break;
                            case '6':
                            sumanegativos(); break;
                            case '7':
                            sumacero(); break;
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
         public double multiplos()
        {
            Console.WriteLine("Ingrese un numero entero , para saber si es multiplo de 3");
            a = int.Parse(Console.ReadLine());
            if (a / 3 == 0)
            {
                Console.WriteLine(a + " Es multiplo de 3");
            }
            else
            {
                Console.WriteLine("No es multiplo de 3");
            }
            return a;
        }
        public double impares()
        {
            Console.WriteLine("Los numeros impares del 1 al 100 son: ");
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(" | " + i);
            }
            return 0;
        }
        public double pares()
        {
            Console.WriteLine("Los numeros pares del 1 al 100 son: ");
            {
                for (int i = 0; i < 101; i +=2)
                {
                    Console.Write(" | " + i);
                }
            }
            return 0;
        }
        public double cuadrados30()
        {
            Console.WriteLine("Los cuadrados de los numeros del 1 al 30 son: ");
            for (int i = 1; i < 30; i ++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadLine();
           return 0;
     
        }
        public double sumacuadrados()
        {
            Console.WriteLine("Los cuadrados de los numeros del 1 al 100 son: ");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("El numero" + i);
                c = c + i * i;
                Console.WriteLine("el cuadrado es:" + Math.Pow(i, 2));
            }
            Console.WriteLine("la suma total de los cuadrados es: " + c);
            Console.ReadLine();
            return 0;

        }
        public double sumanegativos()
        {
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Ingrese 2 numeros");
            Console.WriteLine("Ingrese el primer numnero");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                for (double i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                }
             }
            else
            {
                Console.WriteLine("No especifico nada");
            }
            return 0;
        }
        
        public double sumacero()
            {
            do
            {
                Console.WriteLine("Digite numeros para sumar(0 para finalizar)");
                a = double.Parse(Console.ReadLine());
                b = b + a;
        
                Console.WriteLine("La suma de los numeros es igual a: " + b);
            }while (a > 0);
            return 0;
            }
}
}



