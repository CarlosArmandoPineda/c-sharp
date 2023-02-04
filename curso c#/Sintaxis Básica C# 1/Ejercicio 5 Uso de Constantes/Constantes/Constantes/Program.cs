using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //usar el termino const para declarar una constante

            //Calcular el area de un circulo 

            const double PI = 3.1416;

            Console.WriteLine("Ingrese el radio: ");
            double radio = double.Parse(Console.ReadLine());

            //Calculo de radio 
            //double area = radio * radio * PI;

            //Calculo de radio con pow
            double area = Math.Pow(radio,2) * PI;

            Console.WriteLine("El area es: " + area);
        }
    }
}
