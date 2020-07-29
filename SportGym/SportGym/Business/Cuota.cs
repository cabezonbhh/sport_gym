using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Business
{
    public class Cuota
    {
        public DateTime FechaPago { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Monto { get; set; }
        public int NroCuota { get; set; }
        public int CodInscripcion { get; set; }

        public bool esVencida()
        {
            return FechaFin.Date < DateTime.Now.Date;
        }

        public bool venceHoy()
        {
            return FechaFin.Date == DateTime.Now.Date;
        }

        public int getEstado()
        {
            if (venceHoy() == true)
            {
                return 0;
            }
            else
            {
                if (esVencida() == true)
                    return -1;
                else
                    return 1;
            }
            
        }

    }
}
