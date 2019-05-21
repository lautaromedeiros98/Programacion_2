using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase6.Entidades;

namespace FrmPaleta
{
  public partial class FrmTempera : Form
  {
    private Tempera a;
    private bool flag = true;

    public Tempera Tempera
    {
      get
      {
        return this.a;
      }
    }

    public FrmTempera()
    {
      InitializeComponent();
      foreach(ConsoleColor a in Enum.GetValues(typeof(ConsoleColor)))
      {
        cmbColor.Items.Add(a);
      }
    }

    public FrmTempera(Tempera aux)
    {
      InitializeComponent();
      string[] mostrarSeparado = Tempera.Mostrar(aux).Split('-');
      this.txtMarca.Text = mostrarSeparado[1];
      this.txtCantidad.Text = mostrarSeparado[2];
      this.cmbColor.Items.Add(mostrarSeparado[0]);
      this.cmbColor.Text = aux.Color.ToString();
      this.flag = false;
    }


    public FrmTempera FormTempera
      {
        get
       {
        return this;
        }
      }

  private void btnAceptar_Click(object sender, EventArgs e)
    {
      if(flag)
      {
        if (Equals(cmbColor.SelectedItem, null) || Equals(txtMarca.Text, null) || Equals(txtCantidad.Text, null))
        {
          this.DialogResult = DialogResult.Cancel;
        }
        else
        {
          if(!Equals(txtMarca.Text,"") && !Equals(txtCantidad.Text,""))
          {
            if (int.Parse(txtCantidad.Text) < sbyte.MaxValue && int.Parse(txtCantidad.Text) > sbyte.MinValue)
            {
              Tempera nuevaTempera = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, txtMarca.Text, sbyte.Parse(txtCantidad.Text));
              this.a = nuevaTempera;
              this.DialogResult = DialogResult.OK;
            }
            else
            {
              this.DialogResult = DialogResult.Cancel;
              MessageBox.Show("Ingrese una cantidad entre : -128 y 127");
            }
          }
        }
      }
      else
      {
        if ((!Equals(cmbColor.SelectedItem, a.Color) || !Equals(txtMarca.Text, a.Marca) || !Equals(txtCantidad.Text, a.CantidadMaxima)))
        {
          a.Color = (ConsoleColor)cmbColor.SelectedItem;
          a.CantidadMaxima = sbyte.Parse(txtCantidad.Text);
          a.Marca = txtMarca.Text;
        }
        this.DialogResult = DialogResult.OK;
      }
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void FrmTempera_Load(object sender, EventArgs e)
    {

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
