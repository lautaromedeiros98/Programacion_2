using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_06_2019
{
  public class Manejadora
  {    
    public static void Manejador(object obj , EventArgs e)//<-siempre la misma firma y en obj esta la instancia del objeto que provoco el evento
    {
      MessageBox.Show("Estoy en el manejador");
    }

    public void Manejador2(object obj, EventArgs e)
    {
      MessageBox.Show("Estoy en el metodo de instancia");
      if(obj is TextBox)
      {
        MessageBox.Show("El evento fue provocado por un textbox");
      }
      else
      {
        if(obj is Label)
        {
          MessageBox.Show("El evento fue provocado por un label");
        }
        else
        {
          MessageBox.Show("El evento fue provocado por un boton");
        }
      }
    }

    public static void Sumar(int a,int b)
    {
      MessageBox.Show((a + b).ToString());
    }

    public void Restar(int a,int b)
    {
      MessageBox.Show((a - b).ToString());
    }

    public void Multiplicar(int a,int b)
    {
      MessageBox.Show((a * b).ToString());
    }
  }
}
