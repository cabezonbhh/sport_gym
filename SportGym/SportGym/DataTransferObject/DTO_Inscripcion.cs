using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.DataTransferObject
{
    public class DTO_Inscripcion
    {
        public string CodInscripcion { get; set; }
        public string FechaAlta { get; set; }
        public string HoraFin { get; set; }
        public string HoraInicio { get; set; }
        public string NroSocio { get; set; }
        public string UltimoPago { get; set; }
        public string UltimoVencimiento { get; set; }
        public string EstadoCuota { get; set; }
        public string NombreSocio { get; set; }
        public string ApellidoSocio { get; set; }
        public string Celular { get; set; }

    }
}
