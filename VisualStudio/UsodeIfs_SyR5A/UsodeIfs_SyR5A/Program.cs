using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsodeIfs_SyR5A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*** If simple
            byte edad;
            Console.WriteLine("Inserta edad de persona: ");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 65) Console.WriteLine("Aplica para programa 65 y mas");
            Console.ReadKey(); 

            //If doble if...else
            byte calif = 0;
            Console.WriteLine("Inserta calificacion: ");
            calif= Convert.ToByte(Console.ReadLine());
            if (calif >= 60) 
                Console.WriteLine("Estas aprobado :) ");
            else 
                Console.WriteLine("Estas reprobado :( ");
           

            byte calif1 = 0;
            Console.WriteLine("Inserta calificacion: ");
            calif1 = Convert.ToByte(Console.ReadLine());

            if(calif1 >= 90) {
                Console.WriteLine("Felicidades tienes A");
            }
            else 
            { 
             if (calif1 >= 80)
            {
                Console.WriteLine("Tienes B");
            }
            else if (calif1 >= 70){
               Console.WriteLine("Tienes C");

            }
            else if (calif1 >=60){
                Console.WriteLine("Tienes D");
            }
            else if (calif1 >= 50)
            {
                Console.WriteLine("Tienes E");
            }
            else
            {
                Console.WriteLine("Adios carnal");
            }
             }
          
            int x, y;
            Console.WriteLine("Inserta el valor de X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el valor de Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 10)
                if (y > 10)
                    Console.WriteLine("X y Y son mayor que 5");

                else Console.WriteLine("X es menor o igual a 10");
                    **/

            Console.ReadKey();


        }
    }
}
