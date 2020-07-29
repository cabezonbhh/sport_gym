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
        private MapperInscripcion mapInscripcion;
        private MapperCuota mapCuota;
        public DTO_Socio SocioSeleccionado { get; set; }

        public Service_socio()
        {
            dao = new DAO_Socio();
            mapSocio = new MapperSocio();
            mapInscripcion = new MapperInscripcion();
            mapCuota = new MapperCuota();
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
    }
}
