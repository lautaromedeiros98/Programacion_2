using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string nombre;
        public double stock;

        public Producto()
        {

        }
        public Producto(string nombre, double stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
