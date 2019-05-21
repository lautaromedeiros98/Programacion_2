using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.Entidades
{
  public class Paleta
  {
    private List<Tempera> _temperas;

    private Paleta()
      :this(5)
    {
      
    }

    public List<Tempera> Temperas
    {
      get
      {
        return this._temperas;
      }
    }

    private Paleta(int cantidad)
    {
      _temperas = new List<Tempera>();
    }

    public static implicit operator Paleta(int a)
    {
      Paleta p = new Paleta(a);
      return p;
    }

    private string Mostrar()
    {
      StringBuilder retorno = new StringBuilder();
      foreach(Tempera e in this._temperas)
      {
        if(!Equals(e,null))
        {
          retorno.AppendLine(Tempera.Mostrar(e));
        }
      }
      return retorno.ToString();
    }

    public static explicit operator string(Paleta p)
    {
      return p.Mostrar();
    }

    public static bool operator ==(Paleta p,Tempera t)
    {
      foreach(Tempera u in p._temperas)
      {
        if(u==t)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Paleta p, Tempera t)
    {
      return !(p == t);
    }

    public static Paleta operator +(Paleta p , Tempera t)
    {
			if(p!=t)
			{
				p._temperas.Add(t);
			}
			return p;
    }

    public static Paleta operator -(Paleta p , Tempera t)
    {
      if(p==t)
      {
        p._temperas.Remove(t);
      }
      return p;
    }
  }
}
