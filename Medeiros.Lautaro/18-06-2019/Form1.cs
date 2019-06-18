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
  public partial class Form1 : Form
  {
    private Manejadora manejador = new Manejadora();

    public Form1()
    {
      InitializeComponent();
      this.lblEtiqueta.Click += new System.EventHandler(manejador.Manejador2);
      this.txtCuadroTexto.Click += new System.EventHandler(manejador.Manejador2);
      this.btnBoton.Click += new System.EventHandler(manejador.Manejador2);
    }

    /*
    private void MostrarMensaje(object sender, EventArgs e)
    {
      MessageBox.Show("Boton presionado");      
    }

    private void MensajeLabel(object sender, EventArgs e)
    {
      MessageBox.Show("Label presionado");
      //this.lblEtiqueta.Click -= new System.EventHandler(this.MensajeLabel); <- saco el evento del manejador
    }

    private void txtCuadroTexto_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Text box presionado");
    }
    */
  }
}
