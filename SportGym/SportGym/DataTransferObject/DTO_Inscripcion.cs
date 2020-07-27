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
        public string FechaBaja { get; set; }
        public string NroSocio { get; set; }
        public IList<DTO_Cuota> Cuotas { get; set; }
    }
}
