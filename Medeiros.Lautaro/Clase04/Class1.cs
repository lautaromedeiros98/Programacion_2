using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.Entidades
{
   public class Cosa
   {
    public int entero;
    public string cadena;
    public DateTime fecha;

    public string Mostrar()
    {
      StringBuilder retorno = new StringBuilder();
      retorno.Append(this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToString());
      return retorno.ToString();
    }

    public static string Mostrar(Cosa cosa)
    {
      return cosa.Mostrar();
    }

    public void EstablecerValor(int valor)
    {
      this.entero = valor;
    }

    public void EstablecerValor(DateTime valor)
    {
      this.fecha = valor;
    }

    public void EstablecerValor(string valor)
    {
      this.cadena = valor;
    }

    public Cosa()
    {
      this.entero = 10;
      this.cadena = "Sin valor";
      this.fecha = DateTime.Now;
    }

    public Cosa(int entero):this()
    {
      this.entero = entero;
    }

    public Cosa(int entero,DateTime fecha) : this()
    {
      this.entero = entero;
      this.fecha = fecha;
    }

    public Cosa(int entero,DateTime fecha,string cadena) : this()
    {
      this.entero = entero;
      this.fecha = fecha;
      this.cadena = cadena;
    }
  }
}
