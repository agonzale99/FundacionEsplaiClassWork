using System;
using System.Collections.Generic;

namespace AlvaroGonzalezJuegoCartas
{
    class Baraja
    {
        //Baraja
        private List<Carta> mazo = new List<Carta>();
        public List<Carta> Mazo
        {
            get { return mazo; }
            set { mazo = value; }
        }

        //Coinstructor
        public Baraja()
        {
            for(int i=1; i<5; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    /*
                    card = new Carta(j, i);
                    baraja[n] = card;
                    n++;
                    */
                    mazo.Add(new Carta(j, i));
                }
            }
        }

        //override de la baraja
        public override string ToString()
        {
            string cartasBaraja = "Las cartas de la baraja son: ";
            for (int i = 0; i < 48; i++)
            {
                cartasBaraja += mazo[i] + ", ";

            }
            return cartasBaraja;
        }

        //Metodos

        //devuelve el valor de la carta posicion n
        public int ValorCartaBaraja(int n)
        {
            return mazo[n-1].ValorCarta();
        }
        //devuelve el palo de la cartta de posicion n
        public string PaloCartaBaraja(int n)
        {
            return mazo[n-1].PaloCarta();
        }
        //override de la carta de posicion n
        public string BarajaToString(int n)
        {
            return mazo[n - 1].ToString();
        }
        //Decvuelve el numero de cartas en la baraja
        public int NumeroCartas()
        {
            return mazo.Count;
        }
        //Robar carta -> La primera de la baraja
        public Carta RobaCarta()
        {
            Carta card;
            card = mazo[0];
            //Console.WriteLine("Robamos una carta");
            //Mostramos la carta robada
            //Console.WriteLine(mazo[0]);//
            //Eliminamos la carta robada de la baraja
            mazo.Remove(mazo[0]);
            return card;
        }
        //Coge la carta seleccionada
        public Carta CogerCarta(int n)
        {
            Carta card;
            card = mazo[n];
            Console.WriteLine("Coges la carta de la posicion " + n + " :");
            //Mostramos la carta robada
            Console.WriteLine(mazo[n]);//
            //Eliminamos la carta robada de la baraja
            mazo.Remove(mazo[n]);
            return card;
        }
        //Coger carta al azar
        public void CartaAlAzar()
        {
            //generamos una posicion aleatoria entre las disponibles
            Random r = new Random();
            int n = r.Next(0, mazo.Count);

            Console.WriteLine("Coges la carta al azar de la posicion " + n + " :");
            //Mostramos la carta robada
            Console.WriteLine(mazo[n]);//
            //Eliminamos la carta robada de la baraja
            mazo.Remove(mazo[n]);
        }
        //Me todo para barajar y desordenar la baraja
        public void Barajar()
        {
            //generamos numero aleatorio
            Random r = new Random();
            int pos;
            for (int i=0; i < 48; i++)
            {
                pos = r.Next(0, 48);
                //insertamos la primera carta en la posicion aleatoria
                mazo.Insert(pos, mazo[0]);
                //eliminamos el duplicado
                mazo.Remove(mazo[0]);
            }
        }
    }
}
