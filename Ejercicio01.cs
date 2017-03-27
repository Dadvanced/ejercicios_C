using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string name;

            Console.WriteLine("Escriba su nombre por favor.");
            line = Console.ReadLine();
            name = line;

            Console.WriteLine("Su nombre es: " + name);

            Console.ReadKey();
        }
    }
}
