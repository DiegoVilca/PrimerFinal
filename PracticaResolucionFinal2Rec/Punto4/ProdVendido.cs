using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto4
{
    public class ProdVendido:ProdExport
    {
        public string cliente;


        public ProdVendido()
        {
            //xml
        }
        public ProdVendido(ProdExport pE, string cliente) :base(new ProdImpuesto(pE.Nombre, pE.Stock, pE.costo), pE.nacionalidad)
        {
            this.cliente = cliente;
        }

    }
}
