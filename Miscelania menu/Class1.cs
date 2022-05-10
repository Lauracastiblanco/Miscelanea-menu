using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Class1
    {

        public static void mein()

        {
            int seleccion;
            Console.WriteLine("Bienvenido al Menu");
            Console.WriteLine("Elija 1 si desea ir a la seccion de operadores");
            Console.WriteLine("Elija 2 si desea ir a la seccion de condicionales");
            Console.WriteLine("Elija 3 si desea ir a la seccion de bucles");
            Console.WriteLine("Elija 4 si desea ir a la seccion de arreglos");
            Console.WriteLine("Elija 0 para salir del Menu");

            seleccion = char.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case '1':
                    operadores();break;
                case '2':
                    Condicionales();break;
                case '0':Environment.Exit(0); break;
                default: Console.WriteLine("Selecciona una opcion"); break;

            }
        }

        public static void operadores()
        {
            int a;
            int b;
            char opcion;

            Console.WriteLine("Por favor, elige una operacion:");
            Console.WriteLine(" 1. Area de un triangulo");
            Console.WriteLine(" 2. Suma ");
            Console.WriteLine(" 3. Potencia al cuadrado");
            Console.WriteLine(" 4. Conversion euros a dolares");
            Console.WriteLine(" 5. Area y perimetro de un cuadrado");
            Console.WriteLine(" 6. Area y volumen de un cilindro");
            Console.WriteLine(" 7. Area y perimetro de un circulo");
            Console.WriteLine(" 8. Promedio de 3 numeros");
            Console.WriteLine("Elija 0 para salir");
            opcion = char.Parse(Console.ReadLine());


            switch (opcion)
            {
                case '1':
                    AreaTriangulo(); break;
                case '2':
                    SumaEnteros(); break;
                case '3':
                    PotenciaEnteros(); break;
                case '4':
                    Conversion(); break;
                case '5':
                    AreaPerimetroCuadrado();break;
                case '6':
                    AreaVolumenCilindro();break;
                case '7':
                    AreaPerimetroCirculo();break;
                case '8':
                    PromedioTres();break;

                case '0':
                    Environment.Exit(0);break;

                default: Console.WriteLine("Selecciona una opcion");break;


            }

            static void AreaTriangulo()

            {
                int a;
                int b;
                int area;

                Console.WriteLine("Por favor, digite la base del triangulo");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ahora, por favor, digite la altura");
                a = Convert.ToInt32(Console.ReadLine());
                area = b * a / 2;
                Console.WriteLine("El area del tringulo es: " + area);
            }

            static void SumaEnteros()
            {
                int n1;
                int n2;
                int total;
                Console.WriteLine("Por favor digite el primer numero para realizar la suma");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Por favor digite el segundo numero para completar la suma");
                n2 = Convert.ToInt32(Console.ReadLine());
                total = n1 * n2;
                Console.WriteLine("El resultado de la suma es: " + total);
            }
            static void PotenciaEnteros()
            {
                int numero1;
                int total;
                Console.WriteLine("Por favor digite un numero para saber el cuadrado");
                numero1 = Convert.ToInt32(Console.ReadLine());
                total = numero1 * numero1;
                Console.WriteLine("El resultado de la potencia es: " + total);
            }

            static void Conversion()
            {
                float e;
                float d;
                Console.WriteLine("Digite el numero en Euros");
                e = Convert.ToSingle(Console.ReadLine());
                d = (float)(e * 1.0831);
                Console.WriteLine(e + " en doloares es " + d);
            }
            static void AreaPerimetroCuadrado ()
            {
                int l;
                int a;
                int p;
                Console.WriteLine("Digite la medida de un lado del cuadrado");
                l = Convert.ToInt32(Console.ReadLine());
                p = l * 4;
                a = l * l;
                Console.WriteLine("El perimetro de su cuadrado es: " + p);
                Console.WriteLine("El area de su cuadrado es: " + a);
            }
            static void AreaVolumenCilindro ()
            {
                int ar;
                int vol;
                int rad;
                int al;
                Console.WriteLine("Digite el radio de su cilindro");
                rad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite la altura del cilindro");
                al = Convert.ToInt32(Console.ReadLine());
                ar = (int)(System.Math.PI * 2 * rad + al + System.Math.PI * 2 * rad * rad);
                vol = ((int)(System.Math.PI * rad * rad * al));
                Console.WriteLine("El area de su cilindro es: " + ar);
                Console.WriteLine("El volumen de su cilindro es " + vol);
            }
            static void AreaPerimetroCirculo ()
            {
                int r;
                int a;
                int l;
                Console.WriteLine("Digite el radio de la circunferencia");
                r = Convert.ToInt32(Console.ReadLine());
                l = (int)(r * 2 * System.Math.PI);
                a = (int)(System.Math.PI * r * r);
                Console.WriteLine("El area del circulo es: " + a);
                Console.WriteLine("La longitud de la circunferencia es: " + l);
            }
            static void PromedioTres ()
            {
                int numeros;
                int n2;
                int n3;
                int promedio;
                Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
                Console.WriteLine("Digite el primer numero");
                numeros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el tercer numero");
                n3 = Convert.ToInt32(Console.ReadLine());
                promedio = numeros + n2 + n3 / 3;
                Console.WriteLine("El promedio de sus numeros es: " + promedio);
            }



        }
        public static void Condicionales()
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

                default: Console.WriteLine("Selecciona una opcion"); break;


            }
            static void PositivoNegativo()

            {
                float e;
                Console.WriteLine("Digita el numero para conocer si es negativo positivo");
                try
                {
                    e = float.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("No has introducido el numero valido");
                    e = 0;
                }

                if (e < 0)
                {
                    Console.WriteLine("El numero es negativo.");
                }
                else if (e > 0)
                {
                    Console.WriteLine("El numero es positivo");
                }
            }
            static void MayorMenor()

            {
                float n1;
                float n2;
                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                n1 = float.Parse(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                n2 = float.Parse(Console.ReadLine());

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
}

