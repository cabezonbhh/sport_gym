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
            dto.HoraInicio = socio.HoraInicio;
            dto.HoraFin = socio.HoraFin;
            dto.NroSocio = inscripcion.NroSocio.ToString();
            dto.NombreSocio = socio.Nombre;
            dto.ApellidoSocio = socio.Apellido;
            dto.Celular = socio.Celular.ToString();
            if(inscripcion.getUltimoPago()==null)
            {
                dto.UltimoVencimiento = "N/D";
                dto.UltimoPago = "N/D";
                dto.EstadoCuota = "NO TIENE CUOTAS";
            }
            else
            {
                dto.UltimoPago = inscripcion.getUltimoPago().FechaPago.ToShortDateString(); 
                dto.UltimoVencimiento = inscripcion.getUltimoPago().FechaFin.ToShortDateString(); 
                dto.EstadoCuota = inscripcion.getUltimoPago().getEstado();
            }    
            return dto;
        }
    }
}
