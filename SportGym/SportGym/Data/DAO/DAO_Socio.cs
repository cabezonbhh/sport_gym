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
    public class DAO_Socio : IDAO_Socio<Socio>
    {
        DBHelper helper = DBHelper.getDBHelper();

        public int darBajaSocio(Socio socio)
        {
            throw new NotImplementedException();
        }

        public Socio getSocioPorDNI(string dni)
        {
            IList<Socio> listaSocios = getSocios();
            Socio socioRetornado = new Socio();
            foreach (Socio socio in listaSocios)
            {
                if (socio.Dni.Equals(dni))
                    socioRetornado = socio;
            }
            return socioRetornado;
        }

        public Socio getSocioPorNumero(int nro)
        {

            IList<Socio> listaSocios = getSocios();
            Socio socioRetornado = new Socio();
            foreach (Socio socio in listaSocios)
            {
                if (socio.NumeroSocio == nro)
                    socioRetornado = socio;
            }
            return socioRetornado;
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
            throw new NotImplementedException();
        }

        public IList<Socio> getSociosPorNombre(string nombre)
        {
            throw new NotImplementedException();
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
