using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Estacionamientos.starter
{
    public class Auto
    {
        private string _patente;
        private ConsoleColor _color;

        public string Patente
        {
            get { return this._patente; }
        }

        public ConsoleColor Color
        {
            get { return this._color; }
        }

        public Auto(string patente, ConsoleColor color)
        {
            this._patente = patente;
            this._color = color;
        }
    }
}
