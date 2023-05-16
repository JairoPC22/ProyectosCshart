using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Num1, Num2, Num3, Num4, Num5;
            string matri;
            double Extra;
            Console.WriteLine("*****************ESCUELA NIÑOS HEROES*****************");
            Console.WriteLine("Matricula del alumno: ");
            matri = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Calificacion Matematicas: ");
            Num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion Historia: ");
            Num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion Ciencias: ");
            Num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion Español: ");
            Num4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion Geografia: ");
            Num5 = float.Parse(Console.ReadLine());

            Extra = (((Num1 + Num2 + Num3 + Num4 + Num5) / 5));
            Console.WriteLine("El alumno con matricula: "+ matri);
            Console.WriteLine("Tiene un promedio: {0:F2}", Extra);
            Console.WriteLine("{0}\nMatematicas:  {1}\nHistoria: {2}\nCiencias: {3}\nEspañol: {4}\nGeografia: {5}",
                "Calificaciones:\n", Num1,
                Num2, Num3, Num4, Num5);
            if (Extra >= 6)
            {
                Console.WriteLine("Estas APROBADO");
            }
            else 
            {
                Console.WriteLine("ESTAS REPROBADO");
            }
            Console.ReadKey();
        }

    }
}
