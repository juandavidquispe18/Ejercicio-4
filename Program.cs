using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar y definir datos
            Console.WriteLine("Ingrese el número límite: ");
            int num_limit_01 = int.Parse(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("Escoja una opción: ");
            Console.WriteLine("1: Números pares");
            Console.WriteLine("2: Números impares");
            Console.WriteLine("3: Factorial");

            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("*************************");

            //Determinar números pares, impares y factorial
            switch (opcion)
            {
                case 1:
                    Console.Write("Números pares: ");
                    for (int i = 2; i <= num_limit_01; i += 2)
                    {
                        Console.Write(i + ", ");
                    }
                    break;

                case 2:
                    Console.Write("Números impares: ");
                    for (int i = 1; i <= num_limit_01; i += 2)
                    {
                        Console.Write(i + ", ");
                    }
                    break;

                case 3:
                    long factorial = 1;
                    for (int i = 1; i <= num_limit_01; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"El factorial es: {factorial}");
                    break;
                default:

                    //Mostrar resultados
                    Console.WriteLine("Error: Opción inválida. ");
                    Console.WriteLine("Por favor, seleccione una opción válida. ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
