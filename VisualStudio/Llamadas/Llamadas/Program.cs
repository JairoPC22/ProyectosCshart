using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llamadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int llamadasLocales = 0, duracionLlamada = 0;
            double cuenta = 0.0, costo = 0.0;
            char tipoLlamada;

            while (true)
            {
                Console.Write("Inserta Tipo de llamada (I, N, L) o X para salir: ");
                tipoLlamada = Convert.ToChar(Console.ReadLine());

                if (tipoLlamada == 'X') break;

                Console.Write("\nInserta la duracion llamada en minutos (-1 para salir): ");
                duracionLlamada = Convert.ToInt32(Console.ReadLine());

                switch (tipoLlamada)
                {
                    case 'I':
                        if (duracionLlamada > 3) costo = 7.59 + (duracionLlamada - 3) * 3.03;
                        else costo = 7.59;
                        break;
                    case 'N':
                        if (duracionLlamada > 3) costo = 1.20 + (duracionLlamada - 3) * 0.48;
                        else costo = 1.20;
                        break;
                    case 'L':
                        llamadasLocales++;
                        if (llamadasLocales > 50) costo = 0.60;
                        else costo = 0.0;
                        break;
                    default:
                        Console.WriteLine("\nEsa opcion no existe");
                        continue;
                }

                cuenta += costo;
            }

            Console.WriteLine("\nEl total a pagar es de: {0}", cuenta);
            Console.ReadLine();
        }
    }
}
