using SportGym.Business;
using SportGym.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Mapper
{
    public class mapperCuota
    {
        public DTO_Cuota getDtoCuota(Cuota cuota)
        {
            DTO_Cuota dto = new DTO_Cuota();
            dto.NroCuota = cuota.NroCuota.ToString();
            dto.FechaPago = cuota.FechaPago.ToString();
            dto.FechaInicio = cuota.FechaInicio.ToString();
            dto.FechaFin = cuota.FechaFin.ToString();
            dto.Monto = cuota.Monto.ToString();
            if (cuota.esVencida() == true)
                dto.Estado = "VENCIDA";
            else
                dto.Estado = "VIGENTE";
            return dto;
        }

        public Cuota getCuota(DTO_Cuota dto)
        {
            Cuota cuota = new Cuota();

            return cuota;
        }
    }
}
