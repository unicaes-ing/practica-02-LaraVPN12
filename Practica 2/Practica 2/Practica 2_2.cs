using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Practica_2_2
    {
        static void Main(string[] args)
        {
            string producto;
            double precio;
            int cantidad;
            double subtotal, total;
            Console.Write("Ingrese el nombre del producto:\n");
            producto = Convert.ToString(System.Console.ReadLine());
            Console.Write("Ingrese la cantidad del producto:\n");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el precio del producto:\n");
            precio = Convert.ToDouble(System.Console.ReadLine());
            subtotal = precio * cantidad;
            total = subtotal + (subtotal * 0.13);
            Console.WriteLine("\n{0}\t{1}\t${2}", producto, cantidad, precio);
            Console.WriteLine("Subtotal: {0:C2}\nIVA: 0.13", subtotal);
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOTAL: {0}", total);
            Console.ReadKey();
        }
    }
}
