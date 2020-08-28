using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Interface
{
    public interface IDAO_Inscripcion <Inscripcion>
    {
        Inscripcion getInscripcionActiva(int nroSocio);
        IList<Inscripcion> getInscripcionesActivas();
        IList<Inscripcion> getInscripcionesActivasPorNombre(string nombre);
        IList<Inscripcion> getInscripcionesActivasPorApellido(string apellido);
    }
}
