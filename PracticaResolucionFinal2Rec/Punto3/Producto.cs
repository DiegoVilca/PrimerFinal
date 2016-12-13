using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto3
{
    public class Producto
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Producto()
        {
            //xml
        }
        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
