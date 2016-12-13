using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto4
{
    public class ProdImpuesto: Punto3.Producto
    {

        public double costo;

        public ProdImpuesto()
        {
            //xml
        }
        public ProdImpuesto(string nombre, int stock, double costo) :base(nombre, stock)
        {
            this.costo = costo;
        }
    }
}
