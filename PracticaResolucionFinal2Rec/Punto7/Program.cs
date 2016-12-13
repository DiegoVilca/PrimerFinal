using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClaseBurbujeo.MetodoClase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message + ex.Message + "Program");
            }

            Console.ReadKey();
        }
    }
}
