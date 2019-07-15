using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.SP
{
	public class Manejadora<T>
	{
		public void MetodoManejador(Cajon<T> a)
		{
			StreamWriter writer = new StreamWriter("LOGevento.log");
			try
			{
				writer.WriteLine(DateTime.Now.ToString() + " Nuevo precio: " + a.PrecioTotal );
				writer.Close();
			}
			catch
			{

			}
		}
	}
}
