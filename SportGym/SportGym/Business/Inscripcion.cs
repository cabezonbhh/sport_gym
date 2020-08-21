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
        public int NroSocio { get; set; }
        public IList<Cuota> Cuotas { get; set; }

        public Cuota getUltimoPago()
        {
            DateTime mayor = new DateTime(2000, 1, 1, 0, 0, 0);
            Cuota cuota = null;
            foreach (Cuota c in Cuotas)
            {
                if (c.FechaPago > mayor)
                {
                    cuota = c;
                }
            }
            return cuota;
        }

        public IList<Cuota> getHistorialPago(int nroSocio)
        {
            return null;
        }
    }
}
