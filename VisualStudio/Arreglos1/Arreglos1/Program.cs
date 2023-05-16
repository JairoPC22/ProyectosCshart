using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*******************************************************************************
            int[] arreglo; //Declaracion de un arreglo

            //Crear el tamaño e inicializar arreglo
            arreglo = new int[10]; //Arreglo de 10 elementos 

            //Encabezados
            Console.WriteLine("{0}{1,8}", "Indice", "Valor");

            //Impresion de valor de cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);

            //*******************************************************************************

            //*******************************************************************************
            int[] arreglos2 = { 24, 65, 90, 88, 90, 345, 222, 34, 78, 99, 908 };

            Console.WriteLine("{0}{1,8}", "Indice", "Valor");
            for (int contador = 0; contador < arreglos2.Length; contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglos2[contador]);


            //*******************************************************************************
            const int LONGIUTUD_ARREGLO = 10;
            int[] arreglo3 = new int[LONGIUTUD_ARREGLO];

            for (int contador3 = 0; contador3 < arreglo3.Length; contador3++)
                arreglo3[contador3] = 2 + 2 * contador3;

            Console.WriteLine("{0}{1,8}", "Indice", "Valor");

            for (int contador3 = 0; contador3 < arreglo3.Length; contador3++)
                Console.WriteLine("{0,5}{1,8}", contador3, arreglo3[contador3]);




            //*******************************************************************************
            int[] arreglos4 = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 1 };
            Console.WriteLine("Distribucion de calificaciones: ");
            for (int contador4 = 0; contador4 < arreglos4.Length; contador4++)
            {
                //Se muesteran etiquetas de las barras ("00-09: "..., "98-99", "100")
                if (contador4 == 10)
                    Console.WriteLine("100: ");
                else
                    Console.WriteLine("{0:D2}-{1:D2}", contador4 * 10, contador4 * 10 + 9);

                for (int estrellas = 0; estrellas < arreglos4[contador4]; estrellas++)
                    Console.WriteLine("*");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
