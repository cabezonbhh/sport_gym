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

        public IList<Cuota> getCuotas(int nroInscripcion)
        {
            Cuota cuota = new Cuota();

            string sp = "sp_listar_cuotas_por_inscripcion";
            var parametro = new SqlParameter("codInscripcion", nroInscripcion);
            parametro.SqlDbType = SqlDbType.Int;

            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp,parametro);
            IList<Cuota> listaCuotas = new List<Cuota>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaCuotas.Add(mapper(fila));
            }
            return listaCuotas;
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
