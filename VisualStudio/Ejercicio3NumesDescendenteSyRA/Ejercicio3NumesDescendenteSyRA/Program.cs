using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3NumesDescendenteSyRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Escribe el valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                if (A > C)
                {
                    if (B > C)
                    {
                        Console.WriteLine("El orden descendente es {0}, {1},{2}", A, B, C);
                    }
                    else
                    {
                        Console.WriteLine("El orden descendente es {0}, {1},{2}", A, C, B);
                    }
                }
                else
                {
                    Console.WriteLine("El orden descendente es {0}, {1},{2}", C, A, B);
                }
            }
            else
            {
                if (B > C)
                {
                    if (A > C)
                    {
                        Console.WriteLine("El orden descendente es {0}, {1},{2}", B, A, C);
                    }
                    else
                    {
                        Console.WriteLine("El orden descendente es {0}, {1},{2}", B, C, A);
                    }
                }

                else
                {
                    Console.WriteLine("El orden descendente es {0}, {1},{2}", C, B, A);
                }
                Console.ReadKey();
            }
        }
    }
}

