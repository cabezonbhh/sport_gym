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
    public class DAO_Cuota : IDAO_Cuota<Cuota>
    {
        DBHelper helper = DBHelper.getDBHelper();

        public bool actualizarCuota(int nroCuota, double monto, DateTime inicio, DateTime fin)
        {
            string sp = "sp_actualizar_datos_cuota";
            SqlParameter[] parametros = new SqlParameter[4];

            var param1 = new SqlParameter("@codCuota", nroCuota);
            param1.SqlDbType = SqlDbType.Int;

            var param2 = new SqlParameter("@fechaInicio", inicio);
            param2.SqlDbType = SqlDbType.Date;

            var param3 = new SqlParameter("@fechaFin", fin);
            param3.SqlDbType = SqlDbType.Date;

            var param4 = new SqlParameter("@monto", monto);
            param4.SqlDbType = SqlDbType.Float;

            parametros[0] = param1;
            parametros[1] = param2;
            parametros[2] = param3;
            parametros[3] = param4;

            return helper.ejecutarStoredProcedureConParametros(sp,parametros) == 1;
        }

        public IList<Cuota> getCuotas(int inscripcion)
        {
            string sp = "sp_listar_cuotas_por_inscripcion";
            var parametro = new SqlParameter("@codInscripcion", inscripcion);
            parametro.SqlDbType = SqlDbType.Int;

            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp,parametro);
            IList<Cuota> listaCuotas = new List<Cuota>();
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaCuotas.Add(mapper(fila));
                }
            }
            return listaCuotas;
        }
        public IList<Cuota> getCuotasPorSocio(int nro)
        {
            string sp = "cuotas_por_socio";
            var parametro = new SqlParameter("@nro", nro);
            parametro.SqlDbType = SqlDbType.Int;

            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            IList<Cuota> listaCuotas = new List<Cuota>();
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaCuotas.Add(mapper(fila));
                }
            }
            return listaCuotas;
        }

        public Cuota getUltimaCuotaPorInscripcion(int nro)
        {
            Cuota cuota = null;
            string sp = "sp_ultimo_pago_por_inscripcion";
            var parametro = new SqlParameter("@cod", nro);
            parametro.SqlDbType = SqlDbType.Int;

            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    cuota = mapper(fila);
                }
            }
            return cuota;
        }

        public bool registrarCuota(int nroSocio, int nroInscripcion,Double monto, DateTime inicio, DateTime fin)
        {
            string sp = "sp_registrar_cuota";//nombre del stored procedure en la BD

            SqlParameter []parametros = new SqlParameter[4];//creacion de la lista de parametros para el SP


            var param1 = new SqlParameter("inscripcion", nroInscripcion);// variable que va dentro la lista de parametros para el sp. Se pone el nombre del
                                                                            // parametro
            param1.SqlDbType = SqlDbType.Int; //aca se indica el tipo de dato que tiene la columna en la BD.
            parametros[0] = param1;// agrego el parametro al array, hay que respetar el orden en el que el SP recibe los parametros.

            var param2 = new SqlParameter("monto", monto);
            param2.SqlDbType = SqlDbType.Float;
            parametros[1] = param2;

            var param3 = new SqlParameter("inicio", fin);
            param3.SqlDbType = SqlDbType.DateTime;
            parametros[2] = param3;

            var param4 = new SqlParameter("fin", fin);
            param4.SqlDbType = SqlDbType.DateTime;
            parametros[3] = param4;

            return helper.ejecutarStoredProcedureConParametros(sp, parametros) > 0;
        }

        private Cuota mapper(DataRow fila)
        {
            Cuota cuota = new Cuota();
            cuota.NroCuota = Convert.ToInt32(fila[0]);
            cuota.FechaPago = Convert.ToDateTime(fila[1]);
            cuota.FechaInicio = Convert.ToDateTime(fila[2]); ;
            cuota.FechaFin = Convert.ToDateTime(fila[3]); 
            cuota.Monto = Convert.ToDouble(fila[4]);
            cuota.CodInscripcion = Convert.ToInt32(fila[5]);
            return cuota;
        }
    }
}
