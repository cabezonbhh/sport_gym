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

        public bool esVencida()
        {
            //DateTime fechaActual = new DateTime();
            //fechaActual = DateTime.Now;
            return FechaFin > DateTime.Now;
        }

    }
}
