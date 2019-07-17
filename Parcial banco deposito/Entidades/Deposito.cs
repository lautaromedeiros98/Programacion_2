using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(DepositoHeredado))]
    public class Deposito
    {
        public Producto[] productos;

        public Deposito() : this(3)
        {
        }
        public Deposito(int capacidad)
        {
            productos = new Producto[capacidad];
        }


        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] retorno = new Producto[3];

            retorno[0] = new Producto("tomate", 0);
            retorno[1] = new Producto("yerba", 0);
            retorno[2] = new Producto("azucar", 0);
            int i;
            int j;
            for (i = 0; i < d1.productos.Length; i++)
            {
                for (j = 0; j < retorno.Length; j++)
                {
                    if (retorno[j].nombre == d1.productos[i].nombre)
                    {
                        retorno[j].stock += d1.productos[i].stock;
                    }
                }
               
            }
            for (i = 0; i < d2.productos.Length; i++)
            {
                for (j = 0; j < retorno.Length; j++)
                {
                    if (retorno[j].nombre == d2.productos[i].nombre)
                    {
                        retorno[j].stock += d2.productos[i].stock;
                    }
                }
            }
            return retorno;
        }
    }
}
