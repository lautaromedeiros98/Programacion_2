using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04.Entidades;

namespace Clase04.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Cosa cosaUno = new Cosa();
      Cosa cosaDos = new Cosa(1);
      Cosa cosaTres = new Cosa(2,DateTime.MinValue);
      Cosa cosaCuatro= new Cosa(3,DateTime.MaxValue,"Hola");

      Console.WriteLine(cosaUno.Mostrar());
      Console.WriteLine(cosaDos.Mostrar());
      Console.WriteLine(cosaTres.Mostrar());
      Console.WriteLine(Cosa.Mostrar(cosaCuatro));

      Console.ReadKey();
    }
  }
}
