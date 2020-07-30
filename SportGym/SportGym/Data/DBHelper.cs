using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGym.Data
{
    //      La clase BDHelper ,permite quitar del código del formulario y de los DAO todo lo relacionado con el acceso a bd.
    //      Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    //      Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        private readonly string notebook = "Data Source=Notebook-pc;Initial Catalog=DB_Sport_Gym;Integrated Security=True";
        //private readonly string pc = "";

        private DBHelper()
        {
            string_conexion = notebook;
        }

        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }
        public int ejecutarSQL(string strSql)
        {
            int afectadas = 0;

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }
        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }
        

        
        public DataTable ejecutarStoredProcedureConParametros(string sp, SqlParameter[] sqlParameters)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Parameters.AddRange(sqlParameters);
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }
        public DataTable ejecutarStoredProcedureConUnParametro(string sp, SqlParameter parametro)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Parameters.Add(parametro);
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }
        public DataTable ejecutarStoredProcedure(string sp)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }
       
    }
}
