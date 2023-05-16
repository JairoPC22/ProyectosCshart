using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeCiclosSyR5A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso de while .... Do...
            int producto = 0;
            Console.WriteLine("Inserta el valor de producto: ");
            producto= Convert.ToInt32(Console.ReadLine());
            while(producto <= 200)
            {
                //Console.WriteLine("Valor de producto: {0}", producto);
                producto = 3 * producto;
                Console.WriteLine("Valor de producto: {0}", producto);
                
            }
            //Uso de Do...While
            int producto1 = 0;
            Console.WriteLine("Inserta el valor perro: ");
            producto1= Convert.ToInt32(Console.ReadLine());

            do
            {
                //Console.WriteLine("Valor de producto: {0}", producto);
                producto1 = 3 * producto1;
                Console.WriteLine("Valor de producto: {0}", producto1);
            }
            while (producto1 <= 200);

            int contandor = 0;
            Console.WriteLine("Inserta el valor maximo perro: ");
            contandor = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contandor; i++)
            {
                Console.WriteLine("Valor de contador: {0}", i);
            }

            Console.ReadKey();
        }
    }
}
