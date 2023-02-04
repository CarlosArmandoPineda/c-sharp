using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios_y_Salida_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Como Comentar
             Existen dos tipos
             1-//(Para comentarios de una sola linea)
             2-/*(Para comentarios de mas de una linea)
            */

            //Salida de datos
            int edad = 18;
            string nombre = "Armando";

            //Tipo1
            Console.WriteLine("Su edad es: " + edad);
            //Tipo 2
            Console.WriteLine($"Nombre: {nombre}");


        }
    }
}
