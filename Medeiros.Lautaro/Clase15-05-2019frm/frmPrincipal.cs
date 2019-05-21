using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;
using System.IO;//Clases para entrada y salida

namespace Clase15_05_2019frm
{
  public partial class frmPrincipal : Form
  {
    private StreamWriter writer;
    private StreamReader reader;
    private OpenFileDialog opFile;
    private bool buscador = false;
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      try
      {
        if(buscador)
        {
          this.writer = new StreamWriter(this.opFile.FileName, true);
          this.writer.WriteLine(this.txtValor.Text);
          this.writer.Close();
        }
        else
        {
          MessageBox.Show("no hay archivo seleccionado para escribir");
        }
      }
      catch(Exception e2)
      {
        MessageBox.Show(e2.Message);
      }
    }

    private void btnTraer_Click(object sender, EventArgs e)
    {
      this.lstVisor.Items.Clear();
      string l="";
      try
      {
        if(buscador)
        {
          this.reader = new StreamReader(this.opFile.FileName);
          while (((l = reader.ReadLine()) != null))
          {
            this.lstVisor.Items.Add(l);
          }
          reader.Close();
        }
        else
        {
          MessageBox.Show("No hay archivo seleccionado");
        }
      }
      catch(Exception asd)
      {
        MessageBox.Show(asd.Message);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if(opFile.ShowDialog()==DialogResult.OK)
      {
        MessageBox.Show(opFile.FileName);
        this.buscador = true;     
      }
    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      this.opFile = new OpenFileDialog();
      this.opFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      this.opFile.Title = "Seleccione un archivo donde escribir";
      this.opFile.Multiselect = false;
      this.opFile.DefaultExt = ".txt";
      this.opFile.AddExtension = true;
      this.opFile.Filter = "Archivos (*.txt) | *.TXT";
    }
  }
}
