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

        public Cuota()
        {
            this.FechaPago = DateTime.Now.AddYears(-1000);
            this.FechaInicio = DateTime.Now.AddYears(-1000);
            this.FechaFin = DateTime.Now.AddYears(-1000);
            this.Monto = -99;
            this.NroCuota = -99;
            this.CodInscripcion = -99;
        }

        public bool esVencida()
        {
            return FechaFin.Date < DateTime.Now.Date;
        }

        public bool venceHoy()
        {
            return FechaFin.Date == DateTime.Now.Date;
        }

        public string getEstado()
        {
            if (venceHoy() == true)
            {
                return "VENCE HOY" ;
            }
            else
            {
                if (esVencida() == true)
                    return "VENCIDA";
                else
                    return "HABILITADA";
            }
            
        }

    }
}
