﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Punto3;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {

            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");


            Console.ReadKey();

        }
    }
}
