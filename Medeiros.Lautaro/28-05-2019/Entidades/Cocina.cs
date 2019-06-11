using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int codigo,double precio,bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public override bool Equals(object obj)
        {
            if(obj is Cocina)
            {
                if((Cocina)obj == this)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cocina a,Cocina b)
        {
            return !(a == b);
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            if(a.Codigo == b.Codigo)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("Codigo: " + Codigo);
            retorno.Append(" Precio: " + Precio);
            if(this.EsIndustrial)
            {
                retorno.Append(" Es industrial");
            }
            else
            {
                retorno.Append(" No es industrial");
            }
            return retorno.ToString();
        }
    }
}
