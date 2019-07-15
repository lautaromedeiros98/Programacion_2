using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Entidades.SP
{
	public class Manzana : Fruta , ISerializar , IDeserializar
	{
		protected string _provinciaOrigen;
		
		public string Nombre
		{
			get
			{
				return "Manzana";
			}
		}

		public string Color
		{
			get
			{
				return this._color;
			}
			set
			{
				this._color = value;
			}
		}

		public double Peso
		{
			get
			{
				return this._peso;
			}
			set
			{
				this._peso = value;
			}
		}

		protected override bool TieneCarozo
		{
			get
			{ return true; }
		}

		public Manzana()
			:base()
		{

		}

		public override string ToString()
		{
			return this.Nombre + " " + base.FrutaToString() + " Tiene carozo: " + this.TieneCarozo;
		}

		public Manzana(string color,double peso,string provinciaOrigen)
			:base(color,peso)
		{
			this._provinciaOrigen = provinciaOrigen;
		}

		public bool Xml(string path)
		{
			XmlSerializer ser = new XmlSerializer(typeof(Manzana));
			XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF32);
			try
			{
				ser.Serialize(writer, this);
				writer.Close();
				return true;
			}
			catch(Exception z)
			{
				throw new Exception(z.Message);
			}		
		}

		bool IDeserializar.Xml(string path, out Fruta fruta)
		{
			XmlSerializer ser = new XmlSerializer(typeof(Manzana));
			XmlTextReader reader = new XmlTextReader(path);
			try
			{
				fruta = (Manzana)ser.Deserialize(reader);
				reader.Close();
				return true;
			}
			catch(Exception h)
			{
				throw h;
			}
		}
	}
}
