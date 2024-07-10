
using System;

namespace Tarea1
{
    class Programa
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = -1;
            int c = 5;
            bool resultado;
            Console.WriteLine("Ejercicios \n ");
            Console.WriteLine("Ejercicio1");
            resultado = (a > b) && (a < c);
            Console.WriteLine($"El resultado es: {resultado} \n");

            Console.WriteLine("Ejercicio2");
            resultado = ((a + b + c) >= 0) || (b < 0);
            Console.WriteLine($"El resultado es: {resultado} \n");

            Console.WriteLine("Ejercicio3");
            resultado = (c % a) == 0;
            Console.WriteLine($"El resultado es: {resultado} \n");

            Console.WriteLine("Ejercicio4");
            resultado = (b != 1) && ((a * b) == 10);
            Console.WriteLine($"El resultado es: {resultado} \n");

            Console.WriteLine("Ejercicio5");
            resultado = !(b < 0);
            Console.WriteLine($"El resultado es: {resultado} \n");

            Console.WriteLine("Ejercicio6");
            resultado = (a % 2) != 0 && ((b > a) || ((c + 1) / 2 == 3));
            Console.WriteLine($"El resultado es: {resultado} \n");
        }
    }

}
