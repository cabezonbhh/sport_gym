using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Data
{
    //      La clase BDHelper ,permite quitar del código del formulario y de los DAO todo lo relacionado con el acceso a bd.
    //      Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    //      Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        private readonly string notebook = "";
        private readonly string pc = "";

        private DBHelper()
        {
            string_conexion = "";

        }

        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

    }
}
