using System;
using System.Collections.Generic;

namespace AlvaroGonzalezJuegoCartas
{
    

    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Introduzca el número de jugadores"   );

            n = Int32.Parse(Console.ReadLine());

            Juego partida = new Juego(n);

            partida.IniciarJuegoBatalla();
            
        }

        
    }
}
