using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, i, suma, j, k, contador;

            Console.Write("Inserta cuantas veces deseas que se repita el proceso: ");
            contador = Convert.ToInt32(Console.ReadLine());

            for (k = 1; k <= contador; k++)
            {
                N = 0; i = 1;
                Console.Write("Inserta valor maximo: ");
                N = Convert.ToInt32(Console.ReadLine());

                while (i <= N)
                {
                    suma = 0; j = 1;

                    while (j <= (i / 2))
                    {
                        if (i % j == 0)
                        {
                            suma = suma + j;
                        }
                        j = j + 1;
                    }

                    if (suma == i)
                    {
                        Console.WriteLine("Es numero perfecto: " + i);
                    }

                    i = i + 1;
                }
            }
            Console.ReadKey();
        }
    }
}

