using System;

namespace AlvaroGonzalezJuegoCartas
{
    class Carta
    {
        //miembros
        private int numero;
        public int Numero
        {
            get { return numero; }
            set
            {
                if (value >= 0 && value <= 12)
                    numero = value;
            }
        }


        private int palo;
        public int Palo
        {
            get { return palo; }
            set
            {
                if (value > 0 && value <= 4)
                    palo = value;
            }
        }


        static string[] palos = { "oros", "copas", "espadas", "bastos" };//static es igual para todas las instancias
        //public enum ePalo { oros=1, copas=2, espadas=3, bastos=4};

        //constructor
        public Carta(int n, int p)
        {
            numero = n;
            palo = p;
        }
        //constructor por defecto
        public Carta()// por defecto
        {
            numero = 0;
            palo = 0;
        }
        //Override
        public override string ToString()
        {
            return numero + " de " + palos[palo - 1];
        }
        //devuelve el valor de la carta
        public int ValorCarta()//Devuelve el valor de la carta
        {
            return numero;

        }
        //devuelve el palo de la carta en modo striing 
        public string PaloCarta()//Devuelve el palo de  la carta en string
        {
            return palos[palo - 1];

        }
        //Creamos una carta con interfaz
        public static Carta CrearCarta()
        {
            int pp = 5;
            string p;
            Console.WriteLine("Intoduce el valor de la carta que quieres crear");
            int n = int.Parse((Console.ReadLine()));
            while (n > 12)
            {
                Console.WriteLine("Introduzca un numero valido");
                n = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Introduzca el palo de la carta oros, copas, espadas o bastos");

            while (pp == 5)
            {
                p = (Console.ReadLine());

                if (p == "oros")
                    pp = 1;
                else if (p == "copas")
                    pp = 2;
                else if (p == "espadas")
                    pp = 3;
                else if (p == "bastos")
                    pp = 4;
                else
                {
                    pp = 5;
                    Console.WriteLine("Introduzca un palo adecuado");
                }

            }


            Console.WriteLine(pp);

            Carta car = new Carta(n, pp);

            return car;

        }
    }

    
}

