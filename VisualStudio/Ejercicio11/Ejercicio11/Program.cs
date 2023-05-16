using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumDatos, ValorDeDato, i, ContadorDeUnos;
            NumDatos = 0;
            ContadorDeUnos = 0;
            Console.Write("Inserta la cantidad de Números a ingresar: ");
            NumDatos = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= NumDatos; i++)
            {
                Console.Write("Inserta el valor numerico " + i + ":");
                ValorDeDato = Convert.ToInt32(Console.ReadLine());

                if (ValorDeDato == 1)
                {
                    ContadorDeUnos = ContadorDeUnos + 1;
                }
            }

            Console.WriteLine("La cantidad de unos es igual a: " + ContadorDeUnos);
            Console.ReadKey();
        }
    }
}