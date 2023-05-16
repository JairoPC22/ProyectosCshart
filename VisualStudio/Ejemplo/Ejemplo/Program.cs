using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int contadorPositivos = 0;
            int sumaPositivos = 0;
            int sumaTodos = 0;
            char respuesta = 'S';

            while (respuesta == 'S' || respuesta == 's')
            {
                Console.WriteLine("¿Cuántos números desea ingresar?");
                n = Convert.ToInt32(Console.ReadLine());

                int[] numeros = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Ingrese un número:");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                    if (numeros[i] > 0)
                    {
                        contadorPositivos++;
                        sumaPositivos += numeros[i];
                    }

                    sumaTodos += numeros[i];
                }

                int promedioPositivos = sumaPositivos / contadorPositivos;
                int promedioTodos = sumaTodos / n;

                Console.WriteLine("El promedio de los números positivos es " + promedioPositivos + ".");
                Console.WriteLine("El promedio de todos los números es " + promedioTodos + ".");

                Console.WriteLine("¿Desea repetir el proceso? (S/N)");
                respuesta = Console.ReadLine()[0];
            }
        }
    }
}
