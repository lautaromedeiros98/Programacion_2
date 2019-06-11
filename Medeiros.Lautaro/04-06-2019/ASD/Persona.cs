using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Entidades
{
    public class Persona : Humano , ASD.ISerializableXML
    {
        public string apellido;
        public string nombre;

        public string Path
        {
            get
            {
                return "a";
            }
            set
            {

            }
        }

        public Persona()
        {

        }

        public Persona(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return base.ToString() + "Nombre: " + nombre + " Apellido: " + apellido;
        }

        public bool SerializarXml()
        {
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(@"D:\VisualStudio\04-06-2019\personas.xml"))
                        {
                            serializador.Serialize(writer, this);
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
        }

        public object Deserializar()
        {
            Persona a=null;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Humano));
                using (StreamReader reader = new StreamReader(@"D:\VisualStudio\04-06-2019\personas.xml"))
                {
                    a = (Persona)serializador.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return a;
        }
    }
}
