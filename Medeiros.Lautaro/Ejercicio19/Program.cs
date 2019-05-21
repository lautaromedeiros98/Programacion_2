using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase6.Entidades;

namespace Ejercicio19
{
  public class Program
  {
    static void Main(string[] args)
    {
      Paleta paletita = 8;
      Tempera a = new Tempera(ConsoleColor.Red, "a", 14);
      Tempera b = new Tempera(ConsoleColor.Black, "b", 19);
      Tempera c = new Tempera(ConsoleColor.Yellow, "c", 97);
      Tempera d = new Tempera(ConsoleColor.Blue, "d", 14);
      Tempera e = new Tempera(ConsoleColor.DarkCyan, "e", 19);
      Tempera f = new Tempera(ConsoleColor.DarkGreen, "f", 97);
      Tempera g = new Tempera(ConsoleColor.Green, "g", 14);
      Tempera h = new Tempera(ConsoleColor.DarkGreen, "h", 19);
      Tempera i = new Tempera(ConsoleColor.DarkMagenta, "i", 97);

      paletita += a;
      paletita += b;
      paletita += c;
      paletita += d;
      paletita += e;
      paletita += f;
      paletita += g;
      paletita += h;
      paletita += i;

      Console.WriteLine((string)paletita);
      Console.ReadKey();
    }
  }
}
