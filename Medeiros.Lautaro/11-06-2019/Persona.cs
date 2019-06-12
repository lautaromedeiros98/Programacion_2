using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_2019
{
  public class Persona
  {
    private int _id;
    private string _nombre;
    private string _apellido;
    private int _edad;

    public Persona(int id,string nombre,string apellido,int edad)
    {
      this._id = id;
      this._nombre = nombre;
      this._apellido = apellido;
      this._edad = edad;
    }

    public string Nombre
    {
      get
      {
        return this._nombre;
      }
    }

    public string Apellido
    {
      get
      {
        return this._apellido;
      }
    }

    public int Edad
    {
      get
      {
        return this._edad;
      }
    }

    public int Id
    {
      get
      {
        return this._id;
      }
    }

    public override string ToString()
    {
      return "Nombre: " + _nombre + " Apellido: " + _apellido + " Edad: " + _edad + " Id: " + _id +"\n";
    }
  }
}
