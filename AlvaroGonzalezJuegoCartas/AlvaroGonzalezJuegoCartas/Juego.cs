using System;
using System.Collections.Generic;



namespace AlvaroGonzalezJuegoCartas
{
    class Juego
    {
        //habrá un maximo de 10 jugadres
        //mano de cada jugador 
        private List<Carta> central = new List<Carta>();
        public List<Carta> Central
        {
            get { return central; }
            set { central = value; }
        }

        //numero de jugadores
        private int numeroJugadores;
        public int NumeroJugadores
        {
            get { return numeroJugadores; }
            set { numeroJugadores = value; }
        }

        //jugadores del juego
        private List<Jugador> jugadorJuego = new List<Jugador>();
        public List<Jugador> JugadorJuego
        {
            get { return jugadorJuego; }
            set { jugadorJuego = value; }
        }

        //constructor
 
        public Juego(int n)
        {
            numeroJugadores = n;
            string nombre;
            Jugador j1;
            
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Introduzca el nombre del jugador " + (i+1) + ": ");
                nombre = Console.ReadLine();
                j1 = new  Jugador(nombre);
                jugadorJuego.Add(j1);
            }
        }

        //Devuelve el jugador que gana la ronda
        public int Comparar()
        {
            int max = 0;
            for(int i=1; i<central.Count; i++)
            {
                if (central[max].Numero < central[i].Numero)//chequea si el siguiente valor es mayor
                    max = i;
                else if (central[max].Numero == central[i].Numero)//si es igual 
                {

                    /*
                    if (central[max].Palo < central[i].Palo)
                        max++;
                    */
                }
            }
            return max; //Devuelve el indice del jugador que gana
        }

        //Repartir las cartas para iniciar el juego
        public void RepartirCartas()
        {
            Baraja baraja = new Baraja();
            //barajamos las cartas de la baraja
            baraja.Barajar();
            
            Carta card; 
            for (int i = 0; i < 48 - (48 % numeroJugadores); i = i + numeroJugadores)
            {
                
                
                /*jugadorJuego[0].Anadir(card);
                //si hay dos jugadores
                if (numeroJugadores > 1)
                {
                    card = baraja.RobaCarta();
                    jugadorJuego[1].Anadir(card);
                }
                    
                //si hay tres jugadores
                if(numeroJugadores > 2)
                {
                    card = baraja.RobaCarta();
                    jugadorJuego[2].Anadir(card);
                }
                //si hay cuatro jugadores
                if (numeroJugadores > 3)
                {
                    card = baraja.RobaCarta();
                    jugadorJuego[3].Anadir(card);
                }
                
                //si hay cinco jugadores
                if(numeroJugadores > 4)
                {
                    card = baraja.RobaCarta();
                    jugadorJuego[4].Anadir(card);
                }
                */
                for(int j=0; j<numeroJugadores; j++)
                {
                    card = baraja.RobaCarta();
                    jugadorJuego[j].Anadir(card);
                }
                
                
                
               
            }
            Console.WriteLine("Sobran las sigueintes cartas:"+ baraja.Mazo.Count);
            //Console.WriteLine(baraja);
        }

        //funcion que hace funcionar el juego 
        public void IniciarJuegoBatalla()
        {
            
            int indiceGanador;

            //Se reparten las cartas
            RepartirCartas();



            //Se sacan las cartas
            int jugadoresSinCarta = 0;

            //Bucle while que acaba cuando uno se queda sin cartas

            int contt = 0;
            //while (contt < 11)
            while (jugadoresSinCarta < NumeroJugadores)
            {
                Console.WriteLine("\n------------------------------------------------------------------------");
                Console.WriteLine("Comienza una nueva ronda \n");
                for (int i = 0; i < numeroJugadores; i++)
                {
                    jugadoresSinCarta = 0;
                    if (JugadorJuego[i].Mano.Count != 0)
                    {
                        Console.WriteLine(JugadorJuego[i].Nombre + " saco un:");
                        Central.Add(JugadorJuego[i].SacarCartaMano());
                        Console.WriteLine("\n");
                    }
                    if (JugadorJuego[i].Mano.Count == 0)
                        jugadoresSinCarta++;


                }


                //comparamos las cartas
                indiceGanador = Comparar();

                //entregamos las cartas del medio al ganador
                JugadorJuego[indiceGanador].Anadirs(Central);
                Console.WriteLine("El ganador de la ronda ha sido el jugador " + JugadorJuego[indiceGanador].Nombre + ":");

                Console.WriteLine("Recuento de cartas");
                for (int i = 0; i < numeroJugadores; i++)
                {
                    Console.Write(JugadorJuego[i].Nombre + " tiene " + JugadorJuego[i].Mano.Count + " cartas ||");
                }


                //eliminamos las cartas del centro
                Central.Clear();



                contt++;
            }
        }


    }
}