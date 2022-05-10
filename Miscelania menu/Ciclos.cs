using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Ciclos
    {
        public void ciclos()
        {
            int seleccion;
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
                    SumaCuadrados100 (); break;
                case '2':
                    break; 

                    

                case '0': Environment.Exit(0); break;
                default: Console.WriteLine("Selecciona una opcion"); break;

            }

            static void SumaCuadrados100()
            {
                
                for (int i = 1; i <101 ; i++)
                {

                    Console.WriteLine(i * i);

                }


            }
        }
    }
}
