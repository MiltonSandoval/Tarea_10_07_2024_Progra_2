using System;

namespace Ejercicio3
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Funciones matematicas
            double Valor;
            //Raiz Cuadrada
            Valor = Math.Sqrt(25);
            Console.WriteLine($"La raiz cuadrada de 25:{Valor}");
            //Valor Absoluto
            Valor = Math.Abs(-100);
            Console.WriteLine($"El valor absoluto de -100:{Valor}");
            //Seno
            Valor = Math.Sin(90);
            Console.WriteLine($"Seno de 90:{Valor}");
            //Potencia
            Valor = Math.Pow(3, 3);
            Console.WriteLine($"Potencia de 3 elevado a 3:{Valor}");
            //Tangente
            Valor = Math.Tan(40);
            Console.WriteLine($"La tangente de 40:{Valor}");
            //Funcion de Redondeo
            Valor = Math.Round(3.14159265358979323846,4);
            Console.WriteLine($"Redondea a cierta cantidad de decimales el numero:3.14159265358979323846 :{Valor}");
        }
    }
}