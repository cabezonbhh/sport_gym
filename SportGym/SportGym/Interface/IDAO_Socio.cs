using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Interface
{
    public interface IDAO_Socio <Socio>
    {
        IList<Socio> getSocios();
        bool registrarSocio(Socio socio);
        bool modificarSocio(Socio socio);
        bool darBajaSocio(Socio socio);
        Socio getSocioPorNumero(int nro);
        IList<Socio> getSociosPorNombre(string nombre);
        IList<Socio> getSociosPorApellido(string apellido);

    }
}
