using SportGym.Business;
using SportGym.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Data
{
    public class DAO_Socio : IDAO_Socio<Socio>
    {
        DBHelper helper = DBHelper.getDBHelper();

        public int darBajaSocio(int socio)
        {
            string sp = "sp_baja_socio";
            var parametro = new SqlParameter("@nroSocio", socio);
            parametro.SqlDbType = SqlDbType.Int;
            return helper.ejecutarStoredProcedureConUnParametro(sp,parametro);
        }

        public IList<Socio> getSocioPorDNI(string dni)
        {
            string sp = "listar_socios_por_dni";
            var parametro = new SqlParameter("@dni", dni);
            parametro.SqlDbType = SqlDbType.VarChar;

            IList<Socio> listaSocios = new List<Socio>();
            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            foreach (DataRow fila in tabla.Rows)
            {
                listaSocios.Add(mapper(fila));
            }
            return listaSocios;
        }
        public bool existeSocioConDni(string dni)
        {
            string sp = "listar_socios_por_dni";
            var parametro = new SqlParameter("@dni", dni);
            parametro.SqlDbType = SqlDbType.VarChar;

            IList<Socio> listaSocios = new List<Socio>();
            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            if (tabla != null)
                return tabla.Rows.Count > 0;
            else
                return false; 
        }

        public Socio getSocioPorNumero(int nro)
        {
            string sp = "listar_socios_por_nroSocio";
            var parametro = new SqlParameter("@id", nro);
            parametro.SqlDbType = SqlDbType.Int;
            Socio socio = new Socio();

            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            foreach (DataRow fila in tabla.Rows)
            {
                socio = mapper(fila);
            }
            return socio;
        }

        public IList<Socio> getSocios()
        {
            DataTable tabla = helper.consultarStoredProcedure("sp_listar_socios_activos");

            IList<Socio>listaSocios = new List<Socio>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaSocios.Add(mapper(fila));
            }
            return listaSocios;
        }

        public IList<Socio> getSociosPorApellido(string apellido)
        {
            string sp = "listar_socios_por_apellido";
            var parametro = new SqlParameter("@apellido", apellido);
            parametro.SqlDbType = SqlDbType.VarChar;

            IList<Socio> listaSocios = new List<Socio>();
            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            foreach (DataRow fila in tabla.Rows)
            {
                listaSocios.Add(mapper(fila));
            }
            return listaSocios;
        }

        public IList<Socio> getSociosPorNombre(string nombre)
        {
            string sp = "listar_socios_por_nombre";
            var parametro = new SqlParameter("@nombre", nombre);
            parametro.SqlDbType = SqlDbType.VarChar;

            IList<Socio> listaSocios = new List<Socio>();
            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            foreach (DataRow fila in tabla.Rows)
            {
                listaSocios.Add(mapper(fila));
            }
            return listaSocios;
        }

        public int modificarSocio(Socio socio)
        {
            string sp = "sp_modificar_socio";
            SqlParameter[] parametros = new SqlParameter[7];

            var param1 = new SqlParameter("@nroSocio", socio.NumeroSocio);
            param1.SqlDbType = SqlDbType.VarChar;
            parametros[0] = param1;

            var param2 = new SqlParameter("@nombre", socio.Nombre);
            param1.SqlDbType = SqlDbType.VarChar;
            parametros[1] = param2;

            var param3 = new SqlParameter("@apellido", socio.Apellido);
            param2.SqlDbType = SqlDbType.VarChar;
            parametros[2] = param3;

            var param4 = new SqlParameter("@email", socio.Email);
            param3.SqlDbType = SqlDbType.VarChar;
            parametros[3] = param4;

            var param5 = new SqlParameter("@telefono", socio.Telefono);
            param4.SqlDbType = SqlDbType.VarChar;
            parametros[4] = param5;

            var param6= new SqlParameter("@celular", socio.Celular);
            param5.SqlDbType = SqlDbType.VarChar;
            parametros[5] = param6;

            var param7= new SqlParameter("@dni", socio.Dni);
            param6.SqlDbType = SqlDbType.VarChar;
            parametros[6] = param7;

            return helper.ejecutarStoredProcedureConParametros(sp, parametros);
        }

        public int registrarSocio(Socio socio)
        {
            string sp = "sp_registrar_socio";
            SqlParameter[] parametros = new SqlParameter[6];

            var param1 = new SqlParameter("@nombre", socio.Nombre);
            param1.SqlDbType = SqlDbType.VarChar;
            parametros[0] = param1;

            var param2 = new SqlParameter("@apellido", socio.Apellido);
            param2.SqlDbType = SqlDbType.VarChar;
            parametros[1] = param2;

            var param3 = new SqlParameter("@email", socio.Email);
            param3.SqlDbType = SqlDbType.VarChar;
            parametros[2] = param3;

            var param4 = new SqlParameter("@telefono", socio.Telefono);
            param4.SqlDbType = SqlDbType.VarChar;
            parametros[3] = param4;

            var param5 = new SqlParameter("@celular", socio.Celular);
            param5.SqlDbType = SqlDbType.VarChar;
            parametros[4] = param5;

            var param6 = new SqlParameter("@dni", socio.Dni);
            param6.SqlDbType = SqlDbType.VarChar;
            parametros[5] = param6;

            return helper.ejecutarStoredProcedureConParametros(sp,parametros);
        }

        private Socio mapper(DataRow fila)
        {
            DAO_Inscripcion dao = new DAO_Inscripcion();
            Socio socio = new Socio();
            socio.NumeroSocio = Convert.ToInt32(fila[0].ToString());
            socio.Nombre = fila[1].ToString();
            socio.Apellido = fila[2].ToString();
            socio.Email = fila[3].ToString();
            socio.Telefono = fila[4].ToString();
            socio.Celular = fila[5].ToString();
            socio.Dni = fila[6].ToString();
            socio.Inscripcion = dao.getInscripcionActiva(socio.NumeroSocio);
            return socio;
        }
    }
}
