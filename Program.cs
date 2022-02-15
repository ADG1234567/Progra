using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu Numero de Control:");
            string numCon = Console.ReadLine();
            Console.WriteLine("Ingresa tu Nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingresa tu Clase:");
            string clas = Console.ReadLine();
            Console.WriteLine("Ingresa tu Carrera:");
            string carr = Console.ReadLine();

            Console.WriteLine($"Hola {nom}, tu numero de control es: {numCon}, vas en la clase {clas} de la carrera {carr}");
            Console.Read();
        }
    }
}
