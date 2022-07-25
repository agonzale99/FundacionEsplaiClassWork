using System;
using System.Collections.Generic;

namespace AlvaroGonzalezJuegoCartas
{
    class Jugador
    {
        private List<Carta> mano = new List<Carta>();
        public List<Carta> Mano
        {
            get { return mano; }
            set { mano = value; }
        }

        private int puntuacion;
        public int Puntuacion
        {
            get { return puntuacion; }
            set { puntuacion = value; }

        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        //constructor

        public Jugador(string nom)
        {
            nombre = nom;
        }

        //suma un punto al jugador
        public void Ganador()
        {
            puntuacion++;
        }

        //devuelve la primera carta de la mano del jugador x
        public Carta SacarCartaMano()
        {
            Carta card;

            //guardamos la carta que vamos a sacar
            card = mano[0];
            Console.WriteLine(card);
            //Eliminamos la carta robada de la baraja
            mano.Remove(mano[0]);

            //Devolvemos la carta
            return card;
        }

        //Añadir carta(s) a la mano
        public void Anadirs(List<Carta> cartas)
        {
            for (int i = 0; i< cartas.Count; i++)
            {
                mano.Add(cartas[i]);
            }
            
        }

        //Añadir una unica carta
        public void Anadir(Carta card)
        {
            mano.Add(card);

        }


    }
}