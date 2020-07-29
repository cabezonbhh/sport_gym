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
        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public DataTable getSocios()
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
                cmd.CommandText = "sp_listar_socios_activos";
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
        public DataTable getInscripcion(int nroSocio)
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
                cmd.CommandText = "sp_get_inscripcion_socio";
                cmd.Parameters.AddWithValue("nroSocio",nroSocio);
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
        public DataTable getCuotas(int inscripcion)
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
                cmd.CommandText = "sp_listar_cuotas_por_inscripcion";
                cmd.Parameters.AddWithValue("codInscripcion",inscripcion);
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
        public DataTable getInscripciones()
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
                cmd.CommandText = "sp_listar_inscripciones_activas";
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
