using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Alumno : Persona
    {
        private int _legajo;
        
        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Legajo: " + Legajo;
        }

        public static bool SerializarAlumno(Alumno a)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Alumno));
                try
                {
                   using (StreamWriter writer = new StreamWriter(@"D:\VisualStudio\04-06-2019\alumnos.xml"))
                    {
                        serializador.Serialize(writer, a);
                        writer.Close();
                    }
                    return true;
                }
                catch(Exception p)
                {
                    Console.WriteLine(p.Message);
                    return false;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }   
        }

        public static Alumno DeserializarAlumno()
        {
            Alumno a;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Alumno));
                using (StreamReader reader = new StreamReader(@"D:\VisualStudio\04-06-2019\alumnos.xml"))
                {
                    a = (Alumno)serializador.Deserialize(reader);
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
