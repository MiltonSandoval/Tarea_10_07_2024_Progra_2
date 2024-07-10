using System;

namespace Ejercicio1
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Se define un arreglo llamado Semana donde se almacenan los dias de la semana 
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
            //Variable dia que almacenara la opcion del usuario
            int Dia;
            try
            {
                Console.WriteLine("Días de la semana:");
                Console.Write("Ingrese un número: ");
                Dia = int.Parse(Console.ReadLine());
                //Se resta 1 a la opcion del usuario para que coincida con la longitud de mi arreglo
                Console.WriteLine(Semana[Dia - 1]);
            }
            //en caso de que el usuario ingrese un numero fuera de rango o un caracter invalido,
            //se mostrara el siguiente mensaje de error
            catch
            {
                
                Console.WriteLine("Error: ingresa valores del 1 al 7");
            }
        }
    }
}
