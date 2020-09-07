using SportGym.Business;
using SportGym.Data;
using SportGym.DataTransferObject;
using SportGym.Interface;
using SportGym.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Service
{
    public class Service_Inscripcion
    {
        private IDAO_Inscripcion<Inscripcion> daoInscripcion;
        private IDAO_Socio<Socio> daoSocio;
        private IDAO_Cuota<Cuota> daoCuota;
        private MapperSocio mapSocio;
        private MapperInscripcion mapInscripcion;
        private MapperCuota mapCuota;
        public DTO_Inscripcion CuotaSeleccionado { get; set; }

        public Service_Inscripcion()
        {
            daoInscripcion = new DAO_Inscripcion();
            daoSocio = new DAO_Socio();
            daoCuota = new DAO_Cuota();
            mapSocio = new MapperSocio();
            mapInscripcion = new MapperInscripcion();
            mapCuota = new MapperCuota();
        }
        public IList<DTO_Inscripcion> getInscripciones()
        {
            IList<DTO_Inscripcion> listaDTO = new List<DTO_Inscripcion>();
            IList<Inscripcion> listaInscripciones = daoInscripcion.getInscripcionesActivas();
            Socio socio = null;
            Cuota cuota = null;
            if (listaInscripciones != null)
            {
                foreach (Inscripcion inscripcion in listaInscripciones)
                {
                    socio = daoSocio.getSocioPorNumero(inscripcion.NroSocio);
                    cuota = inscripcion.getUltimoPago();
                    listaDTO.Add(mapInscripcion.getDtoInscripcion(inscripcion,socio,cuota));
                }
            }
            return listaDTO;
        }
        public IList<DTO_Inscripcion> getInscripcionesPorNombre(string nombre)
        {
            IList<DTO_Inscripcion> listaDTO = new List<DTO_Inscripcion>();
            IList<Inscripcion> listaInscripciones = daoInscripcion.getInscripcionesActivasPorNombre(nombre);
            Socio socio = null;
            Cuota cuota = null;
            if (listaInscripciones != null)
            {
                foreach (Inscripcion inscripcion in listaInscripciones)
                {
                    socio = daoSocio.getSocioPorNumero(inscripcion.NroSocio);
                    cuota = inscripcion.getUltimoPago();
                    listaDTO.Add(mapInscripcion.getDtoInscripcion(inscripcion, socio, cuota));
                }
            }
            return listaDTO;
        }
        public IList<DTO_Inscripcion> getInscripcionesPorApellido(string apellido)
        {
            IList<DTO_Inscripcion> listaDTO = new List<DTO_Inscripcion>();
            IList<Inscripcion> listaInscripciones = daoInscripcion.getInscripcionesActivasPorApellido(apellido);
            Socio socio = null;
            Cuota cuota = null;
            if (listaInscripciones != null)
            {
                foreach (Inscripcion inscripcion in listaInscripciones)
                {
                    socio = daoSocio.getSocioPorNumero(inscripcion.NroSocio);
                    cuota = inscripcion.getUltimoPago();
                    listaDTO.Add(mapInscripcion.getDtoInscripcion(inscripcion, socio, cuota));
                }
            }
            return listaDTO;
        }
        public IList<DTO_Inscripcion> getInscripcionesPorHora(string inicio, string fin)
        {
            IList<DTO_Inscripcion> listaDTO = new List<DTO_Inscripcion>();
            IList<Inscripcion> listaInscripciones = daoInscripcion.getInscripcionesActivasPorHora(inicio,fin);
            Socio socio = null;
            Cuota cuota = null;
            if (listaInscripciones != null)
            {
                foreach (Inscripcion inscripcion in listaInscripciones)
                {
                    socio = daoSocio.getSocioPorNumero(inscripcion.NroSocio);
                    cuota = inscripcion.getUltimoPago();
                    listaDTO.Add(mapInscripcion.getDtoInscripcion(inscripcion, socio, cuota));
                }
            }
            return listaDTO;
        }
        public IList<DTO_Inscripcion> getInscripcionesVencidas()
        {
            IList<DTO_Inscripcion> listaDTO = new List<DTO_Inscripcion>();
            IList<Inscripcion> listaInscripciones = daoInscripcion.getInscripcionesActivas();
            Socio socio = null;
            Cuota cuota = null;
            if (listaInscripciones != null)
            {
                foreach (Inscripcion inscripcion in listaInscripciones)
                {
                    socio = daoSocio.getSocioPorNumero(inscripcion.NroSocio);
                    cuota = inscripcion.getUltimoPago();
                    if(cuota != null && cuota.esVencida() == true)
                    {
                        listaDTO.Add(mapInscripcion.getDtoInscripcion(inscripcion, socio, cuota));
                    }                  
                }
            }
            return listaDTO;
        }


    }
}
