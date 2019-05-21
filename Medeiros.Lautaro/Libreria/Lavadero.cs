using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Libreria
{
  public class Lavadero
  {
    private List<Vehiculo> _vehiculos;
    private float _precioAuto;
    private float _precioCamion;
    private float _precioMoto;

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero(float pa ,float pc, float pm):this()
    {
      this._precioAuto = pa;
      this._precioMoto = pm;
      this._precioCamion = pc;
    }

    public string MiLavadero
    {
      get
      {
        StringBuilder retorno = new StringBuilder();
        retorno.AppendLine("Precio por auto: " + this._precioAuto);
        retorno.AppendLine("Precio por moto: " + this._precioMoto);
        retorno.AppendLine("Precio por camion: " + this._precioCamion);
        retorno.AppendLine("***VEHICULOS***");
        foreach(Vehiculo a in this.Vehiculos)
        {
          retorno.AppendLine(a.ToString());
        }
        return retorno.ToString();
      }
    }

    public List<Vehiculo> Vehiculos
    {
      get
      {
        return this._vehiculos;
      }
    }

    public static bool operator ==(Lavadero l,Vehiculo v)
    {
      foreach(Vehiculo aux in l.Vehiculos)
      {
        if(aux==v)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Lavadero l, Vehiculo v)
    {
      return !(l == v);
    }

    public static Lavadero operator +(Lavadero l, Vehiculo v)
    {
      if(l!=v)
      {
        l.Vehiculos.Add(v);
      }
      return l;
    }

    public static Lavadero operator -(Lavadero l ,Vehiculo v)
    {
      if(l==v)
      {
        l.Vehiculos.Remove(v);
      }
      return l;
    }

    public double MostrarTotalFacturado()
    {
      double resultado = 0;
      foreach(Vehiculo a in this.Vehiculos)
      {
        if(a is Auto)
        {
          resultado += this._precioAuto;
        }

        if (a is Moto)
        {
          resultado += this._precioMoto;
        }

        if (a is Camion)
        {
          resultado += this._precioCamion;
        }
      }
      return resultado;
    }

    public double MostrarTotalFacturado(EVehiculo tipo)
    {
      double resultado = 0;
      foreach(Vehiculo a in this.Vehiculos)
      {
        if(tipo == EVehiculo.Auto )
        {
          if(a is Auto)
          {
            resultado += this._precioAuto;
          }
        }

        if(tipo == EVehiculo.Moto)
        {
          if(a is Moto)
          {
            resultado += this._precioMoto;
          }
        }

        if(tipo == EVehiculo.Camion)
        {
          if(a is Camion)
          {
            resultado += this._precioCamion;
          }
        }
      }
      return resultado;
    }

    public static int OrdenarVehiculosPorPatente(Vehiculo a ,Vehiculo c)
    {
      return string.Compare(a.Patente, c.Patente);
    }

    public int OrdenarVehiculosPorMarca(Vehiculo a , Vehiculo c)
    {
      return string.Compare(a.Marca.ToString(), c.Marca.ToString());
    }
  }
}
