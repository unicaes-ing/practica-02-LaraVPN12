using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Practica_2_6
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            Console.WriteLine("Hoy es {0} y son las {1}",hoy.ToLongDateString(),hoy.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
