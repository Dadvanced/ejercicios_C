using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cantidad de € a convertir: ");

            string line;
            line = Console.ReadLine();
            double euros = double.Parse(line);

            double converter = euros * 166.386;

            Console.WriteLine("La cantidad de euros introducida es " + converter + " pesetas.");
            Console.ReadKey();
        }
    }
}
