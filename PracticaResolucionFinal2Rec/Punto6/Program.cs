using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Punto5;

namespace Punto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Galpon<string> miGalpon = new Galpon<string>();
            EventListener claseQueEscucha = new EventListener();

            try
            {
                claseQueEscucha.MetodoQueEscucha(miGalpon, "C://carpetaMengano//log.txt");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
