using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muestra
            Console.WriteLine("Ingrese un numero: ");
            //Lee
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + (num1+num2));

        }
    }
}
