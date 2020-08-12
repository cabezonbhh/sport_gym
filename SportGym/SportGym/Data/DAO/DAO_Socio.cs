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

        public int darBajaSocio(Socio socio)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int registrarSocio(Socio socio)
        {
            string sp = "sp_registrar_socio";
            SqlParameter[] parametros = new SqlParameter[7];
            
 

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
