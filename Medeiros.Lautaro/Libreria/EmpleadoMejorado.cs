using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
  public class EmpleadoMejorado
  {
    private string _nombre;
    private int _legajo;
    private float _sueldo;
    public event DelSueldo _limiteSueldo;//Esto se hace siempre 

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
        EmpleadoSueldoArgs esa = new EmpleadoSueldoArgs();
        esa.Sueldo = value;
        if (value > 12000)
        {          
          this._limiteSueldo(this,esa);//aca se lanza el evento
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
