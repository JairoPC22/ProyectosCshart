using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
import java.util.ArrayList;
import java.util.Scanner;

namespace LIstas
{
    internal class Program
    {
        public static void main(String[] args)
        {
            Scanner teclado = new Scanner(System.in);
            ArrayList<String> nombres = new ArrayList<String>();
            System.out.println("Ingrese nombres para agregar a la lista (o 'fin' para salir):");
            while (true)
            {
                String entrada = teclado.nextLine();
                if (entrada.equals("fin"))
                {
                    break;
                }
                nombres.add(entrada);
            }
            System.out.println("Los nombres en la lista son:");
            for (String nombre : nombres)
            {
                System.out.println(nombre);
            }
        }
    }
