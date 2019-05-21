using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase04.Entidades;

namespace Clase04.WindowsForm
{
  public partial class FrmCosa : Form
  {
    public FrmCosa()
    {
      InitializeComponent();
    }

    private void FrmCosa_Load(object sender, EventArgs e)
    {
    }

    private void FrmCosa_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Cosa cosa = new Cosa(10,DateTime.Now,"Juansito");
      MessageBox.Show(cosa.Mostrar());
      button1.Text = "Crear otra cosa";
      button1.BackColor = Color.MediumPurple;
    }
  }
}
