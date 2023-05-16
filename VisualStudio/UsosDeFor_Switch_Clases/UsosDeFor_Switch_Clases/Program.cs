using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeFor_Switch_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Cálculos del interes compuesto con For
            decimal monto;
            decimal capital = 1000;
            double tasa = 0.05;
            Console.WriteLine("{0} {1,20}", "Año", "Monto depositado");
            //Calcula el monto depositado para cada uno de los 10 años 
            for(int anio =1; anio <=10; anio++)
            {
                //Calcula el nuevo monto para el año especificado 
                monto = capital * ((decimal)Math.Pow(1.0+tasa,anio));

                //Muestre el año y el monto 
                Console.WriteLine("Para el año: {0,4}, el monto es: {1,20:C}",anio,monto);
            

            }*/
            /*
            Console.WriteLine("Escoge la operación a realizar");
            Console.WriteLine("1: Suma\n2: Resta\n3: Multiplicación\n4: División");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Escogiste la operación de Suma");
                    break;

                case 2:
                    Console.WriteLine("Escogiste la operación de Resta");
                    break ;
                case 3:
                    Console.WriteLine("Escogiste la operación de Multiplicación");
                    break ;
                case 4:
                    Console.WriteLine("Escogiste la operación de División");
                    break ;
                default:
                    Console.WriteLine("Esa opción es inválida");
                    break ;
            }*/

            //Crea el objeto LibroCalificaciones, recibe como entrada calificaciones
            //y muestra un reporte
            //Craear el objeto miLibroCalificaciones de tipo LibroCalificaciones y 
            //pasa el nombre del curso al constructor

            LibroCaificaciones miLibroCalificaciones = new LibroCaificaciones("Ingeniería de Software");
            miLibroCalificaciones.MostrarMensaje(); // Se muestra mensja de bienvenida
            miLibroCalificaciones.IntroduccirCalif(); //Lee calificaciones e usuario
            miLibroCalificaciones.MostrarReporteCalif(); //Muestra un reporte basado en las calificaciones

            Console.ReadKey();
        }
    }
    public class LibroCaificaciones
    {
        private string nombreCurso; //Nombre del curso que representa este libro calificaciones
        private int total; //Suma de calificaciones 
        private int contadorCalif; //Numero de calificaciones introducidas
        private int contA; //Cuenta de calificaciones A
        private int contB; //Cuenta de calificaciones B
        private int contC; //Cuenta de calificaciones C
        private int contD; //Cuenta de calificaciones D
        private int contF; //Cuenta de calificaciones F

        //El constructor inicializa nombreCurso
        //Las variables de instancia int se inicializa en 0 de manera predetermindada 
        public LibroCaificaciones(string nombre)
        {
            nombreCurso = nombre; // Inicializa nombreCurso 
        } // Fin del constructor 

        //Propiedad que obtiene (get) y establece (set) el nombre del curso
        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }//Fin de la propiedad NombreCurso

        //Muestra un mensaje de bienvenida al usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            //Nombre obtiene el nombre del curso
            Console.WriteLine("Bienvenido al Libro de Calificaciones para \n{0}\n", NombreCurso);
        }//Fin del metodo MostrarMensaje

        //Recibe como entrada un número arbitrario de calificaciones del usuario 
        public void IntroduccirCalif()
        {
            int calificacion; //Calificacion introducida por el usuario
            string entrada; //Texto introducido por el usuario
            Console.WriteLine("{0}\n{1}", "Escriba las calificaciones enteras" +
                " en el rango de 0 a 100", "Escriba <Ctrl> z y oprima Intro para terminar captura");
            entrada = Console.ReadLine(); //Lee la entrada del usuario 

            //Itera hasta que el usuario escriba el indicador de fin de archivos <Crtl> z
            while (entrada != null)
            {
                calificacion = Convert.ToInt32(entrada); //Lee la calif del usuario
                total += calificacion; //Suma la calificacion total
                contadorCalif++; //Incrementa el número de calificaciones

                //Llama al metodo para incrementar el contador apropiado
                IncrementarConstadorLetraCalif(calificacion);
                entrada = Console.ReadLine(); //Lee la entrada del usuario
            }//Fin del while 
        }//Fin del metodo IntroducirCalifi

        //Suma 1 al contador apropiado para la calificacion especificada
        private void IncrementarConstadorLetraCalif(int calificacion)
        {
            //Determina cual calificacion se introdujo 
            switch (calificacion / 10)
            {
                case 9:// La calificacion estaba en los 90s
                case 10://La calificacion fue 100
                    contA++;//Incrementa contA
                    break;
                case 8://La calificacion esta entre 80 y 89
                    contB++;//Incrementa contB
                    break;//Sale del switch
                case 7://La calificacion esta entre 70 y 79
                    contC++;//Incrementa contC
                    break;//Sale del switch
                case 6://La calificacion esta entre 60 y 69
                    contD++;//Incrementa contD
                    break;//Sale del switch
                default://La calificacion fue menor de 60
                    contF++;//Incrementa contF
                    break;//Sale del switch
            }//Fin del switch
        }//Fin del metodo IcementarContadorLetraCalif

        //Muestra un reporte con base en las calificaciones introducidas por el usuario
        public void MostrarReporteCalif()
        {
            Console.WriteLine("\nReporte de Calificaciones: ");

            //Si el usuario introdujo cuando menos una calificacion (!= se lee diferente)
            if (contadorCalif != 0)
            {
                //Calcula el promedio de todas las calificaciones introducidas
                double promedio = (double)total / contadorCalif;

                //Imprime resumen de resultados
                Console.WriteLine("Las calificaciones introducidas es {1}", contadorCalif, total);
                Console.WriteLine("El promedio de la clase es: {0:F2}", promedio);
                Console.WriteLine("{0}A:  {1}\nB: {2}\nC: {3}\nD: {4}\nF: {5}",
                    "Número de estudiantes que recibieron cada calificacion:\n", contA,
                    contB, contC, contD, contF);
            }
            else
                Console.WriteLine("No se introdujeron datos");
        }//Fin del metodo MostrarReporteCalif

    }//Fin de la clase LibroCalificaciones
}