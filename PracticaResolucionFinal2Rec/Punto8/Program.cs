using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Punto3;
using Punto4;
using Punto5;

namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {


            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");


            Deposito miDeposito = new Deposito();

            miDeposito.misProductos[0] = pro;
            miDeposito.misProductos[1] = pI;
            miDeposito.misProductos[2] = pEX;
            miDeposito.misProductos[3] = p;

            

            Galpon<Deposito> miGalpon = new Galpon<Deposito>();
            miGalpon.miLista.Add(miDeposito);

            EventListener<Deposito> claseQueEscucha = new EventListener<Deposito>();
            claseQueEscucha.MetodoQueEscucha(miGalpon, "log.txt");


            miGalpon.SerializarXML();


            Console.ReadKey();
            

        }
    }
}
