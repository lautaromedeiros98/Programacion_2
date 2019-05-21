using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Estacionamientos.starter
{
    public class EstacionamientoLlenoException : Exception
    {
        public EstacionamientoLlenoException(string mensaje)
            : base(mensaje)
        { }
    }
}
