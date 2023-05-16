using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba de EmpleadoPorComision
            //Se crea la instancia del objeto EmpleadoPorComision
            EmpleadoPorComision empleado = new EmpleadoPorComision("Jairo", "Parker", "231-110-1451", 10000.00M, 0.06M);

            //Muestra datos del empleado por comision
            Console.WriteLine("Informacion el empleado obtenida por las propiedades y los metodos: \n");
            Console.WriteLine("{0}{1}", "El primer nombre es: ", empleado.PrimerNombre);
            Console.WriteLine("{0}{1}", "El apellido es ", empleado.ApellidoPaterno);
            Console.WriteLine("{0}{1}", "El numero de seguro social es ", empleado.NumeroSeguroSocial);
            Console.WriteLine("{0}{1:C}", "las ventas brutas son ", empleado.VentasBrutas);
            Console.WriteLine("{0}{1:F2}", "La tarifa de comision es ", empleado.TarifaComision);
            Console.WriteLine("{0}{1:C}", "Los ingresos son", empleado.Ingresos());

            empleado.VentasBrutas = 5000.00M;
            empleado.TarifaComision = 0.1M;

            Console.WriteLine("\n{0}:\n\n{1}", "Se actualizo la info del empleado obtenida por ToString", empleado); 
            Console.WriteLine("Ingresos: {0:C}", empleado.Ingresos());
        }
    }
}
