using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPaleta
{
  public partial class FrmPrincipal : Form
  {
    //agregar ocion de elegir la cantidad de temperas de la paleta
    public FrmPrincipal()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
      this.WindowState = FormWindowState.Maximized;
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
        if((MessageBox.Show("Desea salir", "Seguro?", MessageBoxButtons.OKCancel)==DialogResult.Yes))
        {
          e.Cancel=true;
        }
    }

    private void toolStripComboBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
