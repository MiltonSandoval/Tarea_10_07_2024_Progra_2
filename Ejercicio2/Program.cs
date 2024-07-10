using System;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio2
{
    class Programa
    {
        static void Main(string[] args)
        {
            double x, y;
            try
            {
                Console.WriteLine("Programa para encontrar el numero mayor entre dos numeros");
                Console.Write("Ingrese el primer numero:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero:");
                y = double.Parse(Console.ReadLine());

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

//Realice un programa que pida el nombre, la fecha de nacimiento, lo junte todo en una cadena separando //el nombre de la fecha por una coma ',' y la fecha por una barra diagonal '/'.
//Crea un programa que pida al usuario dos numeros enteros y despues una operacion para realizar con ellos
