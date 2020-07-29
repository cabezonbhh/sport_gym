using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Interface
{
    public interface IDAO_Cuota<Cuota>
    {
        IList<Cuota> getCuotas(int nroInscripcion);
        
    }
}
