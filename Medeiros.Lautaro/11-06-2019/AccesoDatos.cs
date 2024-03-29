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
    private SqlCommand _comando;
    private SqlDataReader _reader;

    public AccesoDatos()
    {
      _conexion = new SqlConnection(Properties.Settings.Default.Conexion_BDD);
    }

    public bool AgregarPersona(Persona p)
    {
      _comando = new SqlCommand();
      
      _comando.Connection = _conexion;
      _comando.CommandType = CommandType.Text;
      _comando.CommandText = "INSERT INTO Padron.dbo.Personas(nombre,apellido,edad) values('"+p.Nombre+"','"+p.Apellido+"','"+p.Edad.ToString()+"')";
      try
      {
        _conexion.Open();
        if (_comando.ExecuteNonQuery()>0)
        {
          return true;
        }
        return false;
      }
      catch(Exception a)
      {
        Console.WriteLine(a.Message);
        return false;
      }
      finally
      {
        _conexion.Close();
      }
    }

    public List<Persona> TraerTodos()
    {
      _comando = new SqlCommand();
      _comando.Connection = _conexion;
      _comando.CommandType = CommandType.Text;
      _comando.CommandText= "SELECT * FROM Padron.dbo.Personas";
      List<Persona> retorno = new List<Persona>();
      try
      {
        _conexion.Open();
        _reader=_comando.ExecuteReader();
        while (_reader.Read())
        {
          Persona p = new Persona((int)_reader["id"], (string)_reader["nombre"], (string)_reader["apellido"], (int)_reader["edad"]);
          retorno.Add(p);
        }
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        _conexion.Close();
      }
      return retorno;
    }

    public bool ModificarPersona(Persona p)
    {
      _comando = new SqlCommand();
      _comando.Connection = _conexion;
      _comando.CommandType = CommandType.Text;
      _comando.CommandText = "UPDATE Padron.dbo.Personas SET nombre='"+p.Nombre+"', apellido='"+p.Apellido+"',edad="+p.Edad+" WHERE id="+p.Id;
      try
      {
        _conexion.Open();
        if (_comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
        return false;
      }
      catch (Exception a)
      {
        Console.WriteLine(a.Message);
        return false;
      }
      finally
      {
        _conexion.Close();
      }
    }

    public bool EliminarPersona(int id)
    {
      _comando = new SqlCommand();
      _comando.Connection = _conexion;
      _comando.CommandType = CommandType.Text;
      _comando.CommandText="DELETE FROM Padron.dbo.Personas WHERE id="+id;
      try
      {
        _conexion.Open();
        if (_comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
        return false;
      }
      catch (Exception a)
      {
        Console.WriteLine(a.Message);
        return false;
      }
      finally
      {
        _conexion.Close();
      }
    }

    public DataTable TraerTablaPersonas()
    {
      DataTable dt = new DataTable("Personas");
      _comando = new SqlCommand();
      _comando.Connection = _conexion;
      _comando.CommandType = CommandType.Text;
      _comando.CommandText = "SELECT * FROM Padron.dbo.Personas";
      try
      {
        _conexion.Open();
        _reader = _comando.ExecuteReader();
        dt.Load(_reader);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        _conexion.Close();
      }
      return dt;
    }
  }
}
