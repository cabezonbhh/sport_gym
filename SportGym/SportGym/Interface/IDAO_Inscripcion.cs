using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Interface
{
    public interface IDAO_Inscripcion <Inscripcion>
    {
        IList<Inscripcion> getInscripciones();
    }
}
