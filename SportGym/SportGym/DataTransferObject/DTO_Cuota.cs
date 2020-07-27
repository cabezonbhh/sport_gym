using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.DataTransferObject
{
    public class DTO_Cuota
    {
        public string FechaPago { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Monto { get; set; }
        public string NroCuota { get; set; }
        public string Estado { get; set; }
    }
}
