using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Interface
{
    public interface IDAO_Estadisticas
    {
        double getIngresosEstimados();
        double getIngresosReales();
        int getSociosActivos();
        int getCuotasVencidas();


    }
}
