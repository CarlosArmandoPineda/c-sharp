using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion Explicita
            double temperaturaMadrid = 34.5;
            int tempertatura;

            tempertatura = (int)temperaturaMadrid;

            Console.WriteLine("La temperatura es: " + tempertatura);

            //Conversion Implicita
            int habitantesSps = 1000000;
            long habitantes;

            //No necesita una conversion 
            habitantes = habitantesSps;

            Console.WriteLine($"habitantes: {habitantes}");


        }
    }
}
