using SportGym.Data.DAO;
using SportGym.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Service
{
    public class Service_estadisticas
    {
        private IDAO_Estadisticas dao = new DAO_Estadisticas();

        public int getSociosActivos()
        {
            if (dao != null)
                return dao.getSociosActivos();
            else
                return 0;
        }

        public int getSociosVencidos()
        {
            if (dao != null)
                return dao.getCuotasVencidas();
            else
                return 0;
        }

        public double getIngresosEstimados()
        {
            if (dao != null)
                return dao.getIngresosEstimados();
            else
                return 0;
        }

        public double getIngresosReales()
        {
            if (dao != null)
                return dao.getIngresosReales();
            else
                return 0;
        }
    }
}
