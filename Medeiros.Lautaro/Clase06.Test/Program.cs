using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase6.Entidades;

namespace Clase06.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Tempera temp = new Tempera(ConsoleColor.Cyan, "Alba", 50);
      Tempera temp2 = new Tempera(ConsoleColor.Cyan, "Alba", 50);

      Console.WriteLine(Tempera.Mostrar(temp));

      temp = temp + temp2;
      Console.WriteLine(Tempera.Mostrar(temp));

      Console.ReadKey();
    }
  }
}
