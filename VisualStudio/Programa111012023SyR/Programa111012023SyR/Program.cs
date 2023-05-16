using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa111012023SyR
{
    internal class Program
    {
        //Variables globales
        int z;
        static void Main(string[] args)
        {
            //variables locales
            //NombreDelDato , Rango, Tamaño, TipoDe .Net
            //sbyte, -128 a 127, entero de 8 buts con signo, System.Sbyte
            //byte, de 0 a 225, entero de 8 bits sin signo, System.Byte
            //short, de -32768 a 32767, entero de 16 bits sin signo, System.Int16
            //ushort, de 0 a 65535, entero de 16 bits sin signo, System.UInt16
            //int de -2147483648 a 2147483647, entero de 32 bits con signo, System.Int32
            //uint, de 0 a 4294967295, entero de 32 bits sin signo, System.UInt32
            //long, ..., entero de 64 bits con signo, System.Int64
            //ulong, ..., entero de 64 bits sin signo , Sytem.UInt64
            //bool, true o false
            //float, maneja decimales, pero se compara con el int
            //double, Menja decimales, pero se compara con long
            //decimal
            //char --> '', ""
            //String -->""
            sbyte Prueba = 20;
            sbyte A; byte B; short C; ushort D; int E; uint F; long G; ulong H;
            bool J; float K; double L; decimal M; char N; string P;

            //inicializacion de variables
            A = 127; B= 15; C = 3200; D = 60000; E = 2000000; F = 2000000; 
            G = -254215424; H = 25431524; J = false; K= 234; L = 12451241.214;
            M = 123451; N = 'R'; P = "Software";

            Console.WriteLine("El dato sbyte A es igual a: {0}", A);
            Console.WriteLine("El dato byte B es igual a: {0}", B);

        }
    }
}
