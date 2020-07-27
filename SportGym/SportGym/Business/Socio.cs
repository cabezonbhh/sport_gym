using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Business
{
    public class Socio
    {
        public int NumeroSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public IList<Venta> Ventas { get; set; }
        public Inscripcion Inscripcion { get; set; }

        public Socio()
        {
            this.NumeroSocio = -1;
            this.Nombre = "N/D";
            this.Apellido = "N/D";
            this.Dni = "N/D";
            this.Telefono = "N/D";
            this.Celular = "N/D";
            this.Email = "N/D";
            this.Inscripcion = new Inscripcion();
            this.Ventas = new List<Venta>();
        }

    }
}
