using SportGym.Business;
using SportGym.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Data
{
    public class DAO_Socio : IDAO_Socio<Socio>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public bool darBajaSocio(Socio socio)
        {
            throw new NotImplementedException();
        }

        public Socio getSocioPorNumero(int nro)
        {
            throw new NotImplementedException();
        }

        public IList<Socio> getSocios()
        {
            throw new NotImplementedException();
        }

        public IList<Socio> getSociosPorApellido(string apellido)
        {
            throw new NotImplementedException();
        }

        public IList<Socio> getSociosPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool modificarSocio(Socio socio)
        {
            throw new NotImplementedException();
        }

        public bool registrarSocio(Socio socio)
        {
            throw new NotImplementedException();
        }

        private Socio mapper(DataRow fila)
        {
            Socio socio = new Socio();
            socio.NumeroSocio = Convert.ToInt32(fila[0].ToString());
            socio.Nombre = fila[1].ToString();
            socio.Apellido = fila[2].ToString();
            socio.Email = fila[3].ToString();
            socio.Telefono = fila[4].ToString();
            socio.Celular = fila[5].ToString();
            socio.Dni = fila[6].ToString();
            return socio;
        }
    }
}
