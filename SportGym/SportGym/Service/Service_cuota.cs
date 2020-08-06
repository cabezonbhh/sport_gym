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
    public class Service_cuota
    {
        private IDAO_Cuota<Cuota> daoCuota;
        private MapperCuota mapCuota;
        public Service_cuota()
        {
            daoCuota = new DAO_Cuota();
            mapCuota = new MapperCuota();
        }
        public bool registrarNuevaCuota(DTO_Pagar_Cuota dto)
        {
            int nroSocio = Convert.ToInt32(dto.NroSocio);
            int nroInscripcion = Convert.ToInt32(dto.NroInscripcion);
            double monto = Convert.ToDouble(dto.Monto);
            DateTime inicio = Convert.ToDateTime(dto.FechaInicio);
            DateTime fin = Convert.ToDateTime(dto.FechaFin);
            return daoCuota.registrarCuota(nroSocio, nroInscripcion, monto, inicio, fin);
        }

        public bool tieneQuePagar(int nroSocio)
        {
            Service_socio service = new Service_socio();
            Cuota cuota = service.getSocioEntidad(nroSocio).Inscripcion.getUltimoPago();
            if (cuota.esVencida() == true)
                return true;
            else
                return false;
        }
    }
}
