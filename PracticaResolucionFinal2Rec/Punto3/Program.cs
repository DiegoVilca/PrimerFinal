using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito deposito1 = new Deposito();
            Deposito deposito2 = new Deposito();

            
            deposito1.misProductos[0] = new Producto("tv", 5);
            deposito1.misProductos[1] = new Producto("espejito", 6);
            deposito1.misProductos[2] = new Producto("jabon", 10);
            deposito2.misProductos[0] = new Producto("shampoo", 12);
            deposito2.misProductos[1] = new Producto("shampoo", 12);
            deposito2.misProductos[2] = new Producto("silla", 4);

            Producto[] aux;

            aux = deposito1 + deposito2;

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] != null)
                {
                    Console.WriteLine(aux[i].Nombre +" "+ aux[i].Stock);
                }
            }
           
            Console.ReadKey();
        }
    }
}
