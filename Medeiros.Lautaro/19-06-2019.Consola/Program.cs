using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
using System.IO;

namespace _19_06_2019.Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Empleado a = new Empleado();
      Program p = new Program();
      /*el atributo _limiteSueldo es el evento ->*/a._limiteSueldo += new DelegadoSueldo(limiteSueldoEmpleado);//Se le asigna al evento un manejador CON UN PUNTERO A FUNCION 
      a._limiteSueldo += new DelegadoSueldo(p.GuardarLog);
      a.Nombre = "Pepe";
      a.Legajo = 107309;
      a.Sueldo = 12001;
      Console.WriteLine("\n" + a.ToString());
      Console.ReadKey();
    }

    private static void limiteSueldoEmpleado(Empleado e,float f)//Evento manejador , no importa la ubicacion
    {
      Console.WriteLine("Empleado: " + e.Nombre + " Legajo: " + e.Legajo + "\nSueldo que se le quiso asignar: " + f);
    }

    public void GuardarLog(Empleado e,float f)
    {
      StreamWriter writer = new StreamWriter("empleado.log", true);
      writer.WriteLine(DateTime.Now+ " " + "Empleado: " + e.Nombre + " Legajo: " + e.Legajo +" Sueldo que se le quiso asignar: " + f);
      writer.Close();
    }//fecha,hora,minutos,segundos,nombre y legajo + sueldo que se intento asignar 
  }
}
