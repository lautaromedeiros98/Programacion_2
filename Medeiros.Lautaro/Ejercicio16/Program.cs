using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Ejercicio16
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumnoUno = new Alumno("juan", "papusa", 1234);
      Alumno alumnoDos = new Alumno("Pedrito", "fafafa", 9874);

      alumnoUno.Estudiar(1, 9);
      alumnoDos.Estudiar(8, 8);

      Console.WriteLine(alumnoUno.Mostrar());
    }
  }
}
