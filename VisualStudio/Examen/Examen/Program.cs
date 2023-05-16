using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variable numero1 de tipo entero
            int numero1;

            //Pedir en consola un numero entero positivo
            Console.WriteLine("Hola, ¿podrias ingresar un número entero positivo:? por favor");
            Console.WriteLine("Recuerda no introducir letras o decimales, este programa esta hecho para NUMEROS ENTEROS");

            //Lee la entrada que el usuario escribio y la connvierte a un numero entero para despues almacenarlo en la variable numero1
            numero1 = Convert.ToInt32(Console.ReadLine());


            // Se crea una estructura de control de bucle while, que se ejecuta mientras numero1 sea diferente de 1.
            while (numero1 != 1)
            {

                //Imprime en la consola el valor de numero1 seguido de una coma y un espacio. Esto para poder visulizar mejor el resultado
                Console.Write(numero1 + ", ");


                //Se inicia la condicion if, que verifica si el número es par o impar.
                //Si numero1 es par, se divide entre 2 y se guarda el resultado en numero1.
                if (numero1 % 2 == 0)
                {

                    //Se hace la division entre 2
                    numero1 = numero1 / 2;
                }

                //Si numero1 es impar, se multiplica por 3 y se le agrega un 1
                else
                {
                    //Se hace las operaciones y se guarda el resultado en numero1.
                    numero1 = numero1 * 3 + 1;
                }
                //Fin Condicional
            }
            //Fin bucle While


            //Se imprime en pantalla el valor final de numero1
            Console.WriteLine(numero1);


            //Se imprime en consola un mensaje de despedida
            Console.WriteLine("\nFin del programa");

            //Se escribe Console.ReadLine para que el programa no se finalice antes de poder ver la sucesion
            Console.ReadLine();
        }
        //Fin del metodo Main
    }
    //Fin clase Program
}