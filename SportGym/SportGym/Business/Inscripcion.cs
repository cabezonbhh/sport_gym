using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Business
{
    public class Inscripcion
    {
        public int CodInscripcion { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public int NroSocio { get; set; }
        public IList<Cuota> Cuotas { get; set; }

        public Cuota getUltimoPago()
        {
            return null;
        }

        public IList<Cuota> getHistorialPago(int nroSocio)
        {
            return null;
        }

        public IList<Cuota> getCuotasVencidas()
        {
            return null;
        }

        public bool pagarCuota(Cuota cuota)
        {
            return false;
        }

    }
}
