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
            double price = 37.89;
            int iva = 21;

            double calculateIva = price * iva / 100;
            double totalPrice = calculateIva + price;

            Console.WriteLine("Mi precio sin IVA es: " + price);
            Console.WriteLine("El IVA de la factura es: " + calculateIva);
            Console.WriteLine("La factura total a pagar es: " + totalPrice);

            Console.ReadKey();

        }
    }
}
