using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto1
{
    public static class Extensor
    {
        public static bool EsPar(this int valor)
        {
            if (valor % 2 == 0)
            {
                return true;
            }

            return false;
        }


        public static bool EsImpar(this int valor)
        {
            return !(valor.EsPar());
        }

    }
}
