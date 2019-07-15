using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
	public class Durazno : Fruta
	{
		protected int _cantPelusa;

		public string Nombre
		{
			get
			{
				return "Durazno";
			}
		}

		protected override bool TieneCarozo
		{
			get
			{ return true; }
		}

		public Durazno()
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

		public override string ToString()
		{
			return this.Nombre + " " +base.FrutaToString() + " Tiene carozo: " + this.TieneCarozo;
		}

		public Durazno(string color, double peso, int cantPelusa)
			: base(color, peso)
		{
			this._cantPelusa = cantPelusa;
		}
	}
}
