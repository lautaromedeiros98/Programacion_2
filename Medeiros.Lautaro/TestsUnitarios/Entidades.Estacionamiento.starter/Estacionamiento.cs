using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Estacionamientos.starter
{
    public class Estacionamiento
    {
        private List<Auto> _autos;
        private int _espacio;

        private Estacionamiento()
        {
            this._autos = new List<Auto>();
        }

        public Estacionamiento(int espacio)
          :this() 
        {
            this._espacio = espacio;
        }

        public int EspacioDisponible
        {
            get
            {
                return this._espacio - this._autos.Count;
            }
        }

        private int Espacio
        {
            set
            {
                this._espacio = value;
            }
        }

        public List<Auto> Autos
        {
            get
            {
                return this._autos;
            }
        }

        public static Estacionamiento operator +(Estacionamiento e, Auto a)
        {
            if (e._espacio > e._autos.Count)
            {
                e._autos.Add(a);
                return e;
            }
            else
            {
                string mensaje = String.Format("El estacionamiento tiene sus {0} lugares ocupados", e._espacio);
                throw new EstacionamientoLlenoException(mensaje);
            }
        }
    }
}
