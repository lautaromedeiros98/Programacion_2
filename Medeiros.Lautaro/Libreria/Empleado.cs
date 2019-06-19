using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
  public class Empleado
  {
    private string _nombre;
    private int _legajo;
    private float _sueldo;
    public event DelegadoSueldo _limiteSueldo;//Esto se hace siempre 

    public string Nombre
    {
      get
      {
        return this._nombre;
      }
      set
      {
        this._nombre = value;
      }
    }

    public int Legajo
    {
      get
      {
        return this._legajo;
      }
      set
      {
        this._legajo = value;
      }
    }

    public float Sueldo
    {
      get
      {
        return this._sueldo;
      }
      set
      {
        if (value > 12000)
        {
          this._limiteSueldo(this, value);//aca se lanza el evento
        }
        else
        {
          this._sueldo = value;
        }
      }
    }

    public override string ToString()
    {
      return Nombre + "-" + Legajo + "-" + Sueldo;
    }
  }
}
