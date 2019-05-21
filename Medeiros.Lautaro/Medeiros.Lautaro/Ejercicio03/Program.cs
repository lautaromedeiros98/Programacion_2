using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio03";

            Console.WriteLine("Ingrese un limite hasta donde quiera mostrar numeros primos");
            int limiteIngresado = int.Parse(Console.ReadLine());
            for(int i=0;i<limiteIngresado;i++)
            {
                if((i%2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
