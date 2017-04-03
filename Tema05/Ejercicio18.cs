using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Ejercicio18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a mostrar los números enteros comprendidos entre");
            Console.WriteLine("dos números que usted introduzca.");
            Console.WriteLine("Recuerde que los números no sean iguales.");
            Console.WriteLine("__________________________________________");

            Boolean isOkNumber = false;
            string linea;
            int number1;
            int number2;

            do
            {
                Console.Write("Introduzca el primer número: ");
                linea = Console.ReadLine();
                number1 = int.Parse(linea);

                Console.WriteLine(); //salto de línea
                Console.Write("Introduzca ahora el segundo número: ");
                linea = Console.ReadLine();
                number2 = int.Parse(linea);
                Console.WriteLine();

                if (number1 == number2)
                {
                    Console.WriteLine("Los números deben ser DIFERENTES.");
                }
                else
                {
                    isOkNumber = true;
                }

            } while (!isOkNumber);

            Console.WriteLine("Los números comprendidos entre " + number1 + " y " + number2 + " son: ");

            if (number1 < number2)
            {
                for (int i = number1; i < number2; i ++)
                {
                    Console.Write(" " + i);
                }
            } else
            {
                for (int i = number2; i < number1; i++)
                {
                    Console.Write(" " + i);
                }
            } //else

            Console.ReadKey();
        }
    }
}
