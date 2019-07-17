using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql: IArchivo<Queue<Patente>>
    {
        #region Atributos
        private SqlConnection conexion;
        private SqlCommand comando;
        #endregion

        #region Constructores
        public Sql()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=patentes-sp-2018;Integrated Security=True");
            // CREO UN OBJETO SQLCOMMAND
            this.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            this.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            this.comando.Connection = this.conexion;
        }
        #endregion

        #region Métodos

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            //string sql = "INSERT INTO " + tabla + " (patente,tipo) VALUES";
            //foreach (Patente p in datos)
            //{
            //    sql = sql + "('" + p.CodigoPatente + "','" + p.TipoCodigo.ToString() + "'),";
            //}
            string sql = "INSERT INTO " + tabla + " (patente,tipo) ";
            foreach (Patente p in datos)
            {
                sql = sql + "SELECT '" + p.CodigoPatente + "','" + p.TipoCodigo.ToString() + "' UNION ALL ";
            }

            try
            {
                sql = sql.Substring(0, sql.Length - 11);
                // LE PASO LA INSTRUCCION SQL
                this.comando.CommandText = sql;
                // ABRO LA CONEXION A LA BD
                this.conexion.Open();
                // EJECUTO EL COMMAND
                this.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                    this.conexion.Close();
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this.comando.CommandText = "SELECT patente,tipo FROM " + tabla;
                // ABRO LA CONEXION A LA BD
                this.conexion.Open();
                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this.comando.ExecuteReader();
                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    datos.Enqueue(new Patente(oDr["patente"].ToString(), (Patente.Tipo)Enum.Parse(typeof(Patente.Tipo), oDr["tipo"].ToString())));
                }

                //CIERRO EL DATAREADER
                oDr.Close();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                    this.conexion.Close();
            }
        }

        #endregion
    }
}
