using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre:\n");
            nombre = Convert.ToString(System.Console.ReadLine());
            nombre = nombre.Replace("a", "#").Replace("e", "%").Replace("i", "$").Replace("o", "?").Replace("u", "*");
            Console.WriteLine("Su nuevo nombre es: {0}", nombre);
            Console.ReadKey();
        }
    }
}
