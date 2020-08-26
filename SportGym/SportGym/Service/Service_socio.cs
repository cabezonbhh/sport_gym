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
    public class Service_socio
    {
        private IDAO_Socio<Socio> dao;
        private MapperSocio mapSocio;
        public DTO_Socio SocioSeleccionado { get; set; }

        public Service_socio()
        {
            dao = new DAO_Socio();
            mapSocio = new MapperSocio();
        }

        public IList<DTO_Socio> getSocios()
        {
            IList<DTO_Socio> listaDTO = new List<DTO_Socio>();
            IList<Socio> listaSocios = dao.getSocios();
            if (listaSocios != null)
            {
                foreach (Socio socio in listaSocios)
                {
                    listaDTO.Add(mapSocio.getDtoSocio(socio));
                }
            }
            return listaDTO;
        }

        public DTO_Socio getSocio(int nroSocio)
        {
            return mapSocio.getDtoSocio(dao.getSocioPorNumero(nroSocio));
        }
        public Socio getSocioEntidad(int nroSocio)
        {
            return dao.getSocioPorNumero(nroSocio);
        }
        public IList<DTO_Socio> getSocioPorDni(string dni)
        {
            IList<DTO_Socio> lista = new List<DTO_Socio>();
            IList<Socio> listaSocios = dao.getSocioPorDNI(dni);
            if(listaSocios != null)
            {
                foreach (Socio socio in listaSocios)
                {
                    lista.Add(mapSocio.getDtoSocio(socio));
                }
            }
            return lista;
        }
        public IList<DTO_Socio> getSocioPorNombre(string nombre)
        {
            IList<DTO_Socio> lista = new List<DTO_Socio>();
            IList<Socio> listaSocios = dao.getSociosPorNombre(nombre);
            if(listaSocios != null)
            {
                foreach (Socio socio in listaSocios)
                {
                    lista.Add(mapSocio.getDtoSocio(socio));
                }
            }

            return lista;
        }

        public IList<DTO_Socio> getSocioPorApellido(string apellido)
        {
            IList<DTO_Socio> lista = new List<DTO_Socio>();
            IList<Socio> listaSocios = dao.getSociosPorApellido(apellido);
            if(listaSocios != null)
            {
                foreach (Socio socio in listaSocios)
                {
                    lista.Add(mapSocio.getDtoSocio(socio));
                }

            }
            return lista;
        }

        public IList<DTO_Socio> getSociosHorarios(string inicio, string fin)
        {

            IList<DTO_Socio> lista = new List<DTO_Socio>();
            IList<Socio> listaSocios = dao.getSocioPorHorario(inicio,fin);
            if(listaSocios != null)
            {
                foreach (Socio socio in listaSocios)
                {
                    lista.Add(mapSocio.getDtoSocio(socio));
                }
            }
            return lista;
        }
        public IList<DTO_Socio> getSociosVencidos()
        {
            IList<DTO_Socio> lista = new List<DTO_Socio>();
            IList<Socio> listaSocios = dao.getSocios();
            Cuota aux = new Cuota();
            if(listaSocios != null)
            {
                foreach (Socio socio in listaSocios)
                {
                    if (socio.Inscripcion.getUltimoPago().esVencida() == true)
                    {
                        lista.Add(mapSocio.getDtoSocio(socio));
                    }
                }
            }

            return lista;
        }
        public bool existeSocioConDni(string dni)
        {
            return dao.existeSocioConDni(dni);
        }


        public int registrarSocio(DTO_Socio dto)
        {
            return dao.registrarSocio(mapSocio.getSocio(dto));
        }

        public bool modificarSocio(DTO_Socio dto)
        {
            return dao.modificarSocio(mapSocio.getSocio(dto)) == 1;
        }

        public bool eliminarSocio(int nro)
        {
            return dao.darBajaSocio(nro) == 2;
        }
    }
}
