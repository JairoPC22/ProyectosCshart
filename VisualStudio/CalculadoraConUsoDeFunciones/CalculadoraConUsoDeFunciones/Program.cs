using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConUsoDeFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float term1, term2, term3, resultado = 0;
            Console.WriteLine("Inserta el valor de A: ");
            term1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el valor de B: ");
            term2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el valor de C: ");
            term3 = Convert.ToInt32(Console.ReadLine());

            sumaABC(term1, term2, term3);
            RestaABC(term1, term2, term3);
            DivisionABC(term1, term2, term3);
            MultipliacionABC(term1, term2, term3);
            Console.ReadKey();

        }
        //Se declara la funcion SumaABC
        public static void sumaABC(float A,float B,float C)
        {
            float Resultado = 0;
            Resultado = A + B + C;
            Console.WriteLine("La suma de {0}+{1}+{2}", A,B,C,Resultado);

        }
        //Se declara la funcion RestaABC
        public static void RestaABC(float A, float B, float C)
        {
            float Resultado = 0;
            Resultado = A - B - C;
            Console.WriteLine("La resta de {0}-{1}-{2}", A, B, C, Resultado);

        }
        //Se declara la funcion DivisionABC
        public static void DivisionABC(float A, float B, float C)
        {
            float Resultado = 0;
            if (B == 0 | C == 0)
            {
                Console.WriteLine("EROR");
            }
            else {
                Resultado = (A / B) / C;
                Console.WriteLine("La divivision de ({0}/{1})/{2}", A, B, C, Resultado);
            }
        }
        //Se declara la funcion MultipliacionABC
        public static void MultipliacionABC(float A, float B, float C)
        {
            float Resultado = 0;
            Resultado = A * B * C;
            Console.WriteLine("La multiplicacion de {0}*{1}*{2}", A, B, C, Resultado);

        }
        float A,B, C;

    }
}
