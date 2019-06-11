using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public bool Agregar(Cocina c)
        {
            if (this + c)
            {
                return true;
            }
            return false;
        }

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        private int GetIndice(Cocina c)
        {
            foreach(Cocina item in this._lista)
            {
                if(item==c)
                {
                    return this._lista.IndexOf(c);
                }
            }
            return -1;
        }

        public static bool operator -(DepositoDeCocinas d ,Cocina c)
        {
            foreach (Cocina item in d._lista)
            {
                if (item == c)
                {
                    d._lista.RemoveAt(d.GetIndice(c));
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(DepositoDeCocinas d,Cocina c)
        {
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("CAPACIDAD MAXIMA: " + _capacidadMaxima);
            retorno.AppendLine("Listado de cocinas: ");
            foreach (Cocina item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }
    }
}
