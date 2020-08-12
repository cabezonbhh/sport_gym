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
        IList<Cuota> getCuotasPorSocio(int nro);
        bool registrarCuota(int nroSocio, int nroInscripcion, double monto ,DateTime inicio, DateTime fin);
        
    }
}
