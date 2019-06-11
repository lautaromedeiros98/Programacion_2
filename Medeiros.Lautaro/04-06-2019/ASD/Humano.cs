using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Profesor))]//permite serializar estos tipos
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Persona))]
    public class  Humano
    {
        private int _dni;

        public int Dni
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }

        public override string ToString()
        {
            return "Dni: " + this.Dni +" "; 
        }


        public static bool SerializarHumano(Humano a)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Humano));
                try
                {
                    using (StreamWriter writer = new StreamWriter(@"D:\VisualStudio\04-06-2019\humanos.xml"))
                    {
                        serializador.Serialize(writer, a);
                        writer.Close();
                    }
                    return true;
                }
                catch (Exception p)
                {
                    Console.WriteLine(p.Message);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static Humano DeserializarHumano()
        {
            Humano a;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Humano));
                using (StreamReader reader = new StreamReader(@"D:\VisualStudio\04-06-2019\humano.xml"))
                {
                    a = (Humano)serializador.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                a = null;
            }
            return a;
        }

        public static List<Humano> SerializarLista(List<Humano> l)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<Humano>));
            try
            {
                using (StreamWriter writer = new StreamWriter(@"D:\VisualStudio\04-06-2019\listahumano.xml"))
                {
                    serializador.Serialize(writer, l);
                    writer.Close();
                }
                return l;
            }
            catch (Exception p)
            {
                Console.WriteLine(p.Message);
                return l;
            }
        }

        public static List<Humano> DeserializarLista()
        {
            List<Humano> a;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Humano>));
                using (StreamReader reader = new StreamReader(@"D:\VisualStudio\04-06-2019\listahumano.xml"))
                {
                    a = (List<Humano>)serializador.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                a = null;
            }
            return a;
        }
    }
}
