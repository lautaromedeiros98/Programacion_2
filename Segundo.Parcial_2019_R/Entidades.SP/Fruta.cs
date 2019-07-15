using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public abstract class Fruta
    {
		protected string _color;
		protected double _peso;

		protected abstract bool TieneCarozo
		{
			get;
		}

		public Fruta()
		{

		}

		public Fruta(string color,double peso)
		{
			this._color = color;
			this._peso = peso;
		}

		protected virtual string FrutaToString()
		{
			return "Color: " + this._color + " Peso: " + this._peso;
		}
    }
}
