using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            int numero;
            double promedio=0;
            Console.WriteLine("Ingrese 5 numeros");
            numero = int.Parse(Console.ReadLine());
            int maximo = numero;
            int minimo = numero;
            promedio += numero;
            for(int i=0;i<4;i++)
            {
                numero = int.Parse(Console.ReadLine());
                if(numero<minimo)
                {
                    minimo = numero;
                }

                if(numero>maximo)
                {
                    maximo = numero;
                }
                promedio += numero;
            }

            Console.WriteLine("El numero maximo es: {0:#,###.00} \n El numero minimo es {1:#,###.00} \n El promedio de los numeros es : {2:#,###.00}", maximo,minimo,promedio/5);
            Console.ReadKey();
        }
    }
}
