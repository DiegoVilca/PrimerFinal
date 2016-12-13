using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto7
{
    public class MiException : Exception
    {
        public MiException(string mensaje) :this(mensaje, null)
        {

        }

        public MiException(string mensaje, Exception ex) :base(mensaje, ex)
        {

        }
    }
}
