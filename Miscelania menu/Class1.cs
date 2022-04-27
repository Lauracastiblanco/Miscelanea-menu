using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Class1
    {
        public static void Main(string[] args)

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
                    operadores(); break;
                case '2':
                    Condicionales(); break;
                case '3':
                    Bucles(); break;
                case '4':
                    Arreglos(); break;
                case '0': Environment.Exit(0);
                    break;
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
            Console.WriteLine(" 6. Area y perimetro de un cilindro");
            Console.WriteLine(" 7. Area de un circulo");
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
                    AreaPerimetroCilindro();break;
                case '7':
                    AreaCirculo();break;
                case '8':
                    PromedioTres();break;
                    
                case '0':
                    Environment.Exit(0); break;

                default : Console.WriteLine("Selecciona una opcion"); break; 


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

            static void Conversion ()
            {
                float e;
                float d;
                Console.WriteLine("Digite el numero en Euros");
                e = Convert.ToSingle(Console.ReadLine());
                d = (float)(e * 1.0831);
                Console.WriteLine(e+ " en doloares es " + d);
            }
            static void AreaPerimetroCuadrado ()
            {
                int lado;
                int p;
                int a;
                Console.WriteLine("Digite la medida de un lado del cuadrado");
                lado = Convert.ToInt32(Console.ReadLine());
                p = lado * 4;
                a = lado * lado;
                Console.WriteLine("El perimetro de su cuadrado es: " + p);
                Console.WriteLine("El area de su cuadrado es: " + a);
            }
            static void AreaPerimetroCilindro ()
            {
                int area;
                int volumen;
                int radio;
                int altura;
                Console.WriteLine("Digite el radio de su cilindro");
                radio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite la altura del cilindro");
                altura = Convert.ToInt32(Console.ReadLine());
                area = (int)(System.Math.PI * 2 * radio + altura + System.Math.PI * 2 * radio * radio);
                volumen = ((int)(System.Math.PI * radio * radio * altura));
                Console.WriteLine("El area de su cilindro es: " + area);
                Console.WriteLine("El volumen de su cilindro es " + volumen);
            }
            static void AreaCirculo ()
            {
                int radio;
                int area;
                int longitud;
                Console.WriteLine("Digite el radio de la circunferencia");
                radio = Convert.ToInt32(Console.ReadLine());
                longitud = (int)(radio * 2 * System.Math.PI);
                area = (int)(System.Math.PI * radio * radio);
                Console.WriteLine("El area del circulo es: " + area);
                Console.WriteLine("La longitud de la circunferencia es: " + longitud);
            }
            static void PromedioTres ()
            {
                int datos;
                int d2;
                int d3;
                int promedio;
                Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
                Console.WriteLine("Digite el primer numero");
                datos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero");
                d2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el tercer numero");
                d3 = Convert.ToInt32(Console.ReadLine());
                promedio = datos + d2 + d3 / 3;
                Console.WriteLine("El promedio de sus numeros es: " + promedio);
            }



        }
            public static void Condicionales()
            {
                Console.WriteLine("Pagina en proceso");
            }
            public static void Bucles()
            {
                Console.WriteLine("Pagina en proceso");
            }
            public static void Arreglos()
            {
                Console.WriteLine("Pagina en proceso");
            }
        

        } } 