using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu

{ 
    internal class Condicionales

    {
        public void condicionales()
        {

            int a;
            int b;
            char eleccion;

            Console.WriteLine("Por favor, elige un algoritmo:");
            Console.WriteLine(" 1. Un algoritmo para saber si el número ingresado por teclado es positivo o negativo.");
            Console.WriteLine(" 2. Un algoritmo que reciba dos números por teclado y diga cuál es el mayor y cuál el menor.");
            Console.WriteLine(" 3. Un algoritmo que lea tres números enteros positivos y que calcule e imprima en pantalla el menor y el mayor de ellos.");
            Console.WriteLine(" 4. Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine(" 5. Dados dos números A y B encontrar el cociente entre A y B. Recordar que la división por cerono está definida, en ese caso debe aparecer una leyenda anunciando que la división no esposible.");
            Console.WriteLine(" 6. Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine(" 7. Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine("Elija 0 para salir");
            eleccion = char.Parse(Console.ReadLine());


            switch (eleccion)
            {
                case '1':
                    PositivoNegativo(); break;
                case '2':
                    MayorMenor(); break;
                case '3':
                    TresEnteros(); break;
                case '4':
                    SumaResta(); break;
                case '5':
                    Cociente(); break;
                case '6':
                    SumaMultiplicacion(); break;
                case '7':
                    Bisiesto(); break;

                case '0':
                    Environment.Exit(0); break;

                default: Console.WriteLine("-----[Ingresa un numero valido]-----"); break;


            }
            static void PositivoNegativo()

            {
                float a;
                Console.WriteLine("Digita el numero para conocer si es negativo positivo");

            
                    a = Convert.ToSingle(Console.ReadLine());
                    if (a < 0)
                    {
                        Console.WriteLine("El numero es negativo.");
                    }
                    else if (a > 0)
                    {
                        Console.WriteLine("El numero es positivo");
                    }
 
                }
            }
            static void MayorMenor()

            {
                float n1;
                float n2;
                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                n1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                n2 = Convert.ToSingle(Console.ReadLine());
                if (n1 < n2)
                {
                    Console.WriteLine(n1 + " Es menor que " + n2);
                    Console.WriteLine(n2 + " Es mayor que " + n1);
                }
                else if (n1 > n2)
                {
                    Console.WriteLine(n1 + " Es mayor que " + n2);
                    Console.WriteLine(n2 + " Es menor que " + n1);
                }

            }
            static void TresEnteros()

            {
                int n1;
                int n2;
                int n3;

                Console.WriteLine("Para llevar a cabo el programa por favor, digite tres numeros");
                Console.WriteLine("El primer numero es:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El tercer numero es:");
                n3 = Convert.ToInt32(Console.ReadLine());

                if (n1 >= n2 && n1 >= n3)
                {
                    Console.WriteLine(n1 + " Es mayor");
                }
                else if (n2 > n3)
                {
                    Console.WriteLine(n2 + " Es mayor");
                }
                else
                {
                    Console.WriteLine(n3 + " Es mayor");

                }
                if (n1 <= n2 && n1 <= n3)
                {
                    Console.WriteLine(n1 + " Es menor");
                }
                else if (n2 < n3)
                {
                    Console.WriteLine(n2 + " Es menor");
                }
                else
                {
                    Console.WriteLine(n3 + " Es menor");

                }

            }
            static void SumaResta()

            {
                int A;
                int B;
                int resta;
                int suma;

                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                B = Convert.ToInt32(Console.ReadLine());

                if (A < B)
                {
                    suma = A - B;
                    Console.WriteLine("El resultado de la suma es: " + suma);


                }
                else if (A > B)
                {
                    resta = B - A;
                    Console.WriteLine("El resultado de la resta: " + resta);
                }
            }

            static void Cociente()

            {
                int a;
                int d;
                int division;
                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                d = Convert.ToInt32(Console.ReadLine());

                if (d == 0 || a == 0)
                {
                    Console.WriteLine("La division no es posible");
                }
                else if (d > 0)
                {
                    division = a / d;
                    Console.WriteLine(" El resultado de la divison es; " + division);

                }

            }
            static void SumaMultiplicacion()

            {
                int a;
                int b;
                int suma;
                int multiplicacion;

                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a < 0 || b < 0)
                {
                    suma = a + b;
                    Console.WriteLine(suma);
                }
                else if (a > 0 || b > 0)
                {
                    multiplicacion = a * b;
                    Console.WriteLine(" El resultado de la multiplicacion es: " + multiplicacion);

                }
            }

            static void Bisiesto()

            {
                int a;
                Console.WriteLine("Digite un año para saber si es bisiesto");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto" + a);
                }
                else
                {
                    Console.WriteLine("no es bisiesto " + a);
                }

            }



        }
    }
