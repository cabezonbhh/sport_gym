using SportGym.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Data.DAO
{
    public class DAO_Estadisticas : IDAO_Estadisticas
    {
        DBHelper helper = DBHelper.getDBHelper();
        public int getCuotasVencidas()
        {
            string sp = "sp_listar_socios_con_cuota_vencida";
            DataTable tabla = helper.consultarStoredProcedure(sp);
            if (tabla != null)
                return tabla.Rows.Count;
            else
                return 0;
        }

        public double getIngresosEstimados()
        {
            string sp = "sp_ingresos_esperados_por_mes";
            double acumulador = 0;
            DataTable tabla = helper.consultarStoredProcedure(sp);
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    acumulador += Convert.ToDouble(fila[0].ToString());
                }
            }
            return acumulador;
        }

        public double getIngresosReales()
        {
            string sp = "sp_ingresos_reales";
            double acumulador = 0;
            DataTable tabla = helper.consultarStoredProcedure(sp);
            if(tabla !=null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    acumulador += Convert.ToDouble(fila[0].ToString());
                }
            }
            return acumulador;
        }

        public int getSociosActivos()
        {
            string sp = "sp_listar_socios_activos";
            DataTable tabla = helper.consultarStoredProcedure(sp);
            if (tabla != null)
                return tabla.Rows.Count;
            else
                return 0;
        }
    }
}
