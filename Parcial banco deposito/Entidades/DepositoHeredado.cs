using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class DepositoHeredado : Deposito, ISerializar, IDeserializar
    {
        public Deposito depo;
        public DepositoHeredado()
        {

        }

        public bool Xml(string d)
        {
            bool retorno = false;
            try
            {
                StreamWriter sw = new StreamWriter(d);
                XmlSerializer xs = new XmlSerializer(typeof(Deposito));
                xs.Serialize(sw, this);
                retorno = true;
                sw.Close();
            }
            catch (Exception e )
            {

                throw e;
            }
            return retorno;
        }
        bool IDeserializar.Xml(string d,out Deposito e)
        {
            bool retorno = false;

            try
            {
                StreamReader sw = new StreamReader(d);
                XmlSerializer xs = new XmlSerializer(typeof(Deposito));
                depo = (Deposito)xs.Deserialize(sw);
                retorno = true;
                e = depo;

            }
            catch (Exception s)
            {

                throw s;
            }
            return retorno;
        }
    }
}
