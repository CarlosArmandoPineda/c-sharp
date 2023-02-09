using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Metodos_con_Retorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros(7, 9));
            Console.WriteLine(dividenumeros(18, 7));
            Console.WriteLine(divide2(18, 7));
        }

        static int sumaNumeros(int n1, int n2)
        {
            return n1 + n2;
        }

        static double dividenumeros(double num1, double num2) => num1/num2;

        static double divide2(double nu1,int nu2)
        {
            double resultado;

            resultado = nu1 / nu2;
            
            return resultado;
        }
    }
}
