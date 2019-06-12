using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _11_06_2019.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      AccesoDatos acc = new AccesoDatos();
      List<Persona> personas = new List<Persona>();
      personas = acc.TraerTodos();
      //acc.ModificarPersona(new Persona(13, "PEPEPEPE", "PEPEPEPE", 99));
      //acc.EliminarPersona(13);
      DataTable dt = acc.TraerTablaPersonas();
      foreach(DataRow item in dt.Rows)
      {
        Console.Write(item[0]+"-");
        Console.Write(item[1] + "-");
        Console.Write(item[2] + "-");
        Console.Write(item[3] + "-");
        Console.WriteLine("") ;
      }
      Console.ReadKey();
    }
  }
}
