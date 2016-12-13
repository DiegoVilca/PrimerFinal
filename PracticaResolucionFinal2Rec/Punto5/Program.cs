using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Galpon<string> miGalpon = new Galpon<string>();

            miGalpon.miLista.Add("producto1");
            miGalpon.miLista.Add("producto2");
            miGalpon.miLista.Add("producto3");


            //miGalpon.EsImpar += miGalpon_EsImpar;

            //Console.WriteLine("Ingrese una cantidad");

            //miGalpon.Cantidad = int.Parse(Console.ReadLine());

            EventListener<string> claseQueEscucha = new EventListener<string>();
            

            claseQueEscucha.MetodoQueEscucha(miGalpon, "log.txt");

            

            Console.ReadKey();
        }


        //DEPRECATED POR CREACION CLASE EVENTLISTENER
        //static void miGalpon_EsImpar(object obj, EventArgs args)
        //{
        //    try
        //    {
        //        using (StreamWriter escritor = new StreamWriter("log.txt", true))
        //        {
        //            escritor.WriteLine(obj);

        //            Console.WriteLine("Se guardo con exito");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("El archivo no se ha podido guardar", ex);
        //    }
        //}
    }
}
