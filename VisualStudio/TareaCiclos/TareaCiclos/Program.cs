using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, tabla = 1;
            float num1, num2;
            string name;
            Console.WriteLine("-Mr.Robot: Hola...");
            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("-Mr.Robot: ¿Como te llamas?");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("-Mr.Robot: Ok " + name + " dime, ¿en que puedo ayudarte?");
            Console.WriteLine("Selecciona una opcion: ");
            Console.WriteLine(" ");
            Console.WriteLine("1. Calcular una tabla de multiplicar");
            Console.WriteLine("2. Conocer si un numero es positivo o negativo");
            Console.WriteLine("3. Saber cuantos digitos hay en una cantidad ");
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("-Mr.Robot: Ingresa tabla a calcular");
                        tabla = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine("" + tabla * i);
                        }
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    {
                        int numero;

                        Console.WriteLine("Teclea un número (0 para salir): ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        while (numero != 0)
                        {
                            if (numero > 0) Console.WriteLine("Es positivo");
                            else Console.WriteLine("Es negativo");

                            Console.WriteLine("Teclea otro número (0 para salir): ");
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                    
            }
                        break;

                case 3:
                    {
                        int valor;
                        string linea;
                        do
                        {
                            Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza):");
                            linea = Console.ReadLine();
                            valor = int.Parse(linea);
                            if (valor >= 100)
                            {
                                Console.WriteLine("Tiene 3 dígitos.");
                            }
                            else
                            {
                                if (valor >= 10)
                                {
                                    Console.WriteLine("Tiene 2 dígitos.");
                                }
                                else
                                {
                                    Console.WriteLine("Tiene 1 dígito.");
                                }
                            }
                        } while (valor != 0);
                
            }
                    break;
            }
            
        }

    }
}
