using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_06_2019
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
      this.Load += new System.EventHandler(this.Inicializar);
    }

    public void Inicializar(object obj, EventArgs e)
    {
      this.btnBoton1.Click += MiManejador;
      this.button1.Click += Operar;
    }

    public void MiManejador(object obj ,EventArgs e)//<- es un manejador
    {
      if (obj is Button)
      {
        if (((Button)obj).Name == this.btnBoton1.Name)
        {
          this.btnBoton2.Click += MiManejador;
          this.btnBoton1.Click -= MiManejador;
        }
        if (((Button)obj).Name == this.btnBoton2.Name)
        {
          this.btnBoton3.Click += MiManejador;
          this.btnBoton2.Click -= MiManejador;
        }
        if (((Button)obj).Name == this.btnBoton3.Name)
        {
          this.btnBoton1.Click += MiManejador;
          this.btnBoton3.Click -= MiManejador;
        }
      }
      MessageBox.Show(((Button)obj).Name);
    }

    private void Operar(object sender, EventArgs e)
    {
      Manejadora a = new Manejadora();

      MiDelegado delegado = new MiDelegado(Manejadora.Sumar);
      MiDelegado delegado2 = new MiDelegado(a.Restar);
      MiDelegado delegado3 = (MiDelegado)MiDelegado.Combine(delegado, delegado2);
      MiDelegado delegado4 = (MiDelegado)MiDelegado.Combine(delegado3,new MiDelegado(a.Multiplicar));

      delegado4.Invoke(3, 3);
    }
  }
}
