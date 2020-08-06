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
            if(inscripcion.getUltimoPago()==null)
            {
                dto.UltimoPago = "N/D";
                dto.UltimoVencimiento = "N/D" ;
                dto.EstadoCuota = "NO TIENE CUOTAS";
            }
            else
            {
                dto.UltimoPago = inscripcion.getUltimoPago().FechaPago.Date.ToShortDateString(); ;
                dto.UltimoVencimiento = inscripcion.getUltimoPago().FechaFin.Date.ToShortDateString(); ;
                dto.EstadoCuota = inscripcion.getUltimoPago().getEstado();
            }    
            return dto;
        }
    }
}
