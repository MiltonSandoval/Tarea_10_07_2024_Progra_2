using System;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio2
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Definicion de las variables x,y como double
            double x, y;
            try
            {
                Console.WriteLine("Programa para encontrar el numero mayor entre dos numeros");
                // se reciben los dos numeros y se los almazena en x, y
                Console.Write("Ingrese el primer numero:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero:");
                y = double.Parse(Console.ReadLine());
                // se hace la comparacion y se imprime el numero mayor
                if (x > y)
                    Console.WriteLine($"El numero mayor es: {x}");
                else
                    Console.WriteLine($"El numero mayor es: {y}");
            }
            catch
            {
                Console.WriteLine("Error, solo se permiten numeros");
            }
        }
    }
}
