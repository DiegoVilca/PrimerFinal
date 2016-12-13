using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto4
{
    public class ProdExport:ProdImpuesto
    {
        public string nacionalidad;


        public ProdExport()
        {
            //xml
        }
        public ProdExport(ProdImpuesto pI, string nacionalidad) :base(pI.Nombre, pI.Stock, pI.costo)
        {
            this.nacionalidad = nacionalidad;
        }
    }
}
