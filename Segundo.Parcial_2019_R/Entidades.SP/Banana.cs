using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
	public class Banana : Fruta
	{
		protected string _paisOrigen;

		public string Nombre
		{
			get
			{
				return "Banana";
			}
		}

		public Banana()
			:base()
		{

		}

		public double Peso
		{
			get
			{
				return this._peso;
			}
		}

		protected override bool TieneCarozo
		{
			get
			{ return false; }
		}

		public override string ToString()
		{
			return this.Nombre + " " + base.FrutaToString() + " Tiene carozo: " + this.TieneCarozo;
		}

		public Banana(string color, double peso, string paisOrigen)
			: base(color, peso)
		{
			this._paisOrigen = paisOrigen;
		}
	}
}
