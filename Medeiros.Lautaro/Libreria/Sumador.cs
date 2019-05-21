using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
  public class Sumador
  {
    private int _cantidadSumas;

    public Sumador(int sumas)
    {
      this._cantidadSumas = sumas;
    }

    public Sumador()
    :this(0)
    {

    }

    public long Sumar(long a ,long b)
    {
      this._cantidadSumas++;
      return a + b;
    }

    public string Sumar(string a, string b)
    {
      this._cantidadSumas++;
      return a + b;
    }

    public static explicit operator int(Sumador a)
    {
      return a._cantidadSumas;
    }

    public static long operator + (Sumador a , Sumador b)
    {
      return a._cantidadSumas + b._cantidadSumas;
    }

    public static bool operator | (Sumador a ,Sumador b)
    {
      if(a._cantidadSumas == b._cantidadSumas)
      {
        return true;
      }
      return false;
    }
  }
}
