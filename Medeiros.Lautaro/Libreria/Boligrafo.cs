using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciou17
{
  public class Boligrafo
  {
    private const int cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta,ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public void Recargar()
    {
      this.tinta = cantidadTintaMaxima;
    }

    public bool Pintar(int gasto,out string dibujo)
    {
      dibujo = "";
      this.tinta -= (short)gasto;
      if(this.tinta >0)
      {
        for (int i = 0; i <= gasto; i++)
        {
          if(this.tinta>0)
          {
            dibujo += "*";
          }
        }
      }else
      {
        dibujo += "No alcanza la tinta";
      }     
      return true;
    }
    private void SetTinta(short tinta)
    {
      if(tinta>0)
      {
        if(this.tinta + tinta <= cantidadTintaMaxima)
        {
          this.tinta += tinta;
        }
      }

      if (tinta < 0)
      {
        if (this.tinta - tinta >= 0)
        {
          this.tinta -= tinta;
        }
      }
    }
  }
}
