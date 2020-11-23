using SportGym.Business;
using SportGym.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Mapper
{
    public class MapperSocio
    {
        public DTO_Socio getDtoSocio(Socio socio)
        {
            DTO_Socio dto = new DTO_Socio();
            dto.NumeroSocio = socio.NumeroSocio.ToString();
            dto.Nombre = socio.Nombre;
            dto.Apellido = socio.Apellido;
            dto.Dni = socio.Dni;
            dto.Email = socio.Email;
            dto.Telefono = socio.Telefono;
            dto.Celular = socio.Celular;
            dto.Inscripcion = socio.Inscripcion.CodInscripcion.ToString();
            dto.HoraInicio = socio.HoraInicio;
            dto.HoraFin = socio.HoraFin;
            return dto;
        }

        public Socio getSocio(DTO_Socio dto)
        {
            Socio socio = new Socio();
            socio.NumeroSocio = Convert.ToInt32(dto.NumeroSocio);
            socio.Nombre = dto.Nombre;
            socio.Apellido = dto.Apellido;
            socio.Dni = dto.Dni;
            socio.Email = dto.Email;
            socio.Telefono = dto.Telefono;
            socio.Celular = dto.Celular;
            socio.HoraInicio = dto.HoraInicio;
            socio.HoraFin = dto.HoraFin;
            return socio;
        }
    }
}
