using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.Entidades
{
   public class Pluma
  {
    private string _marca;
    private Tinta _tinta;
    private int _cantidad;

    public Pluma()
    :this(0,"sin marca",null)
    {

    }

    public Pluma(int cantidad)
    :this(cantidad,"sin marca",null)
    {
   
    }

    public Pluma(int cantidad,string marca)
    :this(cantidad,marca,null)
    {

    }

    public Pluma(int cantidad,string marca,Tinta tinta)
    {
      this._cantidad = cantidad;
      this._marca = marca;
      this._tinta = tinta;
    }

    private string Mostrar()
    {
      return "Cantidad: " + this._cantidad.ToString()+ " " + Tinta.Mostrar(this._tinta) +"  Marca: " + this._marca;
    }

    public static string Mostrar(Pluma a)
    {
      return a.Mostrar();
    }

    public static bool operator ==(Pluma p ,Tinta t)
    {
      if(t == p._tinta)
      {
        return true;
      }
      return false;
    }

    public static bool operator !=(Pluma p, Tinta t)
    {
      return !(p == t);
    }

    public static explicit operator string(Pluma a)
    {
      return a.Mostrar();
    }

    public static Pluma operator +(Pluma p, Tinta t)
    {
      if(p._tinta == t)
      {
        p._cantidad += 10;
      }

      if(p._cantidad <= 100)
      {
        return p;
      }

      return null;
    }

  }
}
