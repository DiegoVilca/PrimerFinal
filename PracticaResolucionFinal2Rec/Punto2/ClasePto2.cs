using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto2
{
    public class ClasePto2
    {

        public static void DevolverPilaInvertida(Stack<double> miPila)
        {
            Stack<double> auxPila = new Stack<double>();

            foreach (double item in miPila)
            {
                auxPila.Push(item);
            }

            foreach (double item in auxPila)
            {
                Console.WriteLine(item);
            }
        }
    }
}
