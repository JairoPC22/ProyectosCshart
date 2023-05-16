using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Program
    {
        // Función que determina si un número es perfecto o no.
        static bool EsNumeroPerfecto(int numero)
        {
            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            return sumaDivisores == numero;
        }

        static void Main(string[] args)
        {
            // Pedimos al usuario que ingrese la cantidad de veces que desea ingresar el valor de N.

            Console.Write("¿Cuántas veces deseas ingresar el valor de N? N puede ser igual a cualquier número ");
            int cantidadDeVeces = int.Parse(Console.ReadLine());

            // Repetimos el proceso de búsqueda de números perfectos para la cantidad de veces que indicó el usuario.
            for (int i = 0; i < cantidadDeVeces; i++)

            {
                // Pedimos al usuario que ingrese el valor de N.

                Console.Write("Ingrese el valor de N ({i + 1}): ");
                int N = int.Parse(Console.ReadLine());

                // Creamos una variable para verificar si se encontró algún número perfecto.
                bool hayPerfecto = false;

                // Imprimimos los números perfectos encontrados en el rango deseado.
                Console.WriteLine("Los números perfectos menores o iguales a {N} son:");

                for (int j = 1; j <= N; j++)
                {
                    if (EsNumeroPerfecto(j))
                    {
                        Console.WriteLine(j);
                        hayPerfecto = true; // Marcamos que se encontró al menos un número perfecto.
                    }
                }

                // Si no se encontró ningún número perfecto, se imprime el mensaje correspondiente.
                if (!hayPerfecto)
                {
                    Console.WriteLine($"No se encontraron números perfectos menores o iguales a {N}");
                }
            }
            Console.ReadLine();

        }
    }
}
