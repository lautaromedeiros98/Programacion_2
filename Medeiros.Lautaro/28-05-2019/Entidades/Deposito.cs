using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Agregar(T a)
        {
            if (this + a)
            {
                return true;
            }
            return false;
        }

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        private int GetIndice(T a)
        {
            foreach(T item in this._lista)
            {
                if(item.Equals(a))
                {
                    return this._lista.IndexOf(a);
                }
            }
            return -1;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            foreach (T item in d._lista )
            {
                if (item.Equals(a))
                {
                    d._lista.RemoveAt(d.GetIndice(a));
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("CAPACIDAD MAXIMA: " + _capacidadMaxima);
            retorno.AppendLine("Listado de " +typeof(T).Name+ ":");
            foreach (T item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }

    }
}
