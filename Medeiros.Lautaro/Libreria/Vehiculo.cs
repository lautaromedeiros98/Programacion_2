using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos

{
  public abstract class Vehiculo
  {
    private string _patente;
    private Emarca _marca;
    private byte _cantidadRuedas;

    public Vehiculo(string p,Emarca m,byte c)
    {
      this._patente = p;
      this._marca = m;
      this._cantidadRuedas = c;
    }

    public abstract double Precio
    {
      get;set;
    }

    public abstract double CalcularPrecioConIva();

    public string Patente
    {
      get
      {
        return this._patente;
      }
    }

    public Emarca Marca
    {
      get
      {
        return this._marca;
      }
    }

    public static bool operator ==(Vehiculo a, Vehiculo b)
    {
      if(a._patente == b._patente)
      {
        if(a._marca == b._marca)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Vehiculo a, Vehiculo b)
    {
      return !(a == b);
    }

    protected virtual string Mostrar()
    {
      return "Patente: "+this._patente + "- " + "Marca: " +this._marca.ToString() + "- " + "Cantidad ruedas: " + this._cantidadRuedas + "- ";
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }

  public class Auto : Vehiculo
  {
    protected int _cantidadAsientos;

    public Auto(string p, Emarca m, byte c,int c2) :base(p,m,c)
    {
      this._cantidadAsientos = c2;
    }

    public override double Precio
    {
      get
      {
        return 100;
      }
      set
      {

      }
    }

    public override double CalcularPrecioConIva()
    {
      return ((Precio * 21) / 100) + Precio;
    }

    public string MostrarAuto()
    {
      return base.Mostrar() + "Cantidad asientos: "+this._cantidadAsientos;
    }

    public override string ToString()
    {
      return MostrarAuto();
    }
  }

  public class Moto : Vehiculo
  {
    protected float _cilindrada;

    public Moto(string p, Emarca m, byte c, float c2) :base(p, m, c)
    {
      this._cilindrada = c2;
    }

    public override double Precio
    {
      get
      {
        return 70;
      }
      set
      {

      }
    }

    public override double CalcularPrecioConIva()
    {
      return ((Precio * 21) / 100) + Precio;
    }

    public string MostrarMoto()
    {
      return base.Mostrar() + "Cilindrada: " + this._cilindrada;
    }

    public override string ToString()
    {
      return this.MostrarMoto();
    }
  }

  public class Camion : Vehiculo
  {
    protected float _tara;

    public Camion(string p, Emarca m, byte c, float c2) : base(p, m, c)
    {
      this._tara = c2;
    }

    public override double Precio
    {
      get
      {
        return 50;
      }
      set
      {

      }
    }

    public override double CalcularPrecioConIva()
    {
      return ((Precio * 21) / 100) + Precio;
    }

    public string MostrarCamion()
    {
      return base.Mostrar() + "Tara:" +this._tara;
    }

    public override string ToString()
    {
      return this.MostrarCamion();
    }
  }

}
