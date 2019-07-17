using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : new()
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(archivo);
            serializer.Serialize(writer, datos);
            writer.Close();
        }
        public void Leer(string archivo, out T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader writer = new StreamReader(archivo);
            datos = (T)serializer.Deserialize(writer);
            writer.Close();
        }
    }
}
