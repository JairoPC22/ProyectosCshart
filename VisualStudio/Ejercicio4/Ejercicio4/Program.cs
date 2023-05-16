using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, i, j, contador;
            contador = 0;

0
            Console.Write("Inserta número máximo: ");
            M = Convert.ToInt32(Console.ReadLine());

         
            for (i = 2; i <= M; i++)
            {
                j = 2;
                while (j <= i / 2 && i % j != 0)
                {
                    j = j + 1;
                }

                if (j > i / 2)
                {
                    contador = contador + 1;
                    Console.WriteLine(i + " es primo");
                }
            }

            Console.WriteLine("Hay " + contador + " numeros primos menores a M.");
            Console.ReadLine();
        }
    }
}