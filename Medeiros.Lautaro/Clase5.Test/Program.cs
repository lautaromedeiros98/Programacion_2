using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase5.Entidades;

namespace Clase5.Test
{
  public class Program
  {
    static void Main(string[] args)
    {
      Tinta tintaTres = new Tinta(ConsoleColor.Gray, ETipoTinta.China);
      Tinta tintaCuatro = new Tinta(ConsoleColor.Gray, ETipoTinta.China);
      /*
     Tinta tintaUno = new Tinta();
     Tinta tintaDos = new Tinta(ConsoleColor.DarkBlue);
     Tinta tintaCuatro = new Tinta();
     if(tintaCuatro == tintaUno)
     {
       Console.WriteLine("Hola");
     }
     Console.WriteLine(Tinta.Mostrar(tintaUno));
     Console.WriteLine(Tinta.Mostrar(tintaDos));
     Console.WriteLine(Tinta.Mostrar(tintaTres));
     Console.ReadKey();
     */

      Pluma plumaTres = new Pluma(40, "Bic", tintaTres);
      Console.WriteLine((string)plumaTres);
      plumaTres += tintaCuatro;
      Console.WriteLine("**"+(string)plumaTres);
      Console.ReadKey();
    }
  }
}
