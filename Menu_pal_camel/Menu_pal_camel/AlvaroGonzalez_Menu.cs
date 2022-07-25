using System;

namespace New_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!(Contrasena()))//1234
                Console.WriteLine("Limite de intentos superado, No tienes accseo al sistema");//avhjwb
           
            else
            {
                Console.Write("Contraseña Correcta!! \n");
                string opcionesMenu = "Pulsa 0 para CamelCase, 1 para Palindromo, 2 para dia laboral o no," +
                    " 3 para acceder a la calculadora inversa, 4 para compararador de fechas," +
                    " 5 para comparar alfabeticamente dos palabras";

                Console.WriteLine(opcionesMenu);
                Console.WriteLine("Si quieres salir escribe exit");

                string menu;
                string repeat;
                string palabra;
                menu = Console.ReadLine();
                while (menu != "exit")
                {
                    if (menu == "0")
                    {
                        Console.WriteLine("Introduce la frase para convertir a camel case:");
                        palabra = Console.ReadLine();
                        Console.WriteLine(CamelCase(palabra));

                    }

                    else if (menu == "1")
                    {
                        Console.WriteLine("Introduce la palabra que quieres saber si es palindromo");
                        palabra = Console.ReadLine();
                        if (Palindromo(palabra))
                            Console.WriteLine(palabra + " es un palindromo");
                        else
                            Console.WriteLine(palabra + " no es un palindromo");
                    }

                    else if (menu == "2")
                    {
                        Console.Write("Introduce un día de la semana: ");
                        palabra = Console.ReadLine();
                        if (Semana(palabra) == 2)
                            Console.WriteLine("Es un día no laboral");
                        else if (Semana(palabra) == 1)
                            Console.WriteLine("Es un día laboral");
                        else
                            Console.WriteLine("No has introducido un día válido");
                    }

                    else if (menu == "3")
                    {
                        Console.WriteLine("Bienvenido a la calculadora inversa," +
                            " introduce la operacion aritmetica que deseas (+, -, *, /, %,^ )");
                        string operacion;
                        int x, y;
                        
                        operacion = Console.ReadLine();
                        
                        Console.WriteLine("Introduzca el primer valor de la operacion");
                        x = StringToInt(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo valor de la operacion");
                        y = StringToInt(Console.ReadLine());

                        CalculadoraInversa(operacion, x, y);
                    }

                    else if (menu == "4")
                    {
                        Console.WriteLine("Bienvenido al comparador de fechas \n");
                        int dia_a, dia_b, mes_a, mes_b, ano_a, ano_b;
                        
                        Console.WriteLine("Introduzca la primera fecha");
                        do
                        {
                            Console.WriteLine("Introduzca el día:");
                            dia_a = StringToInt(Console.ReadLine());
                            Console.WriteLine("Introduzca el mes (formatonúmerico):");
                            mes_a = StringToInt(Console.ReadLine());
                            Console.WriteLine("Introduzca el año:");
                            ano_a = StringToInt(Console.ReadLine());
                            if (!VerificadorFechas(dia_a, mes_a, ano_a))
                                Console.WriteLine("Has introducido una fecha que no existe, por favor intentelo de nuevo");

                        } while (!VerificadorFechas(dia_a, mes_a, ano_a));


                        Console.WriteLine("Introduzca la segunda fecha");
                        do
                        {
                            Console.WriteLine("Introduzca el día:");
                            dia_b = StringToInt(Console.ReadLine());
                            Console.WriteLine("Introduzca el mes (formatonúmerico):");
                            mes_b = StringToInt(Console.ReadLine());
                            Console.WriteLine("Introduzca el año:");
                            ano_b = StringToInt(Console.ReadLine());
                            if (!VerificadorFechas(dia_b, mes_b, ano_b))
                                Console.WriteLine("Has introducido una fecha que no existe, por favor intentelo de nuevo");
                        } while (!VerificadorFechas(dia_b, mes_b, ano_b));

   
                        Console.WriteLine(ComparaFechas(dia_a, dia_b, mes_a, mes_b, ano_a, ano_b));

                    }

                    else if( menu == "5")
                    {
                        Console.WriteLine("Hola, introduce la primera palabra que quieres comparar");
                        string palabra_a = Console.ReadLine();

                        Console.WriteLine("Introduce la segunda palabra");
                        string palabra_b = Console.ReadLine();

                        if (OrdenAlfabetico(palabra_a, palabra_b)==true)
                            Console.WriteLine(palabra_a + " es alfabeticamente anterior a " + palabra_b);

                        else if (OrdenAlfabetico(palabra_a, palabra_b)==false)
                            Console.WriteLine(palabra_b + " es alfabeticamente anterior a " + palabra_a);

                        else
                            Console.WriteLine(palabra_a + " es la misma palabra que  " + palabra_b);




                    }
                    else
                        Console.WriteLine("Opción no valida");

                    Console.WriteLine("Si Quiere realizar otra operación Pulse 1, sino pulse cualquier otra tecla");
                    repeat = Console.ReadLine();
                    if (repeat == "1")
                    {
                        Console.WriteLine(opcionesMenu);
                        menu = Console.ReadLine();
                    }

                    else
                        menu = "exit";
                }
                Console.WriteLine("Gracias por usar el programa!");

            }
        }

        public static string CamelCase(string frase)
        {
            string fraseCamelCase;
            int N, p, k = 1;
            p = 0;


            N = frase.Length;

            //Primera letra mayuscula
            char letra = char.ToUpper(frase[0]);
            fraseCamelCase = char.ToString(letra);
            for (int i = 1; i < N; i++)
            {
                if (frase[i] == ' ')
                    p = 1;
                else
                {
                    if (p == 1)
                        fraseCamelCase = fraseCamelCase + char.ToString(char.ToUpper(frase[i]));

                    else
                        fraseCamelCase = fraseCamelCase + char.ToString(frase[i]);
                    k++;
                    p = 0;
                }
            }

            return fraseCamelCase;
        }

        public static bool Palindromo(string palabra)
        {
            palabra.ToLower();
            int M, L;
            L = palabra.Length;
            if (L % 2 == 0)
                M = (L / 2) + 1;
            else
                M = (L + 1) / 2;
            for (int i = 0; i < M; i++)
            {
                if (palabra[i] != palabra[L - 1])
                    return false;
                L = L - 1;
            }
            return true;
        }

        public static int Semana(string dia)
        {
           dia.ToLower();
           switch(dia)
            {
                case "lunes":
                    return 1;

                case "martes":
                    return 1;

                case "miercoles":
                    return 1;

                case "jueves":
                    return 1;

                case "viernes":
                    return 1;

                case "sabado":
                    return 2;

                case "domingo":
                    return 2;

                default:
                    return 3;
            }
        }

        public static bool Contrasena()
        {
            int x = 0;
            string contrasena = "1234";
            string intento;
            while (x<3)
            {
                Console.WriteLine("Por favor introduce la contraseña para entrar a las funciones del programa: ");
                intento = Console.ReadLine();
                if (intento == contrasena)
                    return true;
                x++;
                Console.WriteLine("Error!");
            }
            return false;
        }

        public static void CalculadoraInversa(string operacion, int x, int y)
        {
            bool invalido = false;
            double resultado;
            switch(operacion)
            {
                case "+":
                    resultado = x + y;
                    break;

                case "-":
                    resultado = x - y;
                    break;

                case "*":
                    resultado = x * y;
                    break;

                case "/":
                    resultado = x / y;
                    break;

                case "%":
                    resultado =  x % y;
                    break;

                case "^":
                    resultado = x;
                    for(int i=2; i<=y; i++) //x^1 ya esta incluido en la linea anterior
                    {
                        resultado = resultado * x;
                    }
                    break;

                default:
                    invalido = true;
                    resultado = 0;
                    break;

            }

            if (invalido)
                Console.WriteLine("El operador aritmetico que has elegido no es valido");
            else
                Console.WriteLine("El resultado de " + x.ToString() + " " + operacion + " " + y.ToString() + " es: " + resultado.ToString());
        }

        public static string ComparaFechas(int dia_a, int dia_b, int mes_a, int mes_b, int ano_a, int ano_b)
        {
            double fecha_a, fecha_b;
            fecha_a = ano_a + mes_a * 0.01 + dia_a * 0.0001;
            fecha_b = ano_b + mes_b * 0.01 + dia_b * 0.0001;

            if (fecha_a < fecha_b)
                return "La primera fecha es anterior a la segunda";

            else if (fecha_b < fecha_a)
                return "La segunda fecha es anterior a la primera";

            else
                return "Has introucido la misma fecha";
        }

        public static double StringToDouble(string numero)
        {
            bool success;
            double num;
            do
            {
                success = double.TryParse(numero, out num);

                if (!success)
                {
                    Console.WriteLine("Por favor introduzca un valor númerico");
                    numero = Console.ReadLine();
                }
                    
            } while (!success);
            return num;
        }

        public static int StringToInt(string numero)
        {
            bool success;
            int num;
            do
            {
                success = int.TryParse(numero, out num);

                if (!success)
                {
                    Console.WriteLine("Por favor introduzca un valor númerico");
                    numero = Console.ReadLine();
                }

            } while (!success);
            return num;
        }

        public static bool VerificadorFechas(int dia, int mes, int ano)
        {
            
            if (mes > 12)//no hay mas de doce meses
                return false;
            /*
            else if (((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12)) && (dia > 31))
                return false;

            else if (((mes == 4) || (mes == 6) || (mes == 11) || (mes == 9)) && (dia > 30))
                return false;

            else if (mes == 2)
                if (((ano % 4) != 0) && (dia > 28))
                    return false;
                else if(((ano % 4) == 0) && (dia > 29))
                    return false;

            
            */

            switch(mes)
            {
                case 1:
                    if (dia > 31)
                        return false;
                    break;

                case 2://febrero bisiesto
                    if(((ano % 4) != 0) && (dia > 28))
                        return false;

                    else if (((ano % 4) == 0) && (dia > 29))
                        return false;
                    break;

                case 3:
                    if (dia > 31)
                        return false;
                    break;

                case 4:
                    if (dia > 30)
                        return false;
                    break;

                case 5:
                    if (dia > 31)
                        return false;
                    break;

                case 6:
                    if (dia > 30)
                        return false;
                    break;

                case 7:
                    if (dia > 31)
                        return false;
                    break;

                case 8:
                    if (dia > 31)
                        return false;
                    break;

                case 9:
                    if (dia > 31)
                        return false;
                    break;

                case 10:
                    if (dia > 31)
                        return false;
                    break;

                case 11:
                    if (dia > 30)
                        return false;
                    break;

                case 12:
                    if (dia > 31)
                        return false;
                    break;
            }

            return true;



        }

        public static bool? OrdenAlfabetico(string A, string B)
        {
            //En caso de ser iguales se considera la corta la primera alfabeticamente
            //true -> A antes que B
            //false -> B antes que A
            A.ToLower();
            B.ToLower();
            int LA = A.Length;
            int LB = B.Length;
            int L;

            if (LA >= LB)
                L = LB;
            else
                L = LA;

            for(int i=0; i<L; i++)
            {
                if (A[i] < B[i])
                    return true;
                else if (A[i] > B[i])
                    return false;
            }
            if (LA == LB)
                return null;

            else if (LA > LB)
                return false;

            else
                return true;
        }


    }
}
