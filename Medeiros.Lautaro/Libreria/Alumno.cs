using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
  public class Alumno
  {
    private byte nota1;
    private byte nota2;
    private float notaFinal;
    public string apellido;
    public int legajo;
    public string nombre;

    public Alumno(string nombre,string apellido,int legajo)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.legajo = legajo;
    }

    public void Estudiar(byte nota1,byte nota2)
    {
      this.nota1 = nota1;
      this.nota2 = nota2;
    }

    public void CalcularFinal()
    {
      Random random = new Random();
      if (this.nota1 >= 4 && this.nota2 >= 4)
      {
        this.notaFinal = random.Next(4, 10);
      }else
      {
        this.notaFinal = -1;
      }
    }

    public string Mostrar()
    {
      StringBuilder retorno = new StringBuilder();
      retorno.AppendLine("Nombre: " + this.nombre);
      retorno.AppendLine("Apellido: " + this.apellido);
      retorno.AppendLine("Legajo: " + this.legajo);
      retorno.AppendLine("Notas: " + this.nota1 + " y " + this.nota2);
      if(this.notaFinal>-1)
      {
        retorno.AppendLine("Nota final: " + this.notaFinal);
      }else
      {
        retorno.AppendLine("Alumnbo desaprobado");
      }
      return retorno.ToString();
    }
  }
}
