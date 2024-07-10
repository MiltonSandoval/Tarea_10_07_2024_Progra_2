using System;

namespace Ejercicio1
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] Semana = new string[7]
            {
                "Lunes",
                "Martes",
                "Miércoles",
                "Jueves",
                "Viernes",
                "Sábado",
                "Domingo"
            };

            int Dia;
            try
            {
                Console.WriteLine("Días de la semana:");
                Console.Write("Ingrese un número: ");
                Dia = int.Parse(Console.ReadLine());
                Console.WriteLine(Semana[Dia - 1]);
            }
            catch
            {
                Console.WriteLine("Error: ingresa valores del 1 al 7");
            }
        }
    }
}
