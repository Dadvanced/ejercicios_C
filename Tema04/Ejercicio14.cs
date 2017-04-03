using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a comprobar si el número introducido es par y/o");
            Console.WriteLine("divisible entre 5.");
            Console.Write("Por favor, introduzca el número: ");

            string linea;
            int numero;

            linea = Console.ReadLine(); //el usuario introduce el número entero deseado
            numero = int.Parse(linea); //assignamos el número introducido a la variable

            if (numero % 5 == 0)
            {
                Console.WriteLine("El número introducido es divisible entre 5.");
            } else
            {
                Console.WriteLine("El número introducido NO es divisible entre 5.");
            }


            if (numero % 2 == 0)
            {
                Console.WriteLine("El número introducido es divisible entre 2.");
            } else
            {
                Console.WriteLine("El número introducido NO es divisible entre 2.");
            }

            Console.ReadKey();
        }
    }
}
