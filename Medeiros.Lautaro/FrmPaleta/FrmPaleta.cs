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
  public partial class FrmPaleta : Form
  {
    private Paleta p;//Hacerlo todo con listas

    public Paleta Paleta
    {
      get
      {
        return this.p;
      }
      set
      {
        this.p = value;
      }
    }

    public FrmPaleta(int cantidad)
    {
      InitializeComponent();
      p = cantidad;
    }

    private void btnMas_Click_1(object sender, EventArgs e)
    {
      FrmTempera a = new FrmTempera();
      a.ShowDialog();
      if(a.DialogResult == DialogResult.OK)
      { 
        p += a.Tempera;
      }
      ActualizarLstBox();
    }

    private void FrmPaleta_Load(object sender, EventArgs e)
    {
      
    }

    private void ActualizarLstBox()
    {
      lstLista.Items.Clear();
      foreach (Tempera i in p.Temperas)
      {
        lstLista.Items.Add(Tempera.Mostrar(i));
      }
    }

    private void btnMenos_Click(object sender, EventArgs e)
    {
      int auxiliar = lstLista.SelectedIndex;
      if(auxiliar >=0)
      {
        Tempera auxT = p.Temperas[auxiliar];
        FrmTempera a = new FrmTempera(auxT);
        a.ShowDialog();
        if (a.DialogResult == DialogResult.OK)
        {
          p -= auxT;
        }
        this.ActualizarLstBox();
      }
    }

    private void lstLista_DoubleClick(object sender, EventArgs e)
    {
      int auxiliar = lstLista.SelectedIndex;
      if(auxiliar >=0)
      {
        Tempera auxT1 = p.Temperas[auxiliar];
        FrmTempera a = new FrmTempera(auxT1);
        a.ShowDialog();
        if(a.DialogResult == DialogResult.OK)
        {
          p -= p.Temperas[auxiliar];
          p += a.Tempera;
        }
      }
    }
  }
}
