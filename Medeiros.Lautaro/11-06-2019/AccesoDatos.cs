using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _11_06_2019
{
  public class AccesoDatos
  {
    private SqlConnection _conexion;

    public AccesoDatos()
    {
      _conexion = new SqlConnection(Properties.Settings.Default.Conexion_BDD);
    }
  }
}
