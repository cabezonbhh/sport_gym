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
    class DAO_Inscripcion : IDAO_Inscripcion<Inscripcion>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public Inscripcion getInscripcionActiva(int nroSocio)
        {
            string sp = "sp_get_inscripcion_socio";
            var parametro = new SqlParameter("@nroSocio", nroSocio);
            parametro.SqlDbType = SqlDbType.Int;

            DataTable tabla = helper.ejecutarStoredProcedureConUnParametro(sp,parametro);
            Inscripcion inscripcion = new Inscripcion();
            foreach (DataRow fila in tabla.Rows)
            {
                inscripcion = mapper(fila);              
            }
            return inscripcion;
        }

        public IList<Inscripcion> getInscripcionesActivas()
        {
            IList<Inscripcion> listaInscripciones = new List<Inscripcion>();
            DataTable tabla = helper.ejecutarStoredProcedure("sp_listar_inscripciones_activas");
            Inscripcion inscripcion = new Inscripcion();
            foreach (DataRow fila in tabla.Rows)
            {
                listaInscripciones.Add(mapper(fila));
            }
            return listaInscripciones;
        }
        
        private Inscripcion mapper(DataRow fila)
        {
            DAO_Cuota dao = new DAO_Cuota();
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.CodInscripcion = Convert.ToInt32(fila[0].ToString());
            inscripcion.FechaAlta = Convert.ToDateTime(fila[1].ToString());
            inscripcion.NroSocio = Convert.ToInt32(fila[2].ToString());
            inscripcion.Cuotas = dao.getCuotas(inscripcion.NroSocio);
            return inscripcion;
        }
    }
}
