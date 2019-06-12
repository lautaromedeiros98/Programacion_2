using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_06_2019.FRM
{
  public partial class FrmListado : Form
  {
    private List<Persona> _personas;
    private DataTable _tabla;

    public FrmListado()
    {
      InitializeComponent();
    }

    private void FrmListado_Load(object sender, EventArgs e)
    {
      AccesoDatos acc = new AccesoDatos();
      _personas = acc.TraerTodos();
      _tabla = acc.TraerTablaPersonas();
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.DataSource = _personas;
      //_personas = acc.TraerTodos();
    }
  }
}
