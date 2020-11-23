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
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaSocios.Add(mapper(fila));
                }               
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
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    socio = mapper(fila);
                }                
            }
            return socio;
        }

        public IList<Socio> getSocios()
        {
            DataTable tabla = helper.consultarStoredProcedure("sp_listar_socios_activos");

            IList<Socio>listaSocios = new List<Socio>();
            
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaSocios.Add(mapper(fila));
                }                
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
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaSocios.Add(mapper(fila));
                }
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
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaSocios.Add(mapper(fila));
                }
            }
            return listaSocios;
        }

        public int modificarSocio(Socio socio)
        {
            string sp = "sp_modificar_socio";
            SqlParameter[] parametros = new SqlParameter[9];

            var param1 = new SqlParameter("@nroSocio", socio.NumeroSocio);
            param1.SqlDbType = SqlDbType.Int;
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

            var param8 = new SqlParameter("@horaInicio", socio.HoraInicio);
            param8.SqlDbType = SqlDbType.VarChar;
            parametros[7] = param8;

            var param9 = new SqlParameter("@horaFin", socio.HoraFin);
            param9.SqlDbType = SqlDbType.VarChar;
            parametros[8] = param9;

            return helper.ejecutarStoredProcedureConParametros(sp, parametros);
        }

        public int registrarSocio(Socio socio)
        {
            string sp = "sp_registrar_socio";
            SqlParameter[] parametros = new SqlParameter[8];

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

            var param7 = new SqlParameter("@horaInicio", socio.HoraInicio);
            param7.SqlDbType = SqlDbType.VarChar;
            parametros[6] = param7;

            var param8 = new SqlParameter("@horaFin", socio.HoraFin);
            param8.SqlDbType = SqlDbType.VarChar ;
            parametros[7] = param8;

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
            socio.HoraInicio = fila[8].ToString();
            socio.HoraFin = fila[9].ToString();
            socio.Inscripcion = dao.getInscripcionActiva(socio.NumeroSocio);
            return socio;
        }

        public IList<Socio> getSocioPorHorario(string inicio, string fin)
        {
            string sp = "sp_listar_socios_por_hora";
            SqlParameter[] parametros = new SqlParameter[2];

            var parametro = new SqlParameter("@horaInicio", inicio);
            parametro.SqlDbType = SqlDbType.VarChar;
            parametros[0] = parametro;

            var parametro2 = new SqlParameter("@horaFin", fin);
            parametro2.SqlDbType = SqlDbType.VarChar;
            parametros[1] = parametro2;

            IList<Socio> listaSocios = new List<Socio>();
            DataTable tabla = helper.consultarStoredProcedureConParametros(sp, parametros);
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaSocios.Add(mapper(fila));
                }
            }
            return listaSocios;
        }

        public int registrarSocioConPago(Socio socio, double monto, DateTime inicio, DateTime fin)
        {
            string sp = "sp_registrar_socio_con_pago";
            SqlParameter[] parametros = new SqlParameter[11];

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

            var param7 = new SqlParameter("@horaInicio", socio.HoraInicio);
            param7.SqlDbType = SqlDbType.VarChar;
            parametros[6] = param7;

            var param8 = new SqlParameter("@horaFin", socio.HoraFin);
            param8.SqlDbType = SqlDbType.VarChar;
            parametros[7] = param8;

            var param9 = new SqlParameter("@inicio", inicio);
            param9.SqlDbType = SqlDbType.Date;
            parametros[8] = param9;

            var param10 = new SqlParameter("@fin", fin);
            param10.SqlDbType = SqlDbType.Date;
            parametros[9] = param10;

            var param11= new SqlParameter("@monto", monto);
            param11.SqlDbType = SqlDbType.Float;
            parametros[10] = param11;


            return helper.ejecutarStoredProcedureConParametros(sp, parametros);
        }
    }
}
