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
using System.IO;

namespace _19_06_2019.Frm
{
  public partial class Form1 : Form
  {
    private EmpleadoMejorado empleado;

    public Form1()
    {
      InitializeComponent();
      CargarCombo();
    }

    public void CargarCombo()
    {
      foreach (EManejador item in Enum.GetValues(typeof(EManejador)))
      {
        comboBox1.Items.Add(item);
      }
    }

    public void EmpleadoMejorado_limiteSueldo(EmpleadoMejorado e,EmpleadoSueldoArgs esa)
    {
      MessageBox.Show("Empleado: " + e.Nombre + " Legajo: " + e.Legajo + "\nSueldo que se le quiso asignar: " + esa.Sueldo);
    }

    public void EmpleadoMejorado_log_LimiteSueldo(EmpleadoMejorado e,EmpleadoSueldoArgs esa)
    {
      StreamWriter writer = new StreamWriter("empleadoMejorado.log", true);
      writer.WriteLine(DateTime.Now + " " + "Empleado: " + e.Nombre + " Legajo: " + e.Legajo + " Sueldo que se le quiso asignar: " + esa.Sueldo);
      writer.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      empleado = new EmpleadoMejorado();

      if (this.comboBox1.SelectedItem.Equals(EManejador.LimiteSueldo))
      {
        this.empleado._limiteSueldo += EmpleadoMejorado_limiteSueldo;
      }
      else
      {
        if (this.comboBox1.SelectedItem.Equals(EManejador.Log))
        {
          this.empleado._limiteSueldo += EmpleadoMejorado_log_LimiteSueldo;
        }
        else
        {
          this.empleado._limiteSueldo += EmpleadoMejorado_limiteSueldo;
          this.empleado._limiteSueldo += EmpleadoMejorado_log_LimiteSueldo;
        }
      }

      empleado.Nombre = textBox1.Text;
      empleado.Legajo = int.Parse(textBox2.Text);
      empleado.Sueldo = float.Parse(textBox3.Text);
    }
  }
}
