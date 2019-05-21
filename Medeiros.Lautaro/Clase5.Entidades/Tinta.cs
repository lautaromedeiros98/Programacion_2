using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.Entidades
{
   public class Tinta
   {
    private ConsoleColor _color;
    private ETipoTinta _eTipoTinta;

    public Tinta()
    :this(ConsoleColor.Black,ETipoTinta.Comun)
    {
    }

    public Tinta(ConsoleColor color)
      :this(color,ETipoTinta.Comun)
    {
    }

    public Tinta(ConsoleColor color ,ETipoTinta tipoTinta)
    {
      this._color = color;
      this._eTipoTinta = tipoTinta;
    }

    private string Mostrar()
    {
      return "Color de tinta: " + this._color.ToString() + " Tipo tinta: " + this._eTipoTinta.ToString() + "" +
      "";
    }

    public static string Mostrar(Tinta tinta)
    {
      return tinta.Mostrar();
    }

    public static bool operator ==(Tinta tintaUno,Tinta tintaDos)
    {
      if(tintaUno._color==tintaDos._color)
      { 
        if(tintaUno._eTipoTinta == tintaDos._eTipoTinta)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Tinta tintaUno, Tinta tintaDos)
    {
      return !(tintaUno == tintaDos);
    }
  }
}
