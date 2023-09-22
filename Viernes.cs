using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Viernes
    {
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            int numberMenu = 0;
            Console.WriteLine("");
            Console.WriteLine("Escoger una opción");
            Console.WriteLine("1 - sumar");
            Console.WriteLine("2 - restar");
            Console.WriteLine("3 - dividir");
            Console.WriteLine("4 - multiplicar");
            Console.WriteLine("0 - salir");

            numberMenu = readNumber();

            num1 = readNumber();
            num2 = readNumber();

            switch (numberMenu)
            {
                case 1:
                    Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("La resta de " + num1 + " y " + num2 + " es: " + (num1 - num2));
                    break;
                case 3:

                    while (num2 == 0)
                    {
                        Console.WriteLine("El 0 no es válido. Introduce otro número");
                        num2 = readNumber();
                    }

                    Console.WriteLine("La división de " + num1 + " y " + num2 + " es: " + (num1 / num2));
                    break;
                case 4:
                    Console.WriteLine("La multiplicación de " + num1 + " y " + num2 + " es: " + (num1 * num2));
                    break;
            } while (numberMenu != 0) ;

            int readNumber()
            {
                string text;
                int number = 0;
                {
                    Console.WriteLine("Introduce un número");
                    text = Console.ReadLine();
                    number = Convert.ToInt32(text);
                }
                return number;
            }
        }
    }
}

