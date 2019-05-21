using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio02";

            Console.WriteLine("Ingrese un numero");
            int numeroIngresado = int.Parse(Console.ReadLine());
            if(numeroIngresado < 1)
            {
                Console.WriteLine("Error");
            }else
            {
                Console.WriteLine("El cuadrado del numero es : {0:#,###.00}\nEl cubo del numero es : {1:#,###.00}", Math.Pow(numeroIngresado, 2),Math.Pow(numeroIngresado,3));
            }
            Console.ReadKey();
        }
    }
}
