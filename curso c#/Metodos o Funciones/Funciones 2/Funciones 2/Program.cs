using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_2
{
    class Program
    {
        static void Main(string[] args)
        {
            sumaNumeros(7,8);
        }

        //Funcion Void con Parametros
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("El resultado es: " + (num1+num2));
        }
    }
}
