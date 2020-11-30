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
        private string string_conexion;//variable que voy usar para la cadena de conexion.
        private static DBHelper instance = new DBHelper(); // variable que almacena una instancia de esta misma clase para utilizar el patron singleton
        private readonly string cadena = "Data Source=(local);Initial Catalog=DB_Sport_Gym;Integrated Security=True"; //cadena de conexion

        private DBHelper() // constructor privado que va a ser llamado por el metodo getDBHelper(). Se utiliza para el patron singleton
        {
            string_conexion = cadena;
        }

        public static DBHelper getDBHelper()//metodo que devuelve la instancia unica.
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        private void CloseConnection(SqlConnection cnn) // metodo para cerrar la conexion
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }


        // consultarStoredProcedureConParametros(string sp, SqlParameter[] sqlParameters)
        //
        //      SP = stored procedure
        //
        //     Se utiliza para llamar a SP de la base de datos, del tipo SELECT, con mas de 1 parametro. 
        // Parametros:
        //      - Recibe un string con el nombre del SP.
        //      - Recibe un array del tipo SqlParameter, el cual contiene los parametros solicitados por el SP.
        //
        // Devuelve:
        //      Un DataTable con los registros de la base de datos.
        //
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.
        public DataTable consultarStoredProcedureConParametros(string sp, SqlParameter[] sqlParameters)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            if(!String.IsNullOrWhiteSpace(cadena))
            {
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
                    MessageBox.Show("Codigo 02: "+ "\n"+ ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
            }
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion", "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabla;
            }
        }


        // public DataTable consultarStoredProcedureConUnParametro(string sp, SqlParameter parametro)
        //
        //      SP = stored procedure
        //
        //     Se utiliza para llamar a SP de la base de datos, del tipo SELECT, con 1 parametro. 
        // Parametros:
        //      - Recibe un string con el nombre del SP.
        //      - Recibe un parametro del tipo SqlParameter.
        //
        // Devuelve:
        //      Un DataTable con los registros de la base de datos.
        //
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.
        public DataTable consultarStoredProcedureConUnParametro(string sp, SqlParameter parametro)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            if(!String.IsNullOrWhiteSpace(cadena))
            {
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
                    MessageBox.Show("Codigo 02: " + "\n" + ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
            }
            else
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion", "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabla;
            }
        }

        // public DataTable consultarStoredProcedure(string sp)
        //
        //      SP = stored procedure
        //
        //     Se utiliza para llamar a SP de la base de datos, del tipo SELECT, sin parametros. 
        // Parametros:
        //      - Recibe un string con el nombre del SP.
        //      
        // Devuelve:
        //      Un DataTable con los registros de la base de datos.
        //
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.
        public DataTable consultarStoredProcedure(string sp)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            if(!String.IsNullOrWhiteSpace(cadena))
            {
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
                    MessageBox.Show("Codigo 02: " + "\n" + ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
            }
            else
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion","Fallo critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return tabla;
            }

        }

        // public int ejecutarStoredProcedure(string sp)
        //
        //      SP = stored procedure
        //
        //     Se utiliza para llamar a SP de la base de datos, del tipo UPDATE o INSERT, sin parametro. 
        // Parametros:
        //      - Recibe un string con el nombre del SP.
        //
        // Devuelve:
        //      Un int con la cantidad de filas afectadas por el SP.
        //
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.
        public int ejecutarStoredProcedure(string sp)
        {
            int resultado = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;
         
            if(!String.IsNullOrWhiteSpace(cadena))
            {
                try
                {
                    cnn.ConnectionString = string_conexion;
                    cnn.Open();

                    transaction = cnn.BeginTransaction();

                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    cmd.Transaction = transaction;
                    resultado = cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Codigo 02: " + "\n" + ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
                return resultado;
            }
            else
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion", "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return resultado;
            }
        }

        // public int ejecutarStoredProcedureConUnParametro(string sp, SqlParameter parametro)
        //
        //      SP = stored procedure
        //
        //     Se utiliza para llamar a SP de la base de datos, del tipo UPDATE o INSERT, con 1 parametro. 
        // Parametros:
        //      - Recibe un string con el nombre del SP.
        //      - Recibe un parametro del tipo SqlParameter.
        //
        // Devuelve:
        //      Un int con la cantidad de filas afectadas por el SP.
        //
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public int ejecutarStoredProcedureConUnParametro(string sp, SqlParameter parametro)
        {
            int resultado = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;

            if(!String.IsNullOrWhiteSpace(cadena))
            {
                try
                {
                    cnn.ConnectionString = string_conexion;
                    cnn.Open();

                    transaction = cnn.BeginTransaction();

                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    cmd.Parameters.Add(parametro);
                    cmd.Transaction = transaction;
                    resultado = cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Codigo 02: " + "\n" + ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
                return resultado;
            }
            else
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion", "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return resultado;
            }
        }

        // public int ejecutarStoredProcedureConParametros(string sp, SqlParameter[] parametros)
        //
        //      SP = stored procedure
        //
        //     Se utiliza para llamar a SP de la base de datos, del tipo UPDATE o INSERT, con mas de 1 parametro. 
        // Parametros:
        //      - Recibe un string con el nombre del SP.
        //      - Recibe un array del tipo SqlParameter, el cual contiene los parametros solicitados por el SP.
        //
        // Devuelve:
        //      Un int con la cantidad de filas afectadas por el SP.
        //
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.
        public int ejecutarStoredProcedureConParametros(string sp, SqlParameter[] parametros)
        {
            int resultado = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;

            if(!String.IsNullOrWhiteSpace(cadena))
            {
                try
                {
                    cnn.ConnectionString = string_conexion;
                    cnn.Open();

                    transaction = cnn.BeginTransaction();

                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    cmd.Parameters.AddRange(parametros);
                    cmd.Transaction = transaction;
                    resultado = cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Codigo 02: " + "\n" + ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
                return resultado;
            }
            else
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion", "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return resultado;
            }
        }

        public int ejecutarStoredProcedureSinT(string sp)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            if (!String.IsNullOrWhiteSpace(cadena))
            {
                try
                {
                    cnn.ConnectionString = string_conexion;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Codigo 02: " + "\n" + ex.ToString(), "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    this.CloseConnection(cnn);
                }
                
            }
            else
            {
                MessageBox.Show("Codigo 01: Error con la cadena de conexion", "Fallo critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
