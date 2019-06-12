using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_2019.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      AccesoDatos acc = new AccesoDatos();
      List<Persona> personas = new List<Persona>();
      personas = acc.TraerTodos();
      foreach(Persona e in personas)
      {
        Console.WriteLine(e.ToString());
      }
      //acc.ModificarPersona(new Persona(13, "PEPEPEPE", "PEPEPEPE", 99));
      //acc.EliminarPersona(13);
      Console.ReadKey();
      Console.Clear();
      foreach (Persona e in personas)
      {
        Console.WriteLine(e.ToString());
      }
      Console.ReadKey();
    }
  }
}
