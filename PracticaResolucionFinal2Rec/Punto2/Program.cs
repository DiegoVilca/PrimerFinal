using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> mipila = new Stack<double>();

            mipila.Push(3);
            mipila.Push(2);
            mipila.Push(1);


            foreach (double item in mipila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");

            ClasePto2.DevolverPilaInvertida(mipila);


            Console.ReadKey();

        }
    }
}
