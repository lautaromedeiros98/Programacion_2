using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Jorge","Jorgito");
            Persona p;
            if(per.SerializarXml())
            {
                Console.WriteLine("Se pudo");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }
            Console.ReadKey();
            p =(Persona) per.Deserializar();
            Console.WriteLine(p.ToString());
            Console.ReadKey(); 
        }
    }
}
