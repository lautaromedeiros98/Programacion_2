using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Ejerciciou17
{
  class Ejercicio17
  {
    static void Main(string[] args)
    {
      //Console.WriteLine(Test.Saludar());
      Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
      string auxiliar = "";
      int flag = 0;
      string escribir = "s";
      int cantidad = 0;
      do
      {
        Console.WriteLine("Con que boligrafo queres escribir? \n 1.AZUL\n 2.ROJO \n");
        flag=Convert.ToInt32(Console.ReadLine());

        switch(flag)
        {
          case 1:
            Console.WriteLine("Cuantos asteriscos?");
            cantidad = Convert.ToInt32(Console.ReadLine());
            if(cantidad>100)
            {
              Console.WriteLine("Lo maximo que se puede escribir son 100 digitos");
            }else
            {
              azul.Pintar(cantidad, out auxiliar);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
          case 2:            
            Console.WriteLine("Cuantos asteriscos?");
            cantidad= Convert.ToInt32(Console.ReadLine());
            if (cantidad > 100)
            {
              Console.WriteLine("Lo maximo que se puede escribir son 100 digitos");
            }
            else
            {
              azul.Pintar(cantidad, out auxiliar);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            break;
          default:
            Console.WriteLine("Ingrese una opcion valida");
            break;
        }

        Console.WriteLine(auxiliar);
        if (auxiliar.Equals("No alcanza la tinta"))
        {
          Console.WriteLine("Queres recargar? s o n");
          if(Console.ReadLine().Equals("s"))
          {
            azul.Recargar();
            rojo.Recargar();
          }else
          {
            break;
          }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Escribir otra vez? s o n");
        escribir = Console.ReadLine().ToString();
        Console.Clear();       
      } while (escribir != "n");
    }
  }
}
