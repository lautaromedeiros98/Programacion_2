using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.Entidades
{
  public class Tempera
  {
    private ConsoleColor _color;
    private string _marca;
    private sbyte _cantidad;

    public Tempera(ConsoleColor color,string marca,sbyte cantidad)
    {
      this._color = color;
      this._marca = marca;
      this._cantidad = cantidad;
    }

    public ConsoleColor Color
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

    public string Marca
    {
      get
      {
        return this._marca;
      }
      set
      {
        this._marca = value;
      }
    }

    public sbyte CantidadMaxima
    {
      get
      {
        return this._cantidad;
      }
      set
      {
        this._cantidad = value;
      }
    }

    private string Mostrar()
    {
      return this._color.ToString() + "-" + this._marca + "-" + this._cantidad.ToString();
    }

    public static string Mostrar(Tempera a)
    {
      if(!Equals(a,null))
      {
        return a.Mostrar();
      }
      return "";
    }

    public static bool operator ==(Tempera a, Tempera b)
    {
      if(!Equals(a,null) && !Equals(b,null))
      {
        if (a._color == b._color)
        {
          if (a._marca == b._marca)
          {
            return true;
          }
        }
      }
      return false;
    }

    public static bool operator !=(Tempera a, Tempera b)
    {
      return !(a == b);
    }

    public static Tempera operator +(Tempera a,sbyte b)
    {
      a._cantidad += b;
      return a;
    }

    public static Tempera operator +(Tempera a,Tempera b)
    {
      if(a==b)
      {
        a._cantidad += b;
        return a;
      }
      return a;
    }

    public static implicit operator sbyte(Tempera a)
    {
      if(!Equals(a,null))
      {
        return a._cantidad;
      }
      return 0;
    }
  }
}
