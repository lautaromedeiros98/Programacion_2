using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto a)
        {
            if(this+a)
            {
                return true;
            }
            return false;
        }

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        private int GetIndice(Auto a)
        {
           return this._lista.IndexOf(a);
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            foreach(Auto item in d._lista)
            {
                if(item == a)
                {
                    d._lista.RemoveAt(d.GetIndice(a));
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(DepositoDeAutos d , Auto a)
        {
           if (d._lista.Count < d._capacidadMaxima)        
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("CAPACIDAD MAXIMA: " + _capacidadMaxima);
            retorno.AppendLine("Listado de autos: ");
            foreach(Auto item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }
    }
}
