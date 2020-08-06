using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.DataTransferObject
{
    public class DTO_Pagar_Cuota
    {
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Monto { get; set; }
        public string NroSocio { get; set; }
        public string NroInscripcion { get; set; }

    }
}
