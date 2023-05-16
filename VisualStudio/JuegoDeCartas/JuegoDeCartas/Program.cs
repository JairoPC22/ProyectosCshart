using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuegoDeCartas.carta;

namespace JuegoDeCartas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaqueteDeCartas mipaqueteDeCartas = new PaqueteDeCartas();
            mipaqueteDeCartas.Barajear();

            for (int i= 0; i < 13; i++){
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", mipaqueteDeCartas.RepartirCarta(), mipaqueteDeCartas.RepartirCarta(), mipaqueteDeCartas.RepartirCarta(), mipaqueteDeCartas.RepartirCarta());
            }
        }
    }
    //Clase Carta que representa una carta de juego
    public class carta
    {
        private string cara; //Cara de carta(As, dos, ....)
        private string palo; //Palo de carta(Corazones, Diamantes, ....)
        //El constructor con 2 parametros inicializa la cara y el palo de carta

        public carta(string caraCarta, string Cartapalo) 
        {
            cara= caraCarta;
            palo = Cartapalo;
            //Fin del constructor
        }
        public override string ToString()
        {
            return cara + " de " + palo;
        }
        //Clase PaqueteDeCartas representa un paquete de cartas de juego
        public class PaqueteDeCartas
        {
            private carta[] paquete;
            private int cartaActual;
            private const int NUMERO_DE_CARTAS = 52;
            private Random numerosAleatorios;

            public PaqueteDeCartas()
            {
                string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
                "Siete","Ocho", "Nueve", "Diez", "Joto", "Quina", "Rey"};
                string[] palos = { "Corazones", "Diamantes", "Treboles", "Espadas" };

                paquete = new carta[NUMERO_DE_CARTAS];
                cartaActual = 0;
                numerosAleatorios= new Random();

                for(int cuenta=0; cuenta<paquete.Length; cuenta++)
                {
                    paquete[cuenta] = new carta(caras[cuenta%13], palos[cuenta/13]);
                }
            }
            public void Barajear()
            {
                //Despues de barajear, la reparticion debe empezar otra vez en paquete [0]
                cartaActual = 0;

                for(int primera=0; primera<paquete.Length; primera++)
                {
                    int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);

                    carta temp = paquete[primera];
                    paquete[primera] = paquete[segunda];
                    paquete[segunda] = temp;  
                }
            }
            //Se reparte una carta

            public carta RepartirCarta()
            {
                if (cartaActual < paquete.Length)
                    return paquete[cartaActual++];
                else return null;
                        
                        }

        }
    }
}
