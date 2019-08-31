using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Practica_2_4
    {
        static void Main(string[] args)
        {
            DateTime hora_inicio;
            DateTime hora_fin;
            double precio, total;
            Console.Write("Ingrese la hora de inico de la llamada:\n");
            hora_inicio = Convert.ToDateTime(System.Console.ReadLine());
            Console.Write("Ingrese la hora de finalización de la llamada:\n");
            hora_fin = Convert.ToDateTime(System.Console.ReadLine());
            Console.Write("Ingrese el costo por minuto de la llamada:\n");
            precio = Convert.ToDouble(System.Console.ReadLine());
            total = precio * hora_fin.Subtract(hora_inicio).TotalMinutes;
            Console.WriteLine("******************************************");
            Console.Write("HORA DE INICIO DE LA LLAMADA:\n");
            Console.Write(hora_inicio.ToString("HH:mm"));
            Console.Write("\nHORA DE FIN DE LA LLAMADA:\n");
            Console.Write(hora_fin.ToString("HH:mm"));
            Console.Write("\nDURACIÓN DE LA LLAMADA:\n");
            Console.Write(hora_fin.Subtract(hora_inicio).TotalMinutes + " minutos");
            Console.Write("\nTOTAL A PAGAR:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0:C2}", total);
            Console.ReadKey();
        }
    }
}
