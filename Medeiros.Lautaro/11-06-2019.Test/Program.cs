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
      AccesoDatos hola = new AccesoDatos();
      List<Persona> personas = hola.TraerTodos();
      Persona p = new Persona(72,"Pe","Dro",99);
      string retorno = "";
      string retorno2 = "";
      foreach (Persona item in personas)
      {
        retorno += item.ToString();
      }
      Console.WriteLine(retorno);
      Console.ReadKey();

      hola.AgregarPersona(p);
      personas = hola.TraerTodos();
      foreach (Persona item in personas)
      {
        retorno2 += item.ToString();
      }
      Console.WriteLine(retorno2);
      Console.ReadKey();
    }
  }
}
