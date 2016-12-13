using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor;

            valor = 5;

            if (valor.EsPar())
            {
                Console.WriteLine("El valor es par");
            }
            else { Console.WriteLine("El valor es impar"); }
            

            Console.ReadKey();
        }
    }
}
