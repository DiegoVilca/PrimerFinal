using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto3
{
    public class Deposito
    {

        public Producto[] misProductos;

        public Deposito()
        {
            misProductos = new Producto[4]; //modificado de 3 a 4 por pto 8
        }



        public static Producto[] operator +(Deposito deposito1, Deposito deposito2)
        {

            Producto[] aux = new Producto[deposito1.misProductos.Length + deposito2.misProductos.Length];

            int bandera = 0;


            for (int i = 0; i < aux.Length; i++) //Inicializo el vector
            {
                aux[i] = null;
            }
           
            for (int i = 0; i < deposito1.misProductos.Length; i++) //Copio array de deposito1 en aux
            {
                aux[i] = deposito1.misProductos[i];
            }

           
           


            for (int k = 0; k < deposito2.misProductos.Length; k++) //Comparo aux con array de deposito2
            {

                for (int i = 0; i < aux.Length; i++)
                {


                        if (deposito2.misProductos[k] != null && aux[i] != null) 
                        {
                            if (aux[i].Nombre == deposito2.misProductos[k].Nombre) //Si el producto ya esta aumento su stock
                            {
                                aux[i].Stock++;

                                bandera = 1;
                            }
                                
                                
                        }
                            
                }


                if (bandera == 0)
                {
                    for (int j = 0; j < aux.Length; j++)
                    {
                        if (aux[j] == null) //Si no esta lo agrego a la primer ubicacion null que encuentre
                        {
                            aux[j] = deposito2.misProductos[k];

                            break;
                        }
                    }

                }


                bandera = 0;

            }

            


            return aux;
        }



        //Para Punto8
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.misProductos.Length; i++)
            {
                sb.AppendLine("Nombre: " + this.misProductos[i].Nombre + "  Stock: " + this.misProductos[i].Stock);
            }

            return sb.ToString();
        }


    }
}
