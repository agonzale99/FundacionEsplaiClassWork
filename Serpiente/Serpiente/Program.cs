using System;
using System.Diagnostics;

namespace Serpiente
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Crear el tablero

            ConsoleKey mov ;

            //definicion de las distintas matrices usadas
            const int N = 21; //Tamño del tablero
            const int energy = 6; //Número de enrgias

            int longitud = 3;

            int[,] tablero = new int[N, N]; //Creamos el tablero

            string[,] repTablero = new string[N, N]; //creamos interfaz

            int[,] histTablero = new int[N, N]; //historial

            int[,] tableroEnergia = new int[N, N]; //energias

            tableroEnergia = GeneradorEnergias(tableroEnergia, N, energy);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    repTablero[i, j] = "0";
                    if (tableroEnergia[i, j] == 1)
                        repTablero[i, j] = "w";


                }
            }


            //definimos el valor central
            tablero[((N - 1) / 2), ((N - 1) / 2)] = 1; 
            repTablero[((N - 1) / 2), ((N - 1) / 2)] = "x";
            histTablero[((N - 1) / 2), ((N - 1) / 2)] = 1;



            
            //Ejecutamos el bucle de los movimientos
            do
            {
                MostrarTablero(repTablero, N);

                /*
                Stopwatch s = new Stopwatch();
                s.Start();
                while (s.Elapsed < TimeSpan.FromSeconds(1))
                {
                    //
                    
                }

                s.Stop();
                
                Stopwatch s = new Stopwatch();
                // detecta si el boton esta pulsado pero solo funciona en en .NET framework que no puedo usar si tengo mac
                if (!(Keyboard.IsKeyDown()))
                
                    //meter funcion para que aguante un tiempo quieto
              
                else
                            mov = Console.ReadKey().Key; //Guarda la tecla que pulsamos
                */


                mov = Console.ReadKey().Key; //Guarda la tecla que pulsamos


                



                if (MovimientoPermitido(repTablero, tablero, N, mov)) //verifica que el movimiento este permitido
                    tablero = ModificarTablero(tablero, N, mov, repTablero, histTablero, tableroEnergia,longitud);

                
                else
                {
                    Console.WriteLine("\nPerdiste");
                    Environment.Exit(0);

                }

            } while (mov != ConsoleKey.Escape ); //Si pulsamos escape se acaba

            



        }
        

       

        public static int[,] ModificarTablero(int[,] tablero, int N, ConsoleKey mov, string[,] repTablero, int[,] histTablero, int[,] tableroEnergia, int value)
        {
            int x = 0;
            int y = 0;
            
            //busco la posicion actual
          
            for(int i = 0 ; i<N ; i++)
            {
                for (int j = 0; j< N; j++)
                {
                    if (tablero[i, j] == 1)
                    {
                        x = i;
                        y = j;
                    }
               
                    

                    if (repTablero[i, j] == "0")
                        histTablero[i, j] = 0;

                    if (repTablero[i, j] == "y")
                        repTablero[i, j] = "x";

                    else
                        histTablero[i, j]++;

                    

                    if(histTablero[i,j] == value)
                    {
                        repTablero[i, j] = "0";
                    }

                    if (tableroEnergia[i, j] == 1)
                        repTablero[i, j] = "w";
         
                        
                }
            }
            if (tablero[x, y] == 1 && tableroEnergia[x, y] == 1)
                value++;
           
            tablero[x, y] = 0;
            if (mov == ConsoleKey.UpArrow)
                y--;

            else if (mov == ConsoleKey.DownArrow)
                y++;

            else if (mov == ConsoleKey.RightArrow)
                x++;

            else if (mov == ConsoleKey.LeftArrow)
                x--;

            if (tablero[x, y] == 1 && tableroEnergia[x, y] == 1)
                value++;

            tablero[x, y] = 1; //marcamos la posicion donde estará la serpiente
            histTablero[x, y] = 1;
            repTablero[x, y] = "y"; //marcamos la interfaz
            tableroEnergia[x, y] = 0;
            return tablero;
         }

        public static void MostrarTablero(string[,] repTablero, int N)
        {

            Console.Clear();
            
            for (int j = 0; j < N; j++)
            {
                Console.Write("\n");
                for (int i = 0; i < N; i++)
                {
                    //DIferent colors of the snake
                    if (repTablero[i,j] == "y")
                        Console.ForegroundColor = ConsoleColor.Red; //Head red
                    else if (repTablero[i,j] == "x")
                        Console.ForegroundColor = ConsoleColor.Green; //Body green
                    else
                        Console.ForegroundColor = ConsoleColor.Black;

                    Console.Write(repTablero[i, j]);
                    
                }
            }
        }

        public static bool MovimientoPermitido(string[,] repTablero, int[,] tablero, int N, ConsoleKey mov)
        {
            //primero bordes
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (tablero[i, j] == 1)
                    {
                        if (mov == ConsoleKey.UpArrow && j == 0)
                            return false;

                        else if (mov == ConsoleKey.DownArrow && j == N - 1)
                            return false;

                        else if (mov == ConsoleKey.RightArrow && i == N - 1)
                            return false;

                        else if (mov == ConsoleKey.LeftArrow && i == 0)
                            return false;
                    }
                }
            }
            //no puede chocarse
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (tablero[i, j] == 1)
                    {
                        if (mov == ConsoleKey.UpArrow && repTablero[i,j-1] == "x")
                            return false;

                        else if (mov == ConsoleKey.DownArrow && repTablero[i, j + 1] == "x")
                            return false;

                        else if (mov == ConsoleKey.RightArrow && repTablero[i+1, j] == "x")
                            return false;

                        else if (mov == ConsoleKey.LeftArrow && repTablero[i-1, j] == "x")
                            return false;
                    }
                }
            }


            return true;
        }

        public static int[,] GeneradorEnergias(int[,] tableroEnergia, int N, int n)
        {
            Random r = new Random();
            int x, y;



            for (int p = 1; p < n; p++)
            {
                x = r.Next(0, N);
                y = r.Next(0, N);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (x == i && y == j)
                            tableroEnergia[i, j] = 1;
                    }
                }

            }
            return tableroEnergia;
        }
    }
}





