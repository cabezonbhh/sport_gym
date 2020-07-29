using SportGym.Business;
using SportGym.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Mapper
{
    public class MapperInscripcion
    {
        public DTO_Inscripcion getDtoInscripcion(Inscripcion inscripcion, Socio socio, Cuota cuota)
        {
            DTO_Inscripcion dto = new DTO_Inscripcion();
            dto.CodInscripcion = inscripcion.CodInscripcion.ToString();
            dto.FechaAlta = inscripcion.FechaAlta.Date.ToShortDateString();
            dto.NroSocio = inscripcion.NroSocio.ToString();
            dto.NombreSocio = socio.Nombre;
            dto.ApellidoSocio = socio.Apellido;
            dto.UltimoPago = inscripcion.getUltimoPago().FechaPago.Date.ToShortDateString(); ;
            dto.UltimoVencimiento = inscripcion.getUltimoPago().FechaFin.Date.ToShortDateString(); ;
            switch (inscripcion.getUltimoPago().getEstado())
            {
                case 0:
                    dto.EstadoCuota = "VENCE HOY";
                    break;
                case 1:
                    dto.EstadoCuota = "VIGENTE";
                    break;
                case -1:
                    dto.EstadoCuota = "VENCIDA";
                    break;
                default:
                    dto.EstadoCuota = "SIN VENCIMIENTO";
                    break;
            }
            return dto;
        }
    }
}
