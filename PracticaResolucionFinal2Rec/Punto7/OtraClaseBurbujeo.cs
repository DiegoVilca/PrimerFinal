using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto7
{
    class OtraClaseBurbujeo
    {
        public static void MetodoClase()
        {
            try
            {
                claseBurbujeo obj = new claseBurbujeo();

                obj.MetodoInstancia();
            }
            catch (Exception ex)
            {

                throw new MiException("Metodo Clase - ", ex);
            }
            
        }
    }
}
