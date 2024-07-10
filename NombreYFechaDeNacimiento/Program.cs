using System;

namespace Tarea1
{
    class Programa
    {
        static void Main(string[] args)
        {
            string Nombre, Dia, Mes, Año;
            Console.WriteLine("BIENVENIDO");
            Console.Write("Su nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento:");
            Console.Write("Dia:");
            Dia = Console.ReadLine();
            
            Console.Write("Mes:");
            Mes = Console.ReadLine();

            Console.Write("Año:");
            Año = Console.ReadLine();

            Console.WriteLine($"{Nombre}, {Dia}/{Mes}/{Año} \n");
        }
    }
}