 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Punto1;
using System.Xml;
using System.Xml.Serialization;
using Punto3;
using Punto4;



namespace Punto5 
{

    public delegate void EventHandler(object obj, EventArgs args);

    [XmlInclude(typeof(Deposito))]
    [XmlInclude(typeof(ProdImpuesto))]
    [XmlInclude(typeof(ProdExport))]
    [XmlInclude(typeof(ProdVendido))]
    public class Galpon <T> :IGuardarXML
    {
        public List<T> miLista;

        private int _cantidad;
        public event EventHandler EsImpar;


        
        public Galpon()
        {
            miLista = new List<T>();
        }

        public int Cantidad
        {
            //xml --------------------
            get 
            {
                return this._cantidad;
            }
            //------------------------
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Valor 0 no permitido");
                }
                else
                {
                    if (value.EsPar())
                    {
                        this._cantidad = value;
                    }
                    else
                    {
                        if (value.EsImpar())
                        {
                            if (EsImpar != null)
                            {
                                this._cantidad = value;
                                EsImpar(this.ToString(), null);
                            }
                            
                        }

                    }
                
                }
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.miLista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(this._cantidad.ToString());

            return sb.ToString();
        }



        public bool SerializarXML()
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("archivo.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Galpon<T>));

                    serializador.Serialize(escritor, this);

                    Console.WriteLine("el xml se ha guardado con exito");

                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("no se ha podido guardar xml: " + ex.Message+ ex.InnerException.Message);
                return false;
            }
        }
    }
}
