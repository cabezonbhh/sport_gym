using SportGym.Business;
using SportGym.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Mapper
{
    public class MapperCuota
    {
        public DTO_Cuota getDtoCuota(Cuota cuota)
        {
            DTO_Cuota dto = new DTO_Cuota();
            dto.NroCuota = cuota.NroCuota.ToString();
            dto.FechaPago = cuota.FechaPago.Date.ToString();
            dto.FechaInicio = cuota.FechaInicio.Date.ToString();
            dto.FechaFin = cuota.FechaFin.Date.ToString();
            dto.Monto = cuota.Monto.ToString();
            dto.Estado = cuota.getEstado();
            return dto;
        }

        public Cuota getCuota(DTO_Cuota dto)
        {
            Cuota cuota = new Cuota();

            return cuota;
        }
    }
}
