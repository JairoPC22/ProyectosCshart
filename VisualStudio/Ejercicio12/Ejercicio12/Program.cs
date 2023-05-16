using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Supongamos que debemos obtener la suma de los gastos que hicimos en nuestro último viaje, 
            // pero no sabemos exactamente cuántos fueron

            // Declaración y asignación de variables 
            double Gasto, SumaGasto;
            Gasto = 0;
            SumaGasto = 0.0;

            // Lectura y procesado de la información
            while (Gasto != -1)
            {
                Console.Write("Inserta Gasto: ");
                Gasto = Convert.ToDouble(Console.ReadLine());
                SumaGasto += Gasto;
            }

            Console.WriteLine("Tu gasto es: " + SumaGasto);
            Console.ReadKey();
        }
    }
}
