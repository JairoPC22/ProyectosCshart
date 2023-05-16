using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*** Construya el diagrama de flujo, y el programa en c#, que realice lo siguiente:
            Dado como dato un numero entero, determina e imprime si el mismo es positivo, negativo o nulo***/

            int DatoEntrada, DatoRepeticion;
            Console.WriteLine("Ingresa la cantidad de veces que insertaras tus valores");
            DatoRepeticion = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < DatoRepeticion; i++)
            {
                Console.WriteLine("Escribe el valor de tu dato: ");
                DatoEntrada = Convert.ToInt32(Console.ReadLine());  

                if(DatoEntrada >0)
                {
                    Console.WriteLine("El dato es positivo");

                }
                else
                {
                    if (DatoEntrada == 0) 
                    {
                        Console.WriteLine("El dato es nulo");
                    }
                    else
                    Console.WriteLine("El numero es negativo"); 
                }

                Console.ReadKey();

            }



        }
    }
}
