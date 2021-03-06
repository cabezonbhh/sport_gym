﻿using SportGym.Business;
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

            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp,parametro);
            Inscripcion inscripcion = new Inscripcion();
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    inscripcion = mapper(fila);
                }
            }
            return inscripcion;
        }

        public IList<Inscripcion> getInscripcionesActivas()
        {
            IList<Inscripcion> listaInscripciones = new List<Inscripcion>();
            DataTable tabla = helper.consultarStoredProcedure("sp_listar_inscripciones_activas");
            Inscripcion inscripcion = new Inscripcion();
            if(tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaInscripciones.Add(mapper(fila));
                }
            }
            return listaInscripciones;
        }

        public IList<Inscripcion> getInscripcionesActivasPorApellido(string apellido)
        {
            string sp = "sp_inscripciones_por_apellido";
            var parametro = new SqlParameter("@apellido", apellido);
            parametro.SqlDbType = SqlDbType.VarChar;

            IList<Inscripcion> listaInscripciones = new List<Inscripcion>();
            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp,parametro);
            Inscripcion inscripcion = new Inscripcion();
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaInscripciones.Add(mapper(fila));
                }
            }
            return listaInscripciones;
        }

        public IList<Inscripcion> getInscripcionesActivasPorHora(string inicio, string fin)
        {
            string sp = "sp_listar_inscripciones_por_hora";
            SqlParameter[] parametros = new SqlParameter[2];

            var param1 = new SqlParameter("@horaInicio", inicio);
            param1.SqlDbType = SqlDbType.VarChar;

            var param2 = new SqlParameter("@horaFin", fin);
            param2.SqlDbType = SqlDbType.VarChar;

            parametros[0] = param1;
            parametros[1] = param2;

            IList<Inscripcion> listaInscripciones = new List<Inscripcion>();
            DataTable tabla = helper.consultarStoredProcedureConParametros (sp, parametros);
            Inscripcion inscripcion = new Inscripcion();
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaInscripciones.Add(mapper(fila));
                }
            }
            return listaInscripciones;
        }

        public IList<Inscripcion> getInscripcionesActivasPorNombre(string nombre)
        {
            string sp = "sp_inscripciones_por_nombre";
            var parametro = new SqlParameter("@nombre", nombre);
            parametro.SqlDbType = SqlDbType.VarChar;

            IList<Inscripcion> listaInscripciones = new List<Inscripcion>();
            DataTable tabla = helper.consultarStoredProcedureConUnParametro(sp, parametro);
            Inscripcion inscripcion = new Inscripcion();
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    listaInscripciones.Add(mapper(fila));
                }
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
