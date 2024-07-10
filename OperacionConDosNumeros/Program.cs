using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Tarea2
{
    class Programa
    {
        static void Main(string[] args) //Funcion Principal
        {
            //Defino las variables a usar
            double Numero1, Numero2;
            string Opcion;
            string Controlador;
            //Bucle While para controlar la repeticion del programa
            while(true)
            {
                Console.Clear(); //Funcion de c# para limpiar la pantalla
                Console.WriteLine("Bienvenido al programa de operaciones de 2 numeros");
                //Se piden los dos numeros para hacer las operaciones
                Console.Write("Ingrese el primer numero:");
                Numero1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero:");
                Numero2 = double.Parse(Console.ReadLine());

                //Se llama a la funcion Menu() para que imprima el menu y retorne la opcion del usuario
                Opcion = Menu();
                //Se le manda la opcion y los dos numeros que dio el usuario a la funcion operaciones
                //Para que retorne y se imprima por consola el resultado
                Console.WriteLine(Operaciones(Opcion, Numero1,Numero2));
                //Se pregunta al usuario si desea hacer otra operacion o si desea salir del programa
                Console.WriteLine(
                    "\n ¿Desea hacer otra operacion? \n"+
                    "1. Otra operacion\n "+ 
                    "2. Salir \n");
                //se guarda la opcion del usuario en la variable Controlador y se verifica si es un 2,
                //en caso de ser un 2, se lanza un break para detener el bucle while, si no este sigue ejecutandose
                Controlador = Console.ReadLine();
                if (Controlador == "2")
                {
                    break;
                }
            }
        }
        //Funcion del Menu que imprime todas las operaciones disponible y que recibe la opcion del usuario
        // y la retorna.
        static string Menu()
        {
            Console.WriteLine(
                "\n Menu de operaciones \n" +
                "1.Sumar \n" +
                "2.Restar \n" +
                "3.Multiplicar \n" +
                "4.Dividir \n");
            Console.Write("Ingrese su opcion:");
            return Console.ReadLine();
        }
        //Funcion de Operaciones que recibe la opcion del usuario y los dos numeros ingresados
        //retorna el resultado dependiendo de la opcion
        static string Operaciones(string Opcio, double num1, double num2)
        {
            if (Opcio == "1")
            {
                return $"El resultado es:{num1 + num2}";
            } else if (Opcio == "2") 
            {
                return $"El resultado es:{num1 - num2}";

            }
            else if (Opcio == "3")
            {
                return $"El resultado es:{num1 * num2}";
            }
            else if(Opcio == "4")
            {
                if (num2 == 0)
                    return $"Error no se puede dividir entre 0";
                return $"El resultado es:{num1 / num2}";
            }
            else
            {
                return $"Error opcion invalida: {Opcio}";
            }
            
        }
    }
}