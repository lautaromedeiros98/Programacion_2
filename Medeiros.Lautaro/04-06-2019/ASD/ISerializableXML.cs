using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD
{
    public interface ISerializableXML//Definir metodos y propiedades para varias clases
    {
        bool SerializarXml();
        object Deserializar();

        string Path
        {
            get;
            set;
        }
    }
}
