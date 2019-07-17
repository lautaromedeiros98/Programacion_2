using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Data.SqlClient;

namespace Entidades.SP
{
	public class Cajon<T> : ISerializar
	{
		protected int _capacidad;
		protected List<T> _elementos;
		protected double _precioUnitario;
		public Manejadora<T> manejadora;
		public event MiDelegado EventoPrecio;
		private SqlCommand _comando;
		private SqlConnection _conexion = new SqlConnection(Properties.Settings.Default.conexcion);

		public List<T> Elementos
		{
			get
			{
				return this._elementos;
			}
		}

		public double PrecioTotal
		{
			get
			{
				return this._precioUnitario * this.Elementos.Count;
			}
		}

		public Cajon()
		{
			this._elementos = new List<T>();
			manejadora = new Manejadora<T>();
			this.EventoPrecio += new MiDelegado(manejadora.MetodoManejador);
		}

		public Cajon(int capacidad)
			: this()
		{
			this._capacidad = capacidad;
		}

		public Cajon(double precioUni,int capacidad)
			: this(capacidad)
		{
			this._precioUnitario = precioUni;
		}

		public override string ToString()
		{
			StringBuilder r = new StringBuilder();
			r.AppendLine("Capacidad: " + this._capacidad + " Cantidad de elementos: " + this.Elementos.Count + " Precio total: " + this.PrecioTotal);
			foreach (T item in this.Elementos)
			{
				r.AppendLine(item.ToString());
			}
			return r.ToString();
		}

		public bool Xml(string path)
		{
			XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
			XmlTextWriter writer = new XmlTextWriter(path,Encoding.UTF32);
			try
			{
				ser.Serialize(writer, this);
				writer.Close();
				return true;
			}
			catch
			{
				throw new Exception("Error");
			}
		}

		public static Cajon<T> operator +(Cajon<T> c , T elemento)
		{

			if (c.Elementos.Count <= c._capacidad)
			{
				c.Elementos.Add(elemento);
				if(c.PrecioTotal>55)
				{
					c.EventoPrecio.Invoke(c);
				}
			}
			else
			{
				throw new CajonLlenoException("Supera la capacidad del cajon");
			}
			return c;
		}

		
		public delegate void MiDelegado(Cajon<T> cajon);
	}

	public static class Cajon
	{
		private static SqlCommand _comando;
		private static  SqlConnection _conexion = new SqlConnection(Properties.Settings.Default.conexcion);

		public static bool EliminarFruta(this Cajon<Manzana> cajon,int id)
		{
			_comando = new SqlCommand();
			_comando.Connection = _conexion;
			_comando.CommandType = System.Data.CommandType.Text;
			_comando.CommandText = "DELETE FROM sp_lab_II.dbo.frutas WHERE id=" + id;
			try
			{
				_conexion.Open();
				if (_comando.ExecuteNonQuery() > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception a)
			{
				throw a;
			}
			finally
			{
				_conexion.Close();
			}
		}
	}
}
