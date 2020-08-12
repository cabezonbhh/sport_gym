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
        int registrarSocio(Socio socio);
        int modificarSocio(Socio socio);
        int darBajaSocio(Socio socio);
        Socio getSocioPorNumero(int nro);
        IList<Socio> getSocioPorDNI(string dni);
        IList<Socio> getSociosPorNombre(string nombre);
        IList<Socio> getSociosPorApellido(string apellido);

    }
}
